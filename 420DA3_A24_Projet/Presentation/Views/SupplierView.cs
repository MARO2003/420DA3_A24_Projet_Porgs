﻿using _420DA3_A24_Projet.Business;
using _420DA3_A24_Projet.Business.Domain;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.VisualBasic.ApplicationServices;
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
/// <summary>
/// Management window for <see cref="Supplier"/> entities.
/// </summary>
internal partial class SupplierView : Form {

    private readonly ProjectApplication parentApp;

    /// <summary>
    /// The <see cref="ViewActionsEnum"/> value indicating the intent for which the window
    /// is currently opened or was opened last.
    /// </summary>
    public ViewActionsEnum CurrentAction { get; private set; }
    /// <summary>
    /// The working <see cref="Supplier"/> value with which the window is currently
    /// opened or was opened last.
    /// </summary>
    public Supplier CurrentEntityInstance { get; private set; } = null!;

    /// <summary>
    /// <see cref="SupplierView"/> constructor.
    /// </summary>
    /// <param name="application"></param>

    public SupplierView(ProjectApplication application) {
        this.parentApp = application;
        this.InitializeComponent();
        this.supplierNameValue.MaxLength = Supplier.SUPPLIER_NAME_MAX_LENGTH;
        this.contactLastNameValue.MaxLength = Supplier.CONTACT_LAST_NAME_MAX_LENGTH;
        this.contactFirstNameValue.MaxLength = Supplier.CONTACT_FIRST_NAME_MAX_LENGTH;
        this.contactEmailValue.MaxLength = Supplier.CONTACT_EMAIL_MAX_LENGTH;
        this.contactTelephoneValue.MaxLength = Supplier.CONTACT_TELEPHONE_MAX_LENGTH;
    }

    /// <summary>
    /// Opens a <see cref="SupplierView"/> modal window in entity creation mode.
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForCreation(Supplier instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Creation, "Creation d'un role", "Creer");
        return this.ShowDialog();
    }

    /// <summary>
    /// Opens a <see cref="SupplierView"/> modal window in entity visualization mode.
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForDetailsView(Supplier instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Visualization, "Details du role", "OK");
        return this.ShowDialog();
    }


    /// <summary>
    /// Opens a <see cref="SupplierView"/> modal window in entity edition mode.
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForModification(Supplier instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Edition, "Modifier un rôle", "Enregistrer");
        return this.ShowDialog();
    }


    /// <summary>
    /// Opens a <see cref="SupplierView"/> modal window in entity deletion mode.
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForDeletion(Supplier instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Deletion, "Supprimer un rôle", "Supprimer");
        return this.ShowDialog();
    }


    /// <summary>
    /// Performs pre-opening initialization, clean-up and preparation for the <see cref="SupplierView"/> window.
    /// </summary>
    /// <param name="instance"></param>
    /// <param name="action"></param>
    /// <param name="windowTitle"></param>
    /// <param name="actionButtonText"></param>
    private void PreOpenSetup(Supplier instance, ViewActionsEnum action, string windowTitle, string actionButtonText) {
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
    }

    /// <summary>
    /// Enables the <see cref="SupplierView"/> window's controls for creation and edition modes.
    /// </summary>
    private void ActivateControls() {
        this.supplierNameValue.Enabled = true;
        this.contactLastNameValue.Enabled = true;
        this.contactFirstNameValue.Enabled = true;
        this.contactEmailValue.Enabled = true;
        this.contactTelephoneValue.Enabled = true;
    }

    /// <summary>
    /// Disables the <see cref="SupplierView"/> window's controls for visualization and deletion modes.
    /// </summary>
    private void DeactivateControls() {
        this.supplierNameValue.Enabled = false;
        this.contactLastNameValue.Enabled = false;
        this.contactFirstNameValue.Enabled = false;
        this.contactEmailValue.Enabled = false;
        this.contactTelephoneValue.Enabled = false;
    }
    /// <summary>
    /// Loads the data of a given <paramref name="supplier"/> in the <see cref="SupplierView"/>
    /// window's controls.
    /// </summary>
    /// <param name="supplier"></param>
    /// <returns></returns>
    private Supplier LoadDataInControls(Supplier supplier) {
        this.idValue.Value = supplier.Id;
        this.supplierNameValue.Text = supplier.SupplierName;
        this.contactLastNameValue.Text = supplier.ContactLastName;
        this.contactFirstNameValue.Text = supplier.ContactFirstName;
        this.contactEmailValue.Text = supplier.ContactEmail;
        this.contactTelephoneValue.Text = supplier.ContactTelephone;
        this.dateCreatedValue.Value = supplier.DateCreated;
        this.dateModifiedValue.Value = supplier.DateModified ?? DateTime.Now;
        this.dateDeletedValue.Value = supplier.DateDeleted ?? DateTime.Now;
        this.supplierProductsValues.SelectedItems.Clear();
        foreach (Product product in supplier.Products) {
            this.supplierProductsValues.SelectedItems.Add(product);
        }
        return supplier;
    }

    /// <summary>
    /// Takes data from the basic <see cref="RoleView"/>'s controls and assigns
    /// it to the given <paramref name="supplier"/>.
    /// </summary>
    /// <param name="supplier"></param>
    /// <returns></returns>
    private Supplier SaveDataFromControls(Supplier supplier) {
        supplier.SupplierName = this.supplierNameValue.Text.Trim();
        supplier.ContactLastName = this.contactLastNameValue.Text.Trim();
        supplier.ContactFirstName = this.contactFirstNameValue.Text.Trim();
        supplier.ContactEmail = this.contactEmailValue.Text.Trim();
        supplier.ContactTelephone = this.contactTelephoneValue.Text.Trim();
        return supplier;
    }

    private void ActionButton_Click(object sender, EventArgs e) {
        try {

            switch (this.CurrentAction) {
                case ViewActionsEnum.Creation:
                    _ = this.SaveDataFromControls(this.CurrentEntityInstance);
                    this.CurrentEntityInstance = this.parentApp.SupplierService.CreateSupplierInDatabase(this.CurrentEntityInstance);
                    break;
                case ViewActionsEnum.Edition:
                    _ = this.SaveDataFromControls(this.CurrentEntityInstance);
                    this.CurrentEntityInstance = this.parentApp.SupplierService.UpdateSupplierInDatabase(this.CurrentEntityInstance);
                    break;
                case ViewActionsEnum.Deletion:
                    this.CurrentEntityInstance = this.parentApp.SupplierService.DeleteSupplierFromDatabase(this.CurrentEntityInstance);
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
    private void CancelButton_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.Cancel;
    }
    private void topBarPanel_Paint(object sender, PaintEventArgs e) {

    }

    private void bottomBarPanel_Paint(object sender, PaintEventArgs e) {

    }
}
