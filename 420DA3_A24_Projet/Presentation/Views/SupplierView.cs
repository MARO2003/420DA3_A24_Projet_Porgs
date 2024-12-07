using _420DA3_A24_Projet.Business;
using _420DA3_A24_Projet.Business.Domain;
using Project_Utilities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _420DA3_A24_Projet.Presentation.Views;
internal partial class SupplierView : Form {
    private readonly ProjectApplication application;
    private ViewActionsEnum currentAction;
    private PurchaseOrder? currentInstance;

    public SupplierView(ProjectApplication app) {
        this.application = app;
        this.currentAction = ViewActionsEnum.Visualization;
        this.InitializeComponent();
    }
    public PurchaseOrder? GetCurrentInstance() {
        return this.currentInstance;
    }

    public DialogResult OpenFor(ViewActionsEnum currentAction , Supplier? supplier = null) {
        this.currentAction = currentAction;
        this.LoadInstanceInControls(supplier);
        switch (currentAction) {
            case ViewActionsEnum.Creation:
                this.EnableEditableControls();
                break;
            case ViewActionsEnum.Visualization:
                if(supplier is null) {
                    throw new ArgumentException($"PArameter [supplier] cannot be null for view action [{currentAction}].")
                }
        }
    }

    private void SupplierView_Load(object sender, EventArgs e) {

    }
}
