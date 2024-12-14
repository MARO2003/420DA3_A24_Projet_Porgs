using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;
using System;

namespace _420DA3_A24_Projet.Business.Services;
    internal class CustomerService {
        private readonly CustomerDAO dao;

        public CustomerService(WsysDbContext context) {
            this.dao = new CustomerDAO(context);
        }

        /// <summary>
        /// Récupère un client par son ID.
        /// </summary>
        /// <param name="id">ID du client.</param>
        /// <param name="includeDeleted">Inclure ou non les clients supprimés.</param>
        /// <returns>Le client correspondant ou null.</returns>
        public Customer? GetById(int id, bool includeDeleted = false) {
            return this.dao.GetById(id, includeDeleted);
        }

        /// <summary>
        /// Recherche des clients par un critère donné.
        /// </summary>
        /// <param name="criterion">Critère de recherche.</param>
        /// <param name="includeDeleted">Inclure ou non les clients supprimés.</param>
        /// <returns>Liste des clients correspondants.</returns>
        public List<Customer> SearchCustomers(string criterion, bool includeDeleted = false) {
            return this.dao.Search(criterion, includeDeleted);
        }

        /// <summary>
        /// Crée un nouveau client.
        /// </summary>
        /// <param name="customer">Client à créer.</param>
        /// <returns>Le client créé.</returns>
        public Customer CreateCustomer(Customer customer) {
            return this.dao.Create(customer);
        }

        /// <summary>
        /// Met à jour un client existant.
        /// </summary>
        /// <param name="customer">Client à mettre à jour.</param>
        /// <returns>Le client mis à jour.</returns>
        public Customer UpdateCustomer(Customer customer) {
            return this.dao.Update(customer);
        }

        /// <summary>
        /// Supprime un client (soft delete ou suppression définitive).
        /// </summary>
        /// <param name="customer">Client à supprimer.</param>
        /// <param name="softDelete">Indique si la suppression est douce ou définitive.</param>
        /// <returns>Le client supprimé.</returns>
        public Customer DeleteCustomer(Customer customer, bool softDelete = true) {
            return this.dao.Delete(customer, softDelete);
        }
    }

