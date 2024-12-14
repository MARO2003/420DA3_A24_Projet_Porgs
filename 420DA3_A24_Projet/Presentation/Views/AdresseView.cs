using _420DA3_A24_Projet.Business;
using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.Business.Services;
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
using System.Windows.Forms.VisualStyles;

namespace _420DA3_A24_Projet.Presentation.Views;
internal partial class AdresseView : Form {

    private readonly ProjectApplication parentApp;

    public Adresse CurrentInstance { get; private set; }
    public ViewActionsEnum CurrentAction { get; private set; }

    public AdresseView(ProjectApplication parentApp) {
        this.parentApp = parentApp;
        this.InitializeComponent();
    }

    public DialogResult OpenForCreation(Adresse emptyAdresse) {
        this.PreOpenSetup(ViewActionsEnum.Creation, emptyAdresse, "Creation d'un Adresse", "CREER");
        return this.ShowDialog();
    }

    public DialogResult OpenForDetailsView(Adresse adresse) {
        this.PreOpenSetup(ViewActionsEnum.Visualization, adresse, "Details d'un Adresse", "OK");
        return this.ShowDialog();

    }
    public DialogResult OpenForEdition(Adresse adresse) {
        this.PreOpenSetup(ViewActionsEnum.Edition, adresse, "Modification d'un Adresse", "ENREGISTRER");
        return this.ShowDialog();

    }

    public DialogResult OpenForDeletion(Adresse adresse) {
        this.PreOpenSetup(ViewActionsEnum.Deletion, adresse, "Suppresion d'un Adresse", "SUPPRIMER");
        return this.ShowDialog();

    }

    private void PreOpenSetup(ViewActionsEnum action, Adresse instance, string windowsTitle, string actionButtonText) {
        this.CurrentAction = action;
        this.CurrentInstance = instance;
        this.Text = windowsTitle;
        this.valueModeFentre.Text = action.ToString();
        this.BtnAction.Text = actionButtonText;
        this.LoadAdresseDataInControls(instance);

        if (action == ViewActionsEnum.Creation || action == ViewActionsEnum.Edition) {
            this.ActivateEdidtableControls();
        } else {
            this.DesactivateEdidtableControls();
        }
    }

    private void LoadAdresseDataInControls(Adresse adresse) {
        //TODO @MAGUETTE: Charger les donnes de l'adresse dans les controls
        this.idValue.Value = adresse.Id;
        this.valueAdresseTypeCB.SelectedValue = adresse.AdressTypes;
        this.valueAdresss.Text = adresse.Adress;
        this.valueCity.Text = adresse.City;
        this.valueCivicNumber.Text = adresse.CivicNumber;
        this.valueStreet.Text = adresse.Street;
        this.valueState.Text = adresse.State;
        this.valueCountry.Text = adresse.Country;
        this.valuePostalCode.Text = adresse.PostalCode;
        this.valuedateTimePickerCreate.Value = adresse.DateCreated;
        this.valuedateTimePickerDelete.Value = adresse.DateDelete ?? DateTime.Now;
        this.valuedateTimePickerModified.Value = adresse.DateModified ?? DateTime.Now;

    }

    private void UpdateAdresseInstanceFromControls(Adresse adresse) {
        try {
            this.ValidateControlsValues();


        } catch (Exception ex) {
            _ = MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;

        }


    }



