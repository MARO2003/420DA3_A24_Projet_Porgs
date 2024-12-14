using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;
using System;

namespace _420DA3_A24_Projet.Business.Services;
    internal class ProductService {
        private readonly ProductDAO dao;

        public ProductService(WsysDbContext context) {
            this.dao = new ProductDAO(context);
        }

        /// <summary>
        /// Récupère un produit par son ID.
        /// </summary>
        /// <param name="id">ID du produit.</param>
        /// <param name="includeDeleted">Inclure ou non les produits supprimés.</param>
        /// <returns>Le produit correspondant ou null.</returns>
        public Product? GetById(int id, bool includeDeleted = false) {
            return this.dao.GetById(id, includeDeleted);
        }

        /// <summary>
        /// Recherche des produits par un critère donné.
        /// </summary>
        /// <param name="criterion">Critère de recherche.</param>
        /// <param name="includeDeleted">Inclure ou non les produits supprimés.</param>
        /// <returns>Liste des produits correspondants.</returns>
        public List<Product> SearchProducts(string criterion, bool includeDeleted = false) {
            return this.dao.Search(criterion, includeDeleted);
        }

        /// <summary>
        /// Crée un nouveau produit.
        /// </summary>
        /// <param name="product">Produit à créer.</param>
        /// <returns>Le produit créé.</returns>
        public Product CreateProduct(Product product) {
            return this.dao.Create(product);
        }

        /// <summary>
        /// Met à jour un produit existant.
        /// </summary>
        /// <param name="product">Produit à mettre à jour.</param>
        /// <returns>Le produit mis à jour.</returns>
        public Product UpdateProduct(Product product) {
            return this.dao.Update(product);
        }

        /// <summary>
        /// Supprime un produit (soft delete ou suppression définitive).
        /// </summary>
        /// <param name="product">Produit à supprimer.</param>
        /// <param name="softDelete">Indique si la suppression est douce ou définitive.</param>
        /// <returns>Le produit supprimé.</returns>
        public Product DeleteProduct(Product product, bool softDelete = true) {
            return this.dao.Delete(product, softDelete);
        }
    }

