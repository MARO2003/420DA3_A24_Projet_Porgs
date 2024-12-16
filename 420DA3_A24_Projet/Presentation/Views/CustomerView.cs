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
    public partial class CustomerView : Form {
        private readonly CustomerService customerService;
        public ViewActionsEnum CurrentAction { get; private set; }
        public Customer CurrentEntityInstance { get; private set; } = null!;

        internal CustomerView(CustomerService customerService) {
            this.customerService = customerService;
            InitializeComponent();
            this.nameValue.MaxLength = 64;
            this.lastNameValue.MaxLength = 64;
            this.firstNameValue.MaxLength = 64;
            this.emailValue.MaxLength = 128;
            this.telephoneValue.MaxLength = 15;
        }

        public DialogResult OpenForCreation(Customer instance) {
            this.PreOpenSetup(instance, ViewActionsEnum.Creation, "Création d'un client", "Créer");
            return this.ShowDialog();
        }

        public DialogResult OpenForDetailsView(Customer instance) {
            this.PreOpenSetup(instance, ViewActionsEnum.Visualization, "Détails du client", "OK");
            return this.ShowDialog();
        }

        public DialogResult OpenForModification(Customer instance) {
            this.PreOpenSetup(instance, ViewActionsEnum.Edition, "Modification du client", "Enregistrer");
            return this.ShowDialog();
        }

        public DialogResult OpenForDeletion(Customer instance) {
            this.PreOpenSetup(instance, ViewActionsEnum.Deletion, "Suppression du client", "Supprimer");
            return this.ShowDialog();
        }

        private void PreOpenSetup(Customer instance, ViewActionsEnum action, string windowTitle, string buttonText) {
            this.CurrentAction = action;
            this.CurrentEntityInstance = instance;
            this.Text = windowTitle;
            this.actionBtn.Text = buttonText;
            this.LoadDataInControls(instance);

            if (action == ViewActionsEnum.Creation || action == ViewActionsEnum.Edition) {
                this.ActivateControls();
            } else {
                this.DeactivateControls();
            }
        }

        private void ActivateControls() {
            nameValue.Enabled = true;
            lastNameValue.Enabled = true;
            firstNameValue.Enabled = true;
            emailValue.Enabled = true;
            telephoneValue.Enabled = true;
        }

        private void DeactivateControls() {
            nameValue.Enabled = false;
            lastNameValue.Enabled = false;
            firstNameValue.Enabled = false;
            emailValue.Enabled = false;
            telephoneValue.Enabled = false;
        }

        private Customer LoadDataInControls(Customer customer) {
            this.idValue.Text = customer.Id.ToString();
            this.nameValue.Text = customer.CustomerName;
            this.lastNameValue.Text = customer.ContactLastName;
            this.firstNameValue.Text = customer.ContactFirstName;
            this.emailValue.Text = customer.ContactEmail;
            this.telephoneValue.Text = customer.ContactTelephone;
            return customer;
        }

        private Customer SaveDataFromControls(Customer customer) {
            customer.CustomerName = this.nameValue.Text.Trim();
            customer.ContactLastName = this.lastNameValue.Text.Trim();
            customer.ContactFirstName = this.firstNameValue.Text.Trim();
            customer.ContactEmail = this.emailValue.Text.Trim();
            customer.ContactTelephone = this.telephoneValue.Text.Trim();
            return customer;
        }

        private void actionBtn_Click(object sender, EventArgs e) {
            try {
                switch (this.CurrentAction) {
                    case ViewActionsEnum.Creation:
                        _ = this.SaveDataFromControls(this.CurrentEntityInstance);
                        this.CurrentEntityInstance = this.customerService.CreateCustomer(this.CurrentEntityInstance);
                        break;
                    case ViewActionsEnum.Edition:
                        _ = this.SaveDataFromControls(this.CurrentEntityInstance);
                        this.CurrentEntityInstance = this.customerService.UpdateCustomer(this.CurrentEntityInstance);
                        break;
                    case ViewActionsEnum.Deletion:
                        this.CurrentEntityInstance = this.customerService.DeleteCustomer(this.CurrentEntityInstance);
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

        private void cancelBtn_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
