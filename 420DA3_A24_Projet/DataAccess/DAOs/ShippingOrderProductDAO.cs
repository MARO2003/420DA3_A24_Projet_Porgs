using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;

namespace _420DA3_A24_Projet.DataAccess.DAOs {
    /// <summary>
    /// Classe DAO pour gérer les opérations liées à l'entité ShippingOrderProduct (produit d'ordre d'expédition).
    /// </summary>
    internal class ShippingOrderProductDAO {
        private readonly WsysDbContext context;

        /// <summary>
        /// Constructeur qui initialise la classe
        /// </summary>
        /// <param name="context">Le contexte de base de données.</param>
        public ShippingOrderProductDAO(WsysDbContext context) {
            this.context = context;
        }

        /// <summary>
        /// Récupère un produit d'ordre d'expédition en fonction de son ID.
        /// </summary>
        /// <param name="shippingOrderId">L'ID de l'ordre d'expédition.</param>
        /// <param name="productId">L'ID du produit.</param>
        /// <returns>Le produit d'ordre d'expédition trouvé.</returns>
        public ShippingOrderProduct? GetById(int shippingOrderId, int productId) {
            return this.context.ShippingOrdersProducts
                .Include(sop => sop.Product)
                .Include(sop => sop.ShippingOrder)
                .SingleOrDefault(sop => sop.ShippingOrderId == shippingOrderId && sop.ProductId == productId);
        }

        /// <summary>
        /// Récupère tous les produits d'un ordre d'expédition.
        /// </summary>
        /// <param name="shippingOrderId">L'ID de l'ordre d'expédition.</param>
        /// <returns>Une liste des produits d'ordre d'expédition.</returns>
        public List<ShippingOrderProduct> GetByShippingOrderId(int shippingOrderId) {
            return this.context.ShippingOrdersProducts
                .Where(sop => sop.ShippingOrderId == shippingOrderId)
                .Include(sop => sop.Product)
                .ToList();
        }

        /// <summary>
        /// Crée un nouveau produit d'ordre d'expédition dans la base de données.
        /// </summary>
        /// <param name="shippingOrderProduct">Le produit d'ordre d'expédition à ajouter.</param>
        /// <returns>Le produit d'ordre d'expédition créé.</returns>
        public ShippingOrderProduct Create(ShippingOrderProduct shippingOrderProduct) {
            _ = this.context.ShippingOrdersProducts.Add(shippingOrderProduct);
            _ = this.context.SaveChanges();
            return shippingOrderProduct;
        }

        /// <summary>
        /// Met à jour un produit d'ordre d'expédition.
        /// </summary>
        /// <param name="shippingOrderProduct">Le produit d'ordre d'expédition à mettre à jour.</param>
        /// <returns>Le produit d'ordre d'expédition mis à jour.</returns>
        public ShippingOrderProduct Update(ShippingOrderProduct shippingOrderProduct) {
            _ = this.context.ShippingOrdersProducts.Update(shippingOrderProduct);
            _ = this.context.SaveChanges();
            return shippingOrderProduct;
        }

        /// <summary>
        /// Supprime un produit d'ordre d'expédition.
        /// </summary>
        /// <param name="shippingOrderProduct">Le produit d'ordre d'expédition à supprimer.</param>
        /// <returns>Le produit d'ordre d'expédition supprimé.</returns>
        public ShippingOrderProduct Delete(ShippingOrderProduct shippingOrderProduct) {
            _ = this.context.ShippingOrdersProducts.Remove(shippingOrderProduct);
            _ = this.context.SaveChanges();
            return shippingOrderProduct;
        }

        /// <summary>
        /// Recherche des produits d'ordre d'expédition en fonction d'un critère donné.
        /// </summary>
        /// <param name="criterion">Le critère de recherche.</param>
        /// <returns>Liste des produits d'ordre d'expédition satisfaisant le critère.</returns>
        public List<ShippingOrderProduct> Search(string criterion) {
            return this.context.ShippingOrdersProducts
                .Include(sop => sop.Product)
                .Where(sop => sop.ProductId.ToString().Contains(criterion) || sop.Quantity.ToString().Contains(criterion))
                .ToList();
        }
    }
}