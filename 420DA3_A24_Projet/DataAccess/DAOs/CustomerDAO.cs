using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _420DA3_A24_Projet.DataAccess.DAOs;
    internal class CustomerDAO {
        private readonly WsysDbContext context;

        public CustomerDAO(WsysDbContext context) {
            this.context = context;
        }

        /// <summary>
        /// Récupère un client par son ID.
        /// </summary>
        public Customer? GetById(int id, bool includeDeleted = false) {
            return this.context.Customers
                .Where(customer => customer.Id == id && (includeDeleted || customer.DateDeleted == null))
                .Include(customer => customer.Products)
                .SingleOrDefault();
        }

        /// <summary>
        /// Recherche des clients en fonction d’un critère.
        /// </summary>
        public List<Customer> Search(string criterion, bool includeDeleted = false) {
            return this.context.Customers
                .Where(customer => (
                    customer.Id.ToString().Contains(criterion)
                    || customer.CustomerName.Contains(criterion)
                    || customer.ContactLastName.Contains(criterion)
                ) && (includeDeleted || customer.DateDeleted == null))
                .Include(customer => customer.Products)
                .ToList();
        }

        /// <summary>
        /// Crée un nouveau client.
        /// </summary>
        public Customer Create(Customer customer) {
            _ = this.context.Customers.Add(customer);
            _ = this.context.SaveChanges();
            return customer;
        }

        /// <summary>
        /// Met à jour un client existant.
        /// </summary>
        public Customer Update(Customer customer) {
            customer.DateModified = DateTime.Now;
            _ = this.context.Customers.Update(customer);
            _ = this.context.SaveChanges();
            return customer;
        }

        /// <summary>
        /// Supprime un client (soft delete ou suppression définitive).
        /// </summary>
        public Customer Delete(Customer customer, bool softDeletes = true) {
            if (softDeletes) {
                customer.DateDeleted = DateTime.Now;
                _ = this.context.Customers.Update(customer);
            } else {
                _ = this.context.Customers.Remove(customer);
            }
            _ = this.context.SaveChanges();
            return customer;
        }
    }

