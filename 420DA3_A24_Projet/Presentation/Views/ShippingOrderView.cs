using _420DA3_A24_Projet.Business;
using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
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
internal partial class ShippingOrderView : Form {

    private ProjectApplication app;
    private List<ShippingOrderProduct> products;
    public ShippingOrderView(ProjectApplication application) {

        this.app = application;
        InitializeComponent();
    }


    public ViewActionsEnum Action;

    public ShippingOrder currentEntity;

    public DialogResult OpenForCreation(ShippingOrder instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Creation, "Création d'un utilisateur", "Créer");
        return this.ShowDialog();
    }

    /// <summary>
    /// Opens a <see cref="UserView"/> modal window in entity visualization mode.
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForDetailsView(ShippingOrder instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Visualization, "Détails d'un utilisateur", "OK");
        return this.ShowDialog();
    }

    /// <summary>
    /// Opens a <see cref="UserView"/> modal window in entity edition mode.
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForModification(ShippingOrder instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Edition, "Modifier un utilisateur", "Enregistrer");
        return this.ShowDialog();
    }

    /// <summary>
    /// Opens a <see cref="UserView"/> modal window in entity deletion mode.
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForDeletion(ShippingOrder instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Deletion, "Supprimer un utilisateur", "Supprimer");
        return this.ShowDialog();
    }

    /// <summary>
    /// Performs pre-opening initialization, clean-up and preparation for the <see cref="UserView"/> window.
    /// </summary>
    /// <param name="instance"></param>
    /// <param name="action"></param>
    /// <param name="windowTitle"></param>
    /// <param name="actionButtonText"></param>
    private void PreOpenSetup(ShippingOrder instance, ViewActionsEnum action, string windowTitle, string actionButtonText) {
        // load selectors with items if not loaded
        this.InitializeComponent();
        // remember what the current action is
        this.Action = action;
        // remember which instance we are currently working with
        this.currentEntity = instance;
        // Change window title
        this.Text = windowTitle;
        // change action button text
        this.RetirerProduitbtn.Text = actionButtonText;
        // display the current action in the top bar
        this.openendModeValue.Text = Enum.GetName(action);
        // load data from the current instance in the controls
        this.ChargerProduits(instance);
        // activate or deactivate the editable controls depending on the action
        if (action == ViewActionsEnum.Creation || action == ViewActionsEnum.Edition) {
            this.ActivateControls();
        } else {
            this.DeactivateControls();
        }
    }

    private void ActivateControls() {
        this.Ajouterbtn.Enabled = this.Actionbtn.Enabled = this.CreateAdressebtn.Enabled = this.RetirerProduitbtn.Enabled = true;
    }

    private void DeactivateControls() {
        this.Ajouterbtn.Enabled=this.Actionbtn.Enabled=this.CreateAdressebtn.Enabled=this.RetirerProduitbtn.Enabled=false;
    }

    private void ChargerProduits(ShippingOrder shippingOrder) {
        List<ShippingOrderProduct> products = new List<ShippingOrderProduct>();

        foreach (ShippingOrderProduct product in shippingOrder.ShippingOrderProducts) {
            ShippingOrderProduct sop = new ShippingOrderProduct(product.ShippingOrderId, product.ProductId, product.Quantity);
            products.Add(sop);

        }
        this.products = products;
    }

    private void Ajouterbtn_Click(object sender, EventArgs e) {
        Product? selectedProduct = this.productSearchResultsListBox.SelectedItem as Product;
        int selectedQuantity = (int) this.QuantiteAjoutValue.Value;
        if (selectedProduct != null) {
            ShippingOrderProduct sop = new ShippingOrderProduct(selectedProduct, selectedQuantity);
            this.products.Add(sop);
            this.productSearchResultsListBox.Items.Remove(selectedProduct);
            this.OrderProductslist.Items.Add(sop);
        }

    }

    private void RetirerProduitbtn_Click(object sender, EventArgs e) {
        ShippingOrderProduct? sop = this.OrderProductslist.SelectedItem as ShippingOrderProduct;
        if (sop != null) {
            this.OrderProductslist.Items.Remove(sop);
            this.productSearchResultsListBox.Items.Add(sop.Product);
            this.products.Remove(sop);
        }

    }

    private void ChangerQTYnumericUpDown_ValueChanged(object sender, EventArgs e) {
        ShippingOrderProduct? sop = this.OrderProductslist.SelectedItem as ShippingOrderProduct;
        int qty=(int)this.ChangerQTYnumericUpDown.Value;
        if (sop != null) {
            sop.Quantity = qty;
            
        }
    }
    private void Actionbtn_Click(object sender, EventArgs e) {

    }





    private void IdValue_ValueChanged(object sender, EventArgs e) {

    }
    private void productSearchResultsListBox_SelectedIndexChanged(object sender, EventArgs e) {
        if (this.productSearchResultsListBox.SelectedItem is not Product product) {
            this.Ajouterbtn.Enabled = false;
            this.QuantiteAjoutValue.Enabled = false;
        } else {
            this.Ajouterbtn.Enabled = true;
            this.QuantiteAjoutValue.Enabled = true;
        }
    }

    private void OrderProductslist_SelectedIndexChanged(object sender, EventArgs e) {
        if (this.OrderProductslist.SelectedItem is not ShippingOrderProduct sop) {
            this.ChangerQTYnumericUpDown.Enabled = false;
            this.RetirerProduitbtn.Enabled = false;
        } else {
            ChangerQTYnumericUpDown.Maximum = sop.Product.QuantityInStock;
            this.ChangerQTYnumericUpDown.Enabled = true;
            this.RetirerProduitbtn.Enabled = true;
            this.ChangerQTYnumericUpDown.Value = sop.Quantity;
        }
    }

    private void CreateAdressebtn_Click(object sender, EventArgs e) {
        this.app.AdresseServices.OpenAdresseWindowForCreation();
    }
}
