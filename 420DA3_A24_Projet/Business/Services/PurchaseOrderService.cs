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




    //// <summary>
    /// Returns the list of every <see cref="PurchaseOrder"/> that exist in the data source.
    /// </summary>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    /// 

    public List<PurchaseOrder> GetAllRoles(bool includeDeleted = false) {
        try {
            return this.dao.GetAll(includeDeleted);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to retrieve the list of all existing purchaseOrders.", ex);
        }
    }




}
