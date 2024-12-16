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
internal class ProductService {
    private readonly ProductDAO dao;
    private readonly ProductView view;

    public ProductService(ProjectApplication parentApp, WsysDbContext context) {
        this.dao = new ProductDAO(context);
        this.view = new ProductView(new ProductService(parentApp, context));
    }

    public Product? OpenProductWindowForCreation() {
        Product newProduct = (Product) FormatterServices.GetUninitializedObject(typeof(Product));
        DialogResult result = this.view.OpenForCreation(newProduct);
        return result == DialogResult.OK ? newProduct : null;
    }

    public Product? OpenProductWindowForDetailsView(Product product) {
        DialogResult result = this.view.OpenForDetailsView(product);
        return result == DialogResult.OK ? product : null;
    }

    public Product? OpenProductWindowForEdition(Product product) {
        DialogResult result = this.view.OpenForModification(product);
        return result == DialogResult.OK ? product : null;
    }

    public Product? OpenProductWindowForDeletion(Product product) {
        DialogResult result = this.view.OpenForDeletion(product);
        return result == DialogResult.OK ? product : null;
    }

    public Product? GetById(int id, bool includeDeleted = false) {
        return this.dao.GetById(id, includeDeleted);
    }

    public List<Product> SearchProducts(string criterion, bool includeDeleted = false) {
        return this.dao.Search(criterion, includeDeleted);
    }

    public Product UpdateProduct(Product product) {
        return this.dao.Update(product);
    }

    public Product DeleteProduct(Product product, bool softDelete = true) {
        return this.dao.Delete(product, softDelete);
    }

    public Product CreateProduct(Product product) {
        return this.dao.Create(product);
    }
}
