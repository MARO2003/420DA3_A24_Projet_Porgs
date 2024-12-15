﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Services;
using _420DA3_A24_Projet.Business.Domain;

using _420DA3_A24_Projet.DataAccess.DAOs;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

internal class WarehouseService {
    private  WarehouseDAO warehouseDAO;

    public Warehouse? OpenWarehouseWindowForCreation() {
        Warehouse newwarehouse = (Warehouse) FormatterServices.GetUninitializedObject(typeof(Warehouse));
        DialogResult result = this.view.OpenForCreation(newWarehouse);
        return result == DialogResult.OK ? newWarehouse : null;
    }

    public Warehouse? OpenWarehouseWindowForDetailsView(Warehouse wh) {
        DialogResult result = this.view.OpenForDetailsView(wh);
        return result == DialogResult.OK ? wh : null;
    }

    public Warehouse? OpenWarehouseWindowForEdition(Warehouse wh) {
        DialogResult result = this.view.OpenForEdition(wh);
        return result == DialogResult.OK ? wh : null;
    }

    public Warehouse? OpenWarehouseWindowForDeletion(Warehouse wh) {
        DialogResult result = this.view.OpenForDeletion(wh);
        return result == DialogResult.OK ? wh : null;
    }


    public WarehouseService(WarehouseDAO warehouseDAO) {
        this.warehouseDAO = warehouseDAO;
    }

    public Warehouse GetWarehouseById(int id) {
        return warehouseDAO.GetById(id);
    }

    public List<Warehouse> GetWarehousesByName(string name) {
        return warehouseDAO.GetByName(name);
    }

    public Warehouse CreateWarehouse(Warehouse warehouse) {
        // Validation des données
        if (string.IsNullOrWhiteSpace(warehouse.Name)) {
            throw new ArgumentException("Warehouse name cannot be empty.");
        }

        return warehouseDAO.Create(warehouse);
    }

    public Warehouse UpdateWarehouse(Warehouse warehouse) {
        // Validation des données
        if (string.IsNullOrWhiteSpace(warehouse.Name)) {
            throw new ArgumentException("Warehouse name cannot be empty.");
        }

        return warehouseDAO.Update(warehouse);
    }

    public Warehouse DeleteWarehouse(Warehouse warehouse, bool softDelete = true) {
        return warehouseDAO.Delete(warehouse, softDelete);
    }

    public List<Warehouse> SearchWarehouses(string criterion) {
        return warehouseDAO.Search(criterion);
    }
}