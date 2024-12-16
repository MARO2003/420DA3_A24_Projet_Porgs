using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Services;
using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

internal class WarehouseService {
    private WarehouseDAO dao;
    private WarehouseView view;
    public WarehouseService(ProjectApplication parentApp, WsysDbContext context) {
        this.dao=new WarehouseDAO(context);
        this.view = new WarehouseView(parentApp);
    }
    public Warehouse? OpenWarehouseWindowForCreation() {
        Warehouse newWarehouse = (Warehouse) FormatterServices.GetUninitializedObject(typeof(Warehouse));
        DialogResult result = this.view.OpenForCreation(newWarehouse);
        return result == DialogResult.OK ? newWarehouse : null;
    }

    public Warehouse? OpenWarehouseWindowForDetailsView(Warehouse wh) {
        DialogResult result = this.view.OpenForDetailsView(wh);
        return result == DialogResult.OK ? wh : null;
    }

    public Warehouse? OpenWarehouseWindowForEdition(Warehouse wh) {
        DialogResult result = this.view.OpenForModification(wh);
        return result == DialogResult.OK ? wh : null;
    }

    public Warehouse? OpenWarehouseWindowForDeletion(Warehouse wh) {
        DialogResult result = this.view.OpenForDeletion(wh);
        return result == DialogResult.OK ? wh : null;
    }


    

    public Warehouse GetWarehouseById(int id) {
        return dao.GetById(id);
    }

    public List<Warehouse> GetWarehousesByName(string name) {
        return dao.GetByName(name);
    }

    public Warehouse CreateWarehouse(Warehouse warehouse) {
        // Validation des données
        if (string.IsNullOrWhiteSpace(warehouse.Name)) {
            throw new ArgumentException("Warehouse name cannot be empty.");
        }

        return dao.Create(warehouse);
    }

    public Warehouse UpdateWarehouse(Warehouse warehouse) {
        // Validation des données
        if (string.IsNullOrWhiteSpace(warehouse.Name)) {
            throw new ArgumentException("Warehouse name cannot be empty.");
        }

        return dao.Update(warehouse);
    }

    public Warehouse DeleteWarehouse(Warehouse warehouse, bool softDelete = true) {
        return dao.Delete(warehouse, softDelete);
    }

    public List<Warehouse> SearchWarehouses(string criterion) {
        return dao.Search(criterion);
    }
}