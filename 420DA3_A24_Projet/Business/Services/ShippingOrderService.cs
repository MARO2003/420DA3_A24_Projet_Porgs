using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;
using Project_Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Services;
internal class ShippingOrderService {
    private ProjectApplication parentApp;
    private ShippingOrderDAO dao;
    private ShippingOrderProductDAO sopDao;
    private ShippingOrderView view;
    private WsysDbContext context;


    public ShippingOrderService(ProjectApplication parentApp, WsysDbContext context) {
        this.parentApp = parentApp;
        this.context = context;
        this.dao = new ShippingOrderDAO(context);
        this.sopDao = new ShippingOrderProductDAO(context);
        this.view = new ShippingOrderView(parentApp);
    }


    public ShippingOrder InsertShippingOrder(ShippingOrder shippingOrder, List<ShippingOrderProduct> orderProducts) { 
        try {
            // d'abord, insérer la shippingOrder pour obtenir son ID
            ShippingOrder createdOrder = this.dao.Create(shippingOrder);

            foreach (ShippingOrderProduct orderProduct in orderProducts) {
                // Ajouter le ShippingOrderProduct au tracking de EF Core
                _ = this.context.ShippingOrdersProducts.Add(orderProduct);

                // assigner l'order créée au ShippingOrderProduct
                orderProduct.ShippingOrder = createdOrder;

                // insérer la ShippingOrderProduct
                _ = this.sopDao.Create(orderProduct);

                // gérer les stocks de produits
                orderProduct.Product.QuantityInStock -= orderProduct.Quantity;
                _ = this.context.Products.Update(orderProduct.Product);

                // creer PO si qty < 50% * targetqty
                if (orderProduct.Product.QuantityInStock < 0.5 * orderProduct.Product.TargetQuantity) {
                    PurchaseOrder newPO = new PurchaseOrder(
                        Project_Utilities.Enums.PurchaseOrderStatusEnum.New,
                        orderProduct.Product.Id,
                        orderProduct.Product.Owner.AssignedWarehouseId, 
                        orderProduct.Product.TargetQuantity - orderProduct.Product.QuantityInStock
                    );
                    _ = this.context.PurchaseOrders.Add(newPO);
                }
            }

            _ = this.context.SaveChanges();
            return createdOrder;

        } catch (Exception ex) {
            throw new Exception("Failure to create new shipping order.", ex);
        }
    }


    public ShippingOrder ModifyShippingOrder(ShippingOrder shippingOrder, List<ShippingOrderProduct> newOrderProducts) {
        try {
            if (shippingOrder.Status != ShippingOrderStatusEnum.Unassigned && shippingOrder.Status != ShippingOrderStatusEnum.New) {
                throw new Exception("Only 'unassigned' or 'new' shipping orders can be edited.");
            }

            // dictionnaire pour contenir les variations de qty par produit
            Dictionary<Product, int> quantityVariations = new Dictionary<Product, int>();

            // Loop sur les nouveaux produits pour voir ceux qui ont été ajoutés / modifiés
            foreach (ShippingOrderProduct newOrderProduct in newOrderProducts) {
                ShippingOrderProduct? sopSameProductInInitialOrder =
                    shippingOrder.ShippingOrderProducts.Where(sop => {
                        return sop.ProductId == newOrderProduct.ProductId;
                    })
                    .FirstOrDefault();
                int quantityVariance;
                if (sopSameProductInInitialOrder is not null) {
                    // la Shipping Order initiale contenait déjà le produit de ce SOP
                    quantityVariance = newOrderProduct.Quantity - sopSameProductInInitialOrder.Quantity;

                } else {
                    // la Shipping Order initiale ne contenait pas déjà le produit de ce SOP
                    quantityVariance = newOrderProduct.Quantity;
                }
                quantityVariations.Add(newOrderProduct.Product, quantityVariance);
            }

            // loop sur les sop de la so initiale pour voir ceux qui ont été retirés
            foreach (ShippingOrderProduct initialOrderProduct in shippingOrder.ShippingOrderProducts) {
                if (!newOrderProducts.Any(sop => {
                    return sop.ProductId == initialOrderProduct.ProductId;
                })) {
                    // le produit de la SOP de la SO initiale n'a plus de SOP équivalent dans les newOrderProducts; il a été retiré

                    quantityVariations.Add(initialOrderProduct.Product, -1 * initialOrderProduct.Quantity);
                }
            }

            // supprimer tous les SOP initiaux
            this.context.ShippingOrdersProducts.RemoveRange(shippingOrder.ShippingOrderProducts);

            // insérer tous les nouveaux SOP
            this.context.ShippingOrdersProducts.AddRange(newOrderProducts);

            // dealer avec les variations de quantité en stock
            foreach (KeyValuePair<Product, int> variation in quantityVariations) {

                // diminuer ou augmenter la quantité en stock
                variation.Key.QuantityInStock -= variation.Value;
                _ = this.context.Products.Update(variation.Key);

                if (variation.Value > 0) { 
                    // la quantité du produit a été augmentée dans la shipping order:
                    // creer PO si qty < 50% * target qty
                    if (variation.Key.QuantityInStock < 0.5 * variation.Key.TargetQuantity) {
                        PurchaseOrder newPO = new PurchaseOrder(
                            Project_Utilities.Enums.PurchaseOrderStatusEnum.New,
                            variation.Key.Id,
                            variation.Key.Owner.AssignedWarehouseId,
                            variation.Key.TargetQuantity - variation.Key.QuantityInStock
                        );
                        _ = this.context.PurchaseOrders.Add(newPO);
                    }

                }
            }

            return this.dao.Update(shippingOrder);

        } catch (Exception ex) {
            throw new Exception("Failure to update shipping order.", ex);
        }
    }

    internal object OpenManagementWindowForVisualization(ShippingOrder selectedOrder) {
        try {
            // Créer une instance de la vue de gestion des commandes d'expédition
            ShippingOrderView view = new ShippingOrderView(this.parentApp);

            // Passer l'ordre d'expédition sélectionné à la vue pour l'affichage
            view.ChargerProduits(selectedOrder);

            // Afficher la vue (vous pouvez utiliser ShowDialog si c'est une fenêtre modale)
            view.ShowDialog();

            return selectedOrder; // Retourner l'ordre d'expédition pour d'éventuelles utilisations ultérieures
        } catch (Exception ex) {
            throw new Exception("Failed to open visualization window for shipping order.", ex);
        }
    }
}
