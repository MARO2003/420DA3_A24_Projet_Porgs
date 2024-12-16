using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;
using Project_Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace _420DA3_A24_Projet.Business.Services;
internal class CustomerService {
    private readonly CustomerDAO dao;
    private readonly CustomerView view;

    public CustomerService(ProjectApplication parentApp, WsysDbContext context) {
        this.dao = new CustomerDAO(context);
        this.view = new CustomerView(new CustomerService(parentApp, context));
    }

    public Customer? OpenCustomerWindowForCreation() {
        Customer newCustomer = (Customer) FormatterServices.GetUninitializedObject(typeof(Customer));
        DialogResult result = this.view.OpenForCreation(newCustomer);
        return result == DialogResult.OK ? newCustomer : null;
    }

    public Customer? OpenCustomerWindowForDetailsView(Customer customer) {
        DialogResult result = this.view.OpenForDetailsView(customer);
        return result == DialogResult.OK ? customer : null;
    }

    public Customer? OpenCustomerWindowForEdition(Customer customer) {
        DialogResult result = this.view.OpenForModification(customer);
        return result == DialogResult.OK ? customer : null;
    }

    public Customer? OpenCustomerWindowForDeletion(Customer customer) {
        DialogResult result = this.view.OpenForDeletion(customer);
        return result == DialogResult.OK ? customer : null;
    }

    public Customer? GetById(int id, bool includeDeleted = false) {
        return this.dao.GetById(id, includeDeleted);
    }

    public List<Customer> SearchCustomers(string criterion, bool includeDeleted = false) {
        return this.dao.Search(criterion, includeDeleted);
    }

    public Customer UpdateCustomer(Customer customer) {
        return this.dao.Update(customer);
    }

    public Customer DeleteCustomer(Customer customer, bool softDelete = true) {
        return this.dao.Delete(customer, softDelete);
    }

    public Customer CreateCustomer(Customer customer) {
        return this.dao.Create(customer);
    }
}
