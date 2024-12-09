using _420DA3_A24_Projet.Business;
using _420DA3_A24_Projet.Business.Domain;
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
internal partial class ShipmentView : Form {
    private readonly ProjectApplication parentApp;

    public Shipment CurrentInstance { get; private set; }
    public ViewActionsEnum CurrentAction { get; private set; }

  
    public ShipmentView(ProjectApplication parentApp) {
        this.parentApp = parentApp;
        this.InitializeComponent();
    }

    //deja corrije 
    public DialogResult OpenForCreation(Shipment emptyShipment) {
        this.PreOpenSetup(ViewActionsEnum.Creation, emptyShipment, "Creation d'une Espedition", "CREER");
        return this.ShowDialog();
    }
    public DialogResult OpenForDetailsView(Shipment shipment) {
        this.PreOpenSetup(ViewActionsEnum.Visualization, shipment, "Details d'une Expedition", "OK");
        return this.ShowDialog();
    }

    private void UpdateShipmentInstanceFromControls(Shipment shipment) {
        try {
            this.ValidateControlsValues();


        } catch (Exception ex) {
            _ = MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;

        }


    }


    /*
    public DialogResult OpenForEdition(Shipment shipment) {
        this.PreOpenSetup(ViewActionsEnum.Edition, shipment, "Modification d'une Expeditions", "ENREGISTRER");
        return this.ShowDialog();

    }
    public DialogResult OpenForDeletion(Shipment shipment) {
        this.PreOpenSetup(ViewActionsEnum.Deletion, shipment, "Suppresion d'une Expedition", "SUPPRIMER");
        return this.ShowDialog();
    }

    */


    private void PreOpenSetup(ViewActionsEnum action, Shipment instance, string windowsTitle, string actionButtonText) {
        this.CurrentAction = action;
        this.CurrentInstance = instance;
        this.Text = windowsTitle;
        this.valueModeFentre.Text = action.ToString();
        this.btnAction.Text = actionButtonText;
        this.LoadShipmentDataInControls(instance);

        if (action == ViewActionsEnum.Creation ) {
            this.EnableEditableControls();
        } else {
            this.DisnableEditableControls();
        }
    }

    private void LoadShipmentDataInControls(Shipment? shipment) {
        this.valueId.Value = shipment.Id;
        this.valueShipmentStatus.SelectedValue = shipment.Status;
        this.valueShippingServices.SelectedValue = shipment.ShippingService;
        this.valueShippingOrderld.Value = shipment.ShippingOrderld;
        this.valueTrackingNumber.Text = shipment.TrackingNumber;
        this.valuedateTimePickerCreate.Value = shipment.DateCreated;
        this.valuedateTimePickerDelete.Value = shipment.DateDelete ?? DateTime.Now;
        this.valuedateTimePickerModified.Value = shipment.DateModified ?? DateTime.Now;

    }

    private void EnableEditableControls() {
        this.valueShipmentStatus.Enabled = true;
        this.valueShippingServices.Enabled = true;
        this.valueTrackingNumber.Enabled = true;

    }
    private void DisnableEditableControls() {
        this.valueShipmentStatus.Enabled = false;
        this.valueShippingServices.Enabled = false;
        this.valueTrackingNumber.Enabled = false;
    }
    private void ProcessAction() {
        switch (this.CurrentAction) {
            case ViewActionsEnum.Creation:
                this.UpdateShipmentInstanceFromControls(this.CurrentInstance);
                this.CurrentInstance = this.parentApp.ShipmentServices.CreateShipment(this.CurrentInstance);
                break;
            case ViewActionsEnum.Deletion:
                this.CurrentInstance = this.parentApp.ShipmentServices.DeleteShipment(this.CurrentInstance);
                break;
            default:
                throw new Exception("Erreur!");

        }
    }

    private void ValidateControlsValues() {
        if(this.valueShipmentStatus.Items.Count <= 0) {
            throw new Exception($"Au moins un statut doit etre selectionne");
        }
        if(this.valueShippingServices.Items.Count <= 0) {
            throw new Exception($"Au moins une services d'expeditions doit etre selectionne");
        }
        if(this.valueTrackingNumber.Text.Length < Shipment.TrackingNumberMinLength) {
            throw new Exception($"L'Expedition doit contenir au moins {Shipment.TrackingNumberMinLength} caractere.");
        }
        if (this.valueTrackingNumber.Text.Length > Shipment.TrackingNumberMaxLength) {
            throw new Exception($"L'Expedition ne doit pas contenir plus de {Shipment.TrackingNumberMaxLength} caractere");
        }
    }

    private void btnAction_Click(object sender, EventArgs e) {
        try {
            this.ProcessAction();
            this.DialogResult = DialogResult.OK;
        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }

    }

    private void btnAnnuler_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.Cancel;
    }

    private void ShipmentView_Load(object sender, EventArgs e) {

    }
}
