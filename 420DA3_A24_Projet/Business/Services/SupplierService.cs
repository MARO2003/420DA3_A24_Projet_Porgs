using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;
using Project_Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Services;
internal class SupplierService {
    private readonly ProjectApplication application;
    private readonly SupplierDAO dao;
    private readonly SupplierView view;

    public SupplierService(ProjectApplication app , WsysDbContext context) {
        this.application = app;
        this.dao = new SupplierDAO(context);
        this.view = new SupplierView(app);
    }

    public Supplier? GetById(int id , bool includeDeleted = false) {
        return this.dao.GetById(id, includeDeleted);
    }

    public Supplier? GetBySupplierName(string supplierName , bool includeDeleted = false) {
        return this.dao.GetBySupplierName(supplierName, includeDeleted);
    }

    public List<Supplier> Search(string criterion , bool includeDeleted = false) {
        return this.dao.Search(criterion, includeDeleted);
    }

    public Supplier CreateNewSupplier(Supplier supplier) {
        return this.dao.Create(supplier);
    }

    public Supplier UpdateSupplier(Supplier supplier) {
        return this.dao.Update(supplier);
    }

    public Supplier DeleteSupplier(Supplier supplier , bool softDeletes = true) {
        return this.dao.Delete(supplier, softDeletes);
    }





    public SupplierView? OpenViewFor(ViewActionsEnum viewAction ,Supplier? supplier = null) {
        DialogResult result = this.view.OpenFor(viewAction, supplier);
        if(result == DialogResult.OK) {
            switch (viewAction) {
                case ViewActionsEnum.Creation:
                case ViewActionsEnum.Edition:
                    _= this.OpenViewFor(ViewActionsEnum.Visualization , this.view.GetCurrentIns)
            }
        }
    }

}
