using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Services;
internal class ShippingOrderService {
    private ProjectApplication parentApp;
    private ShippingOrderDAO dao;
    private ShippingOrderView view;


    public ShippingOrderService(ProjectApplication parentApp, WsysDbContext context) {
        this.parentApp = parentApp;
        this.dao = new ShippingOrderDAO(context);
        this.view = new ShippingOrderView(parentApp);
    }
}
