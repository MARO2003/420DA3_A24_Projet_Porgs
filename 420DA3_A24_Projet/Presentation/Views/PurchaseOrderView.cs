using _420DA3_A24_Projet.Business;
using _420DA3_A24_Projet.Business.Domain;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Project_Utilities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _420DA3_A24_Projet.Presentation.Views;
internal partial class PurchaseOrderView : Form {

    private readonly ProjectApplication parentApp;
    /// <summary>
    /// The <see cref="ViewActionsEnum"/> value indicating the intent for which the window
    /// is currently opened or was opened last.
    /// </summary>
    public ViewActionsEnum CurrentAction { get; private set; }
    /// <summary>
    /// The working <see cref="PurchaseOrder"/> value with which the window is currently
    /// opened or was opened last.
    /// </summary>
    public PurchaseOrder CurrentEntityInstance { get; private set; } = null;
    /// <summary>
    /// <see cref="PurchaseOrderView"/> constructor.
    /// </summary>
    /// <param name="application"></param>
    public PurchaseOrderView(ProjectApplication application) {
        this.parentApp = application;
        this.InitializeComponent();
        //this.copyrightLabel.Text = this.application.GetCopyrightNotice();
    }

    /// <summary>
    /// Opens a <see cref="PurchaseOrderView"/> modal window in entity creation mode.
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForCreation(PurchaseOrder instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Creation, "Création d'un PurchaseOrder", "Créer");
        return this.ShowDialog();
    }

    /// <summary>
    /// Opens a <see cref="PurchaseOrderView"/> modal window in entity visualization mode.
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForDetailsView(PurchaseOrder instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Visualization, "Détails d'un PurchaseOrder", "OK");
        return this.ShowDialog();
    }
    /// <summary>
    /// Opens a <see cref="PurchaseOrderView"/> modal window in entity edition mode.
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForModification(PurchaseOrder instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Edition, "Modifier un PurchaseOrder", "Enregistrer");
        return this.ShowDialog();
    }

    /// <summary>
    /// Opens a <see cref="PurchaseOrderView"/> modal window in entity deletion mode.
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForDeletion(PurchaseOrder instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Deletion, "Supprimer un PurchaseOrder", "Supprimer");
        return this.ShowDialog();
    }

    /// <summary>
    /// Performs pre-opening initialization, clean-up and preparation for the <see cref="PurchaseOrderView"/> window.
    /// </summary>
    /// <param name="instance"></param>
    /// <param name="action"></param>
    /// <param name="windowTitle"></param>
    /// <param name="actionButtonText"></param>
    private void PreOpenSetup(PurchaseOrder instance, ViewActionsEnum action, string windowTitle, string actionButtonText) {
        // remember what the current action is
        this.CurrentAction = action;
        // remember which instance we are currently working with
        this.CurrentEntityInstance = instance;
        // Change window title
        this.Text = windowTitle;
        // change action button text
        this.ActionBtn.Text = actionButtonText;
        // display the current action in the top bar
        this.openendModeValue.Text = Enum.GetName(action);
        // load data from the current instance in the controls
        _ = this.LoadDataInControls(instance);
        // activate or deactivate the editable controls depending on the action
        if (action == ViewActionsEnum.Creation || action == ViewActionsEnum.Edition) {
            this.ActivateControls();
        } else {
            this.DeactivateControls();
        }
        //load combobox status with the values
        this.statusValue.Items.Clear();
        this.statusValue.Items.AddRange(Enum.GetNames(typeof(PurchaseOrderStatusEnum)));
    }
    /// <summary>
    /// Enables the <see cref="PurchaseOrderView"/> window's controls for creation and edition modes.
    /// </summary>
    private void ActivateControls() {
        this.statusValue.Enabled = true;
        this.quantityValue.Enabled = true;
    }

    /// <summary>
    /// Disables the <see cref="PurchaseOrderView"/> window's controls for visualization and deletion modes.
    /// </summary>
    private void DeactivateControls() {
        this.statusValue.Enabled = false;
        this.quantityValue.Enabled = false;
    }

    /// <summary>
    /// Loads the data of a given <paramref name="purchaseOrder"/> in the <see cref="PurchaseOrderView"/>
    /// window's controls.
    /// </summary>
    /// <param name="purchaseOrder"></param>
    /// <returns></returns>
    private PurchaseOrder LoadDataInControls(PurchaseOrder purchaseOrder) {
        //load combobox status with the values
        this.statusValue.Items.Clear();
        this.statusValue.Items.AddRange(Enum.GetNames(typeof(PurchaseOrderStatusEnum)));

        this.idValue.Text = purchaseOrder.Id.ToString();
        this.statusValue.SelectedItem = purchaseOrder.Status;
        this.quantityValue.Text = purchaseOrder.Quantity.ToString();
        this.completionDateValue.Text = purchaseOrder.CompletionDate.ToString();
        this.dateCreatedValue.Text = purchaseOrder.DateCreated.ToString();
        return purchaseOrder;
    }
    /// <summary>
    /// Takes data from the basic <see cref="RoleView"/>'s controls and assigns
    /// it to the given <paramref name="purchaseOrder"/>.
    /// </summary>
    /// <param name="purchaseOrder"></param>
    /// <returns></returns>
    private PurchaseOrder SaveDataFromControls(PurchaseOrder purchaseOrder) {
        purchaseOrder.Status = (PurchaseOrderStatusEnum) Enum.Parse(typeof(PurchaseOrderStatusEnum), this.statusValue.SelectedItem.ToString());
        purchaseOrder.Quantity = this.quantityValue.Text.Trim();
        return purchaseOrder;
    }





    private void PurchaseOrderView_Load(object sender, EventArgs e) {

    }

    private void ActionBtn_Click(object sender, EventArgs e) {
        try {

            switch (this.CurrentAction) {
                case ViewActionsEnum.Creation:
                    _ = this.SaveDataFromControls(this.CurrentEntityInstance);
                    this.CurrentEntityInstance = this.parentApp.PurchaseOrderService.CreatePurchaseOrder(this.CurrentEntityInstance);
                    break;
                case ViewActionsEnum.Edition:
                    _ = this.SaveDataFromControls(this.CurrentEntityInstance);
                    this.CurrentEntityInstance = this.parentApp.PurchaseOrderService.UpdatePurchaseOrder(this.CurrentEntityInstance);
                    break;
                case ViewActionsEnum.Deletion:
                    this.CurrentEntityInstance = this.parentApp.PurchaseOrderService.DeletePurchaseOrder(this.CurrentEntityInstance);
                    break;
                case ViewActionsEnum.Visualization:
                    break;
                default:
                    throw new NotImplementedException($"The view action [{Enum.GetName(this.CurrentAction)}] is not implemented in [{this.GetType().ShortDisplayName}].");
            }
            this.DialogResult = DialogResult.OK;

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }

    private void cancelBtnn_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.Cancel;
    }
}
