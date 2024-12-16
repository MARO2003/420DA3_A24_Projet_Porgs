using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.Business.Services;
using Project_Utilities.Enums;
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

namespace _420DA3_A24_Projet.Presentation.Views {
    public partial class ProductView : Form {
        private readonly ProductService productService;
        public ViewActionsEnum CurrentAction { get; private set; }
        public Product CurrentEntityInstance { get; private set; } = null!;

        internal ProductView(ProductService productService) {
            this.productService = productService;
            InitializeComponent();
            this.nameValue.MaxLength = 64; // Adjust as per Product constraints
            this.descriptionValue.MaxLength = 256; // Adjust for description
            this.weightValue.MaxLength = 10; // Assuming numeric constraint
        }

        public DialogResult OpenForCreation(Product instance) {
            this.PreOpenSetup(instance, ViewActionsEnum.Creation, "Création d'un produit", "Créer");
            return this.ShowDialog();
        }

        public DialogResult OpenForDetailsView(Product instance) {
            this.PreOpenSetup(instance, ViewActionsEnum.Visualization, "Détails du produit", "OK");
            return this.ShowDialog();
        }

        public DialogResult OpenForModification(Product instance) {
            this.PreOpenSetup(instance, ViewActionsEnum.Edition, "Modification du produit", "Enregistrer");
            return this.ShowDialog();
        }

        public DialogResult OpenForDeletion(Product instance) {
            this.PreOpenSetup(instance, ViewActionsEnum.Deletion, "Suppression du produit", "Supprimer");
            return this.ShowDialog();
        }

        private void PreOpenSetup(Product instance, ViewActionsEnum action, string windowTitle, string buttonText) {
            this.CurrentAction = action;
            this.CurrentEntityInstance = instance;
            this.Text = windowTitle;
            this.actionButtons.Text = buttonText;
            this.LoadDataInControls(instance);

            if (action == ViewActionsEnum.Creation || action == ViewActionsEnum.Edition) {
                this.ActivateControls();
            } else {
                this.DeactivateControls();
            }
        }

        private void ActivateControls() {
            nameValue.Enabled = true;
            descriptionValue.Enabled = true;
            weightValue.Enabled = true;
        }

        private void DeactivateControls() {
            nameValue.Enabled = false;
            descriptionValue.Enabled = false;
            weightValue.Enabled = false;
        }

        private Product LoadDataInControls(Product product) {
            this.idValue.Text = product.Id.ToString();
            this.nameValue.Text = product.ProductName;
            this.descriptionValue.Text = product.Description;
            this.weightValue.Text = product.Weight.ToString();
            return product;
        }

        private Product SaveDataFromControls(Product product) {
            product.ProductName = this.nameValue.Text.Trim();
            product.Description = this.descriptionValue.Text.Trim();
            decimal weight;
            product.Weight = decimal.TryParse(this.weightValue.Text, out weight) ? (double) weight : 0.0;

            return product;
        }

        private void actionButtons_Click(object sender, EventArgs e) {
            try {
                switch (this.CurrentAction) {
                    case ViewActionsEnum.Creation:
                        _ = this.SaveDataFromControls(this.CurrentEntityInstance);
                        this.CurrentEntityInstance = this.productService.CreateProduct(this.CurrentEntityInstance);
                        break;
                    case ViewActionsEnum.Edition:
                        _ = this.SaveDataFromControls(this.CurrentEntityInstance);
                        this.CurrentEntityInstance = this.productService.UpdateProduct(this.CurrentEntityInstance);
                        break;
                    case ViewActionsEnum.Deletion:
                        this.CurrentEntityInstance = this.productService.DeleteProduct(this.CurrentEntityInstance);
                        break;
                    case ViewActionsEnum.Visualization:
                        break;
                    default:
                        throw new NotImplementedException($"The action [{Enum.GetName(this.CurrentAction)}] is not implemented.");
                }
                this.DialogResult = DialogResult.OK;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
