using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Project_Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Services;
internal class SupplierService {
    private readonly ProjectApplication application;
    private readonly SupplierDAO dao;
    private readonly SupplierView view;


    /// <summary>
    /// <see cref="SupplierService"/> constructor.
    /// </summary>
    /// <param name="parentApp"></param>
    /// <param name="context"></param>
    public SupplierService(ProjectApplication parentApp , WsysDbContext context) {
        this.application = parentApp;
        this.dao = new SupplierDAO(context);
        this.view = new SupplierView(parentApp);
    }


    /// <summary>
    /// Opens the <see cref="SupplierView">Supplier management window</see> in creation mode.
    /// </summary>
    /// <returns></returns>
    /// 
    public Supplier? OpenManagementWindowForCreation() {
        try {
            Supplier newSupplier = (Supplier) FormatterServices.GetUninitializedObject(typeof(Supplier));
            DialogResult result = this.view.OpenForCreation(newSupplier);
            return result == DialogResult.OK
                ? this.view.CurrentEntityInstance
                : null;
        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to open the Supplier management window in Supplier creation mode.", ex);
        }
    }

    /// <summary>
    /// Opens the <see cref="SupplierView">Supplier management window</see> in edition mode
    /// for the given <paramref name="supplier"/>.
    /// </summary>
    /// <param name="supplier"></param>
    /// <returns></returns>
    /// 
    public bool OpenManagementWindowForEdition(Supplier supplier) {
        try {
            DialogResult result = this.view.OpenForModification(supplier);
            return result == DialogResult.OK;
        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to open the supplier management window in supplier edition mode.", ex);
        }
    }

    /// <summary>
    /// Opens the <see cref="SupplierView">Supplier management window</see> in visualization mode
    /// for the given <paramref name="supplier"/>.
    /// </summary>
    /// <param name="supplier"></param>
    /// <returns></returns>
    /// 
    public Supplier OpenManagementWindowForVisualization(Supplier supplier) {
        try {
            _ = this.view.OpenForDetailsView(supplier);
            return supplier;
        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to open the supplier management window in supplier visualization mode.", ex);
        }
    }
    /// <summary>
    /// Opens the <see cref="SupplierView">supplier management window</see> in deletion mode
    /// for the given <paramref name="supplier"/>.
    /// </summary>
    /// <param name="supplier"></param>
    /// <returns></returns>

    public bool OpenManagementWindowForDeletion(Supplier supplier) {
        try {
            DialogResult result = this.view.OpenForDeletion(supplier);
            return result == DialogResult.OK;
        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to open the supplier management window in supplier deletion mode.", ex);
        }
    }

    /// <summary>
    /// Returns the list of every <see cref="Supplier"/> that exist in the data source.
    /// </summary>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>

    public List<Supplier> GetAllPurchaseOrders(bool includeDeleted = false) {
        try {
            return this.dao.GetAll(includeDeleted);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to retrieve the list of all existing Suppliers.", ex);
        }
    }

    /// <summary>
    /// Returns the <see cref="Supplier"/> that matches the given <paramref name="id"/> 
    /// in the data source or <see langword="null"/>.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>

    public Supplier? GetById(int id, bool includeDeleted = false) {
        try {
            return this.dao.GetById(id, includeDeleted);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to retrieve a Supplier by its Id.", ex);
        }
    }


    /// <summary>
    /// Returns the <see cref="User"/> that matches the given <paramref name="username"/> 
    /// in the data source or <see langword="null"/>.
    /// </summary>
    /// <param name="username"></param>
    /// <returns></returns>
    public Supplier? GetBySupplierName(string supplierName, bool includeDeleted = false) {
        try {
            return this.dao.GetBySupplierName(supplierName, includeDeleted);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to retrieve a user by its supplierName.", ex);
        }
    }

    /// <summary>
    /// Returns the list of every <see cref="User"/> that match the given <paramref name="criterion"/> in the data source.
    /// </summary>
    /// <param name="criterion"></param>
    /// <returns></returns>
    public List<Supplier> SearchSuppliers(string criterion, bool includeDeleted = false) {
        try {
            return this.dao.Search(criterion , includeDeleted);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to search Suppliers.", ex);
        }
    }

    /// <summary>
    /// Inserts a <see cref="Supplier"/> in the data source.
    /// </summary>
    /// <param name="supplier"></param>
    /// <returns></returns>
    public Supplier CreateSupplierInDatabase(Supplier supplier) {
        try {
            return this.dao.Create(supplier);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to insert a new supplier in the database.", ex);
        }
    }

    /// <summary>
    /// Updates a <see cref="Supplier"/> in the data source.
    /// </summary>
    /// <param name="supplier"></param>
    /// <returns></returns>
    public Supplier UpdateSupplierInDatabase(Supplier supplier) {
        try {
            return this.dao.Update(supplier);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to update a new supplier in the database.", ex);
        }
    }




    /// <summary>
    /// Deletes a <see cref="Supplier"/> from the data source.
    /// </summary>
    /// <param name="supplier"></param>
    /// <returns></returns>
    public Supplier DeleteSupplierFromDatabase(Supplier supplier) {
        try {
            return this.dao.Delete(supplier);
        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to delete a new supplier in the database.", ex);
        }
    }
}
