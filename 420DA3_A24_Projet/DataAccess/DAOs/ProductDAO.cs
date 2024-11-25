using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _420DA3_A24_Projet.DataAccess.DAOs;
    internal class ProductDAO {
        private readonly WsysDbContext context;

        public ProductDAO(WsysDbContext context) {
            this.context = context;
        }

        /// <summary>
        /// Récupère un produit par son ID.
        /// </summary>
        public Product? GetById(int id, bool includeDeleted = false) {
            return this.context.Products
                .Where(product => product.Id == id && (includeDeleted || product.DateDeleted == null))
                .Include(product => product.Owner)
                .Include(product => product.Supplier)
                .SingleOrDefault();
        }

        /// <summary>
        /// Recherche des produits en fonction d’un critère.
        /// </summary>
        public List<Product> Search(string criterion, bool includeDeleted = false) {
            return this.context.Products
                .Where(product => (
                    product.Id.ToString().Contains(criterion)
                    || product.ProductName.Contains(criterion)
                    || product.Description.Contains(criterion)
                ) && (includeDeleted || product.DateDeleted == null))
                .Include(product => product.Owner)
                .Include(product => product.Supplier)
                .ToList();
        }

        /// <summary>
        /// Crée un nouveau produit.
        /// </summary>
        public Product Create(Product product) {
            _ = this.context.Products.Add(product);
            _ = this.context.SaveChanges();
            return product;
        }

        /// <summary>
        /// Met à jour un produit existant.
        /// </summary>
        public Product Update(Product product) {
            product.DateModified = DateTime.Now;
            _ = this.context.Products.Update(product);
            _ = this.context.SaveChanges();
            return product;
        }

        /// <summary>
        /// Supprime un produit (soft delete ou suppression définitive).
        /// </summary>
        public Product Delete(Product product, bool softDeletes = true) {
            if (softDeletes) {
                product.DateDeleted = DateTime.Now;
                _ = this.context.Products.Update(product);
            } else {
                _ = this.context.Products.Remove(product);
            }
            _ = this.context.SaveChanges();
            return product;
        }
    }