    private void ValidateControlsValues() {
        //Adresse
        if (this.valueAdresss.Text.Length < Adresse.AdresseMinLength) {
            throw new Exception($"L'adresse doit contenir au moins {Adresse.AdresseMinLength} caracteres.");
        }
        if (this.valueAdresss.Text.Length > Adresse.AdresseMaxLength) {
            throw new Exception($"L'adresse ne doit pas contenir plus de {Adresse.AdresseMaxLength} caracteres.");
        }
        //City
        if (this.valueCity.Text.Length > Adresse.CityMaxLength) {
            throw new Exception($"Le ne nom City ne doit pas contenir plus de {Adresse.CityMaxLength} caracteres.");
        }
        if (this.valueAdresss.Text.Length < Adresse.CityMinLength) {
            throw new Exception($"Le nom du City  doit  contenir au moins {Adresse.CityMinLength} caractere");
        }
        //Civic Number
        if (this.valueCivicNumber.Text.Length > Adresse.CivicNumberMaxLength) {
            throw new Exception($"Le Numero Civic ne doit pas contenir plus de {Adresse.CivicNumberMaxLength} caractere.");
        }
        if (this.valueCivicNumber.Text.Length < Adresse.CivicNumberMinLength) {
            throw new Exception($"Le Numero Civic doit contenir au moins {Adresse.CivicNumberMinLength} caractere");
        }
        //Country
        if (this.valueCountry.Text.Length > Adresse.ContryMaxLength) {
            throw new Exception($"Le Pays  ne doit pas  contenir plus de {Adresse.ContryMaxLength} caractere.");
        }
        if (this.valueCountry.Text.Length < Adresse.ContryMinLength) {
            throw new Exception($"Le nom du Pays doit contenir au moins {Adresse.ContryMinLength} caractere");
        }
        //State
        if (this.valueState.Text.Length > Adresse.StateMaxLength) {
            throw new Exception($"Le nom de l'Etat ne doit pas contenir plus de {Adresse.StateMaxLength} caracterer.");
        }
        if (this.valueState.Text.Length < Adresse.StateMinLength) {
            throw new Exception($"Le nom de l'Eta doit contenir au moins {Adresse.StateMinLength} caractere");
        }
        //Street
        if (this.valueStreet.Text.Length > Adresse.StreeMaxLength) {
            throw new Exception($"Rue ne doit pas contenir plus de {Adresse.StreeMaxLength} caracterer.");
        }
        if (this.valueStreet.Text.Length < Adresse.StreeMinLength) {
            throw new Exception($"Le nom de la Rue doit contenir au moins {Adresse.StreeMinLength} caractere.");
        }
        //CodePostal
        if (this.valuePostalCode.Text.Length > Adresse.PostalCodeMaxLength) {
            throw new Exception($"Le Code Postale ne doit pas contenir plus de {Adresse.PostalCodeMaxLength} caractere.");
        }
        if (this.valuePostalCode.Text.Length < Adresse.PostalCodeMinLength) {
            throw new Exception($"Le code Postale doit contenir au moins {Adresse.PostalCodeMinLength} caractere");
        }
    }
    /// <summary>
    /// cette fonction permet d'activer certains controls  pour faire en sorte que l'utilisateur 
    /// puisse modifier des valeurs de dans quand il va etre en mode creation ou bien update   
    /// </summary>
    private void ActivateEdidtableControls() {
        this.valueAdresss.Enabled = true;
        this.valueCivicNumber.Enabled = true;
        this.valueAdresseTypeCB.Enabled = true;
        this.valueStreet.Enabled = true;
        this.valueCity.Enabled = true;
        this.valueState.Enabled = true;
        this.valueCountry.Enabled = true;
        this.valuePostalCode.Enabled = true;
    }

    /// <summary>
    /// Contrairement a ActivateEdidtableControls cette fonction va nous permetre de
    /// desactiver des controls dont l'utilisateur ne va pas pouvoir touche
    /// </summary>
    private void DesactivateEdidtableControls() {
        this.valueAdresss.Enabled = false;
        this.valueCivicNumber.Enabled = false;
        this.valueAdresseTypeCB.Enabled = false;
        this.valueStreet.Enabled = false;
        this.valueCity.Enabled = false;
        this.valueState.Enabled = false;
        this.valueCountry.Enabled = false;
        this.valuePostalCode.Enabled = false;

    }

    private void btnAnnuler_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.Cancel;
    }

    private void BtnAction_Click(object sender, EventArgs e) {

        try {
            this.ProcessAction();
            this.DialogResult = DialogResult.OK;
        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }

    private void ProcessAction() {

        switch (this.CurrentAction) {
            case ViewActionsEnum.Creation:
                this.UpdateAdresseInstanceFromControls(this.CurrentInstance);
                this.CurrentInstance = this.parentApp.AdresseServices.CreateAdresse(this.CurrentInstance);
                break;
            case ViewActionsEnum.Deletion:
                this.CurrentInstance = this.parentApp.AdresseServices.DeleteAdresse(this.CurrentInstance);
                break;
            case ViewActionsEnum.Edition:
                this.UpdateAdresseInstanceFromControls(this.CurrentInstance);
                this.CurrentInstance = this.parentApp.AdresseServices.UpdateAdresse(this.CurrentInstance);
                break;
            default:
                throw new Exception("Erreur!");

        }

    }

    private void AdresseView_Load(object sender, EventArgs e) {

    }
}
