using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Project_Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Services;
internal class PurchaseOrderService {
    private readonly ProjectApplication application;
    private readonly PurchaseOrderView view;
    private readonly PurchaseOrderDAO dao;


    /// <summary>
    /// <see cref="PurchaseOrderService"/> constructor.
    /// </summary>
    /// <param name="parentApp"></param>
    /// <param name="context"></param>
    public PurchaseOrderService(ProjectApplication parentApp, WsysDbContext context) {
        this.application = parentApp;
        this.dao = new PurchaseOrderDAO(context);
        this.view = new PurchaseOrderView(parentApp);
    }

    /// <summary>
    /// Opens the <see cref="PurchaseOrderView">PurchaseOrder management window</see> in creation mode.
    /// </summary>
    /// <returns></returns>
    public PurchaseOrder? OpenManagementWindowForCreation() {
        try {
            PurchaseOrder newPurchaseOrder = (PurchaseOrder) FormatterServices.GetUninitializedObject(typeof(PurchaseOrder));
            DialogResult result = this.view.OpenForCreation(newPurchaseOrder);
            return result == DialogResult.OK
                ? this.view.CurrentEntityInstance
                : null;
        }catch(Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to open the purchaseOrder management window in purchaseOrder creation mode.", ex);
        }
    }
    /// <summary>
    /// Opens the <see cref="PurchaseOrderView">PurchaseOrder management window</see> in edition mode
    /// for the given <paramref name="purchaseOrder"/>.
    /// </summary>
    /// <param name="purchaseOrder"></param>
    /// <returns></returns>
    /// 

    public bool OpenManagementWindowForEdition(PurchaseOrder purchaseOrder) {
        try {
            DialogResult result = this.view.OpenForModification(purchaseOrder);
            return result == DialogResult.OK;
        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to open the purchaseOrder management window in purchaseOrder edition mode.", ex);
        }
    }

    /// <summary>
    /// Opens the <see cref="PurchaseOrderView">PurchaseOrder management window</see> in visualization mode
    /// for the given <paramref name="purchaseOrder"/>.
    /// </summary>
    /// <param name="purchaseOrder"></param>
    /// <returns></returns>
    /// 

    public PurchaseOrder OpenManagementWindowForVisualization(PurchaseOrder purchaseOrder) {
        try {
            _ = this.view.OpenForDetailsView(purchaseOrder);
            return purchaseOrder;
        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to open the purchaseOrder management window in purchaseOrder visualization mode.", ex);
        }
    }
    /// <summary>
    /// Opens the <see cref="PurchaseOrderView">purchaseOrder management window</see> in deletion mode
    /// for the given <paramref name="purchaseOrder"/>.
    /// </summary>
    /// <param name="purchaseOrder"></param>
    /// <returns></returns>

    public bool OpenManagementWindowForDeletion(PurchaseOrder purchaseOrder) {
        try {
            DialogResult result = this.view.OpenForDeletion(purchaseOrder);
            return result == DialogResult.OK;
        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to open the purchaseOrder management window in purchaseOrder deletion mode.", ex);
        }
    }




    /// <summary>
    /// Returns the list of every <see cref="PurchaseOrder"/> that exist in the data source.
    /// </summary>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>

    public List<PurchaseOrder> GetAllPurchaseOrders(bool includeDeleted = false) {
        try {
            return this.dao.GetAll(includeDeleted);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to retrieve the list of all existing purchaseOrders.", ex);
        }
    }

    /// <summary>
    /// Returns the <see cref="PurchaseOrder"/> that matches the given <paramref name="id"/> 
    /// in the data source or <see langword="null"/>.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>

    public PurchaseOrder? GetById(int id, bool includeDeleted = false) {
        try {
            return this.dao.GetById(id, includeDeleted);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to retrieve a PurchaseOrder by its Id.", ex);
        }
    }


    /// <summary>
    /// Returns the list of every <see cref="PurchaseOrder"/> that match the given <paramref name="criterion"/> in the data source.
    /// </summary>
    /// <param name="criterion"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public List<PurchaseOrder> SearchPurchaseOrders(string criterion, bool includeDeleted = false) {
        try {
            return this.dao.Search(criterion, includeDeleted);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to search existing PurchaseOrders.", ex);
        }
    }


    /// <summary>
    /// Inserts a <see cref="PurchaseOrder"/> in the data source.
    /// </summary>
    /// <param name="purchaseOrder"></param>
    /// <returns></returns>
    public PurchaseOrder CreatePurchaseOrder(PurchaseOrder purchaseOrder) {
        try {
            return this.dao.Create(purchaseOrder);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to insert a new purchaseOrder in the database.", ex);
        }
    }

    /// <summary>
    /// Updates a <see cref="PurchaseOrder"/> in the data source.
    /// </summary>
    /// <param name="purchaseOrder"></param>
    /// <returns></returns>
    public PurchaseOrder UpdatePurchaseOrder(PurchaseOrder purchaseOrder) {
        try {
            return this.dao.Update(purchaseOrder);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to update a purchaseOrder in the database.", ex);
        }
    }

    /// <summary>
    /// Deletes a <see cref="PurchaseOrder"/> in the data source.
    /// </summary>
    /// <param name="purchaseOrder"></param>
    /// <param name="softDeletes"></param>
    /// <returns></returns>
    public PurchaseOrder DeletePurchaseOrder(PurchaseOrder purchaseOrder, bool softDeletes = true) {
        try {
            return this.dao.Delete(purchaseOrder, softDeletes);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to delete a purchaseOrder from the database.", ex);
        }
    }

}
