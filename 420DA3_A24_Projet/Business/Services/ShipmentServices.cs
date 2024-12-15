using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Services;
internal class ShipmentServices {
    private readonly ShipmentDAO dao;
    private readonly ShipmentView view;

    public ShipmentServices(ProjectApplication parentApp, WsysDbContext context) { 
        this.dao = new ShipmentDAO(context);
        this.view = new ShipmentView(parentApp);
    }


    public Shipment? OpenShipmentWindowForCreation() {
        Shipment newShipment = (Shipment) FormatterServices.GetUninitializedObject(typeof(Shipment));
        DialogResult result = this.view.OpenForCreation(newShipment);
        return result == DialogResult.OK ? newShipment : null;
    }

    public Shipment? OpenShipmentWindowForView(Shipment shipment) {
        DialogResult result = this.view.OpenForDetailsView(shipment);
        return result == DialogResult.OK ? shipment : null;

    }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <param name="inclutedDeleted"></param>
    /// <returns></returns>
    public Shipment? GetById(int id, bool inclutedDeleted = false) {
        return dao.GetById(id, inclutedDeleted);
     }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="trackingNumber"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public Shipment? GetByTrackinkNumberShipment(string trackingNumber, bool includeDeleted = false) {
        return dao.GetByTrackingNumber(trackingNumber, includeDeleted);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="shipment"></param>
    /// <returns></returns>
 
    public Shipment CreateShipment(Shipment shipment) { 
        return dao.Create(shipment);
    }

    public List<Shipment> Search(string criterion) {
        return this.dao.Search(criterion);
    }


    public Shipment DeleteShipment(Shipment shipment) { 
        return this.dao.Delete(shipment);
    }

    public Shipment UpdateShipment(Shipment shipment) { 
        return this.dao.Update(shipment);
    }

}
