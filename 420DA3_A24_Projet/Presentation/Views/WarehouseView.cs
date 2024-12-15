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
internal partial class WarehouseView : Form {
    private ProjectApplication parentApp;
    public WarehouseView(ProjectApplication application) {
        InitializeComponent();
        this.parentApp = application;
    }
   

    /// <summary>
    /// The <see cref="ViewActionsEnum"/> value indicating the intent for which the window
    /// is currently opened or was opened last.
    /// </summary>
    public ViewActionsEnum CurrentAction { get; private set; }
    /// <summary>
    /// The working <see cref="Warehouse"/> value with which the window is currently
    /// opened or was opened last.
    /// </summary>
    public Warehouse CurrentEntityInstance { get; private set; } = null!;

    /// <summary>
    /// <see cref="Warehouse
    /// View"/> constructor.
    /// </summary>
    /// <param name="application"></param>
    /// <summary>
    /// Opens a <see cref="Warehouse
    /// View"/> modal window in entity creation mode.
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForCreation(Warehouse instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Creation, "Création d'un utilisateur", "Créer");
        return this.ShowDialog();
    }

    /// <summary>
    /// Opens a <see cref="Warehouse
    /// View"/> modal window in entity visualization mode.
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForDetailsView(Warehouse instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Visualization, "Détails d'un utilisateur", "OK");
        return this.ShowDialog();
    }

    /// <summary>
    /// Opens a <see cref="WarehouseView"/> modal window in entity edition mode.
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForModification(Warehouse instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Edition, "Modifier un utilisateur", "Enregistrer");
        return this.ShowDialog();
    }

    /// <summary>
    /// Opens a <see cref="Warehouse
    /// View"/> modal window in entity deletion mode.
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForDeletion(Warehouse instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Deletion, "Supprimer un utilisateur", "Supprimer");
        return this.ShowDialog();
    }

    /// <summary>
    /// Performs pre-opening initialization, clean-up and preparation for the <see cref="Warehouse
    /// View"/> window.
    /// </summary>
    /// <param name="instance"></param>
    /// <param name="action"></param>
    /// <param name="windowTitle"></param>
    /// <param name="actionButtonText"></param>
    private void PreOpenSetup(Warehouse instance, ViewActionsEnum action, string windowTitle, string actionButtonText) {
        
        // remember what the current action is
        this.CurrentAction = action;
        // remember which instance we are currently working with
        this.CurrentEntityInstance = instance;
        // Change window title
        this.Text = windowTitle;
        // change action button text
        this.btnAction.Text = actionButtonText;
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
    /// Enables the <see cref="WarehouseView"/> window's controls for creation and edition modes.
    /// </summary>
    private void ActivateControls() {
        this.nameValue.Enabled = true;
        this.AdressValue.Enabled = true;
    }

    /// <summary>
    /// Disables the <see cref="WarehouseView"/> window's controls for visualization and deletion modes.
    /// </summary>
    private void DeactivateControls() {
        this.nameValue.Enabled = false;
        this.AdressValue.Enabled = false;
    }

    /// <summary>
    /// Loads the data of a given <paramref name="warehouse"/> in the <see cref="WarehouseView"/>
    /// window's controls.
    /// </summary>
    /// <param name="warehouse"></param>
    /// <returns></returns>
    private Warehouse LoadDataInControls(Warehouse warehouse) {
        this.idValue.Text = warehouse.Id.ToString();
        this.nameValue.Text = warehouse.Name;
        this.AdressValue.Text = warehouse.AddressId+"";
        this.dateCreatedValue.Text = warehouse.DateCreated.ToString();
        return warehouse;
    }

    /// <summary>
    /// Takes data from the basic <see cref="WarehouseView"/>'s controls and assigns
    /// it to the given <paramref name="warehouse"/>.
    /// </summary>
    /// <param name="warehouse"></param>
    /// <returns></returns>
    private Warehouse SaveDataFromControls(Warehouse warehouse) {
        warehouse.Name = this.nameValue.Text.Trim();
        warehouse.AddressId =int.Parse( this.AdressValue.Text.Trim());
        return warehouse;
    }

    private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) {

    }

    private void panel4_Paint(object sender, PaintEventArgs e) {

    }

    private void label3_Click(object sender, EventArgs e) {

    }

    private void userRolesLabel_Click(object sender, EventArgs e) {

    }
}
