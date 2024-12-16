using _420DA3_A24_Projet.Business;
using _420DA3_A24_Projet.Business.Domain;
using Project_Utilities.Enums;
using System.DirectoryServices;
using Project_Utilities.Presentation;

namespace _420DA3_A24_Projet.Presentation;

/// <summary>
/// Main menu window for users with the administrator <see cref="Role"/>.
/// </summary>
internal partial class AdminMainMenu : Form {

    /// <summary>
    /// Valeur générique pour indiquer qu'aucun élément n'est sélectionné dans une liste.
    /// À ajouter à vos listes pour offrir l'option "Aucun" aux utilisateurs.
    /// </summary>
    private static readonly object listNoneSelectedValue = "Aucun";

    private readonly ProjectApplication parentApp;

    /// <summary>
    /// <see cref="AdminMainMenu"/> constructor.
    /// </summary>
    /// <param name="application"></param>
    public AdminMainMenu(ProjectApplication application) {
        this.parentApp = application;
        this.InitializeComponent();
    }

    /// <summary>
    /// Opens a <see cref="AdminMainMenu"/> modal window.
    /// </summary>
    /// <returns></returns>
    public DialogResult ShowAdminMainMenu() {
        return this.ShowDialog();
    }

    private void ButtonLogout_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.None;
    }


    #region GESTION DES UTILISATEURS

    /// <summary>
    /// Empties the <see cref="User"/> search results <see cref="ListBox"/> then fills it with the given
    /// <paramref name="searchResults"/>.
    /// </summary>
    /// <param name="searchResults"></param>
    private void ReloadUserSearchResults(List<User> searchResults) {
        try {
            this.userSearchResults.SelectedItem = null;
            this.userSearchResults.SelectedIndex = -1;
            this.userSearchResults.Items.Clear();
            _ = this.userSearchResults.Items.Add(listNoneSelectedValue);
            foreach (User user in searchResults) {
                _ = this.userSearchResults.Items.Add(user);
            }

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }

    /// <summary>
    /// Enables the role action buttons.
    /// </summary>
    private void ActivateUserActionButtons() {
        this.buttonDeleteUser.Enabled = true;
        this.buttonEditUser.Enabled = true;
        this.buttonViewUser.Enabled = true;
    }

    /// <summary>
    /// Disables the user action buttons.
    /// </summary>
    private void DeactivateUserActionButtons() {
        this.buttonDeleteUser.Enabled = false;
        this.buttonEditUser.Enabled = false;
        this.buttonViewUser.Enabled = false;
    }

    private void ButtonCreateUser_Click(object sender, EventArgs e) {
        try {
            User? userCree = this.parentApp.UserService.OpenManagementWindowForCreation();
            if (userCree != null) {
                _ = this.userSearchResults.Items.Add(userCree);
                this.userSearchResults.SelectedItem = userCree;
            }

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }

    private void UserSearchTextBox_TextChanged(object sender, EventArgs e) {
        try {
            string searchCriterion = this.userSearchTextBox.Text.Trim();
            List<User> results = this.parentApp.UserService.SearchUsers(searchCriterion);
            this.ReloadUserSearchResults(results);

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }

    private void UserSearchResults_SelectedIndexChanged(object sender, EventArgs e) {
        User? selectedUSer = this.userSearchResults.SelectedItem as User;
        if (selectedUSer != null) {
            this.ActivateUserActionButtons();
        } else {
            this.DeactivateUserActionButtons();
        }
    }

    private void ButtonViewUser_Click(object sender, EventArgs e) {
        try {
            User selectedUser = (User) this.userSearchResults.SelectedItem;
            User? createdUser = this.parentApp.UserService.OpenManagementWindowForVisualization(selectedUser);
            if (createdUser != null) {
                _ = this.userSearchResults.Items.Add(createdUser);
                this.userSearchResults.SelectedItem = createdUser;
            }

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }

    private void ButtonEditUser_Click(object sender, EventArgs e) {
        try {
            User selectedUser = (User) this.userSearchResults.SelectedItem;
            bool wasUpdated = this.parentApp.UserService.OpenManagementWindowForEdition(selectedUser);
            if (wasUpdated) {
                this.userSearchResults.RefreshDisplay();
            }

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }

    }

    private void ButtonDeleteUser_Click(object sender, EventArgs e) {
        try {
            User selectedUser = (User) this.userSearchResults.SelectedItem;
            bool wasDeleted = this.parentApp.UserService.OpenManagementWindowForDeletion(selectedUser);

            if (wasDeleted) {
                this.userSearchResults.SelectedItem = null;
                this.userSearchResults.SelectedIndex = -1;
                this.userSearchResults.Items.Remove(selectedUser);
            }

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }

    }

    #endregion


    #region GESTION DES ROLES

    /// <summary>
    /// Empties the <see cref="Role"/> search results <see cref="ListBox"/> then fills it with the given
    /// <paramref name="searchResults"/>.
    /// </summary>
    /// <param name="searchResults"></param>
    private void ReloadRoleSearchResults(List<Role> searchResults) {
        try {
            this.roleSearchResults.SelectedItem = null;
            this.roleSearchResults.SelectedIndex = -1;
            this.roleSearchResults.Items.Clear();
            foreach (Role role in searchResults) {
                _ = this.roleSearchResults.Items.Add(role);
            }
            this.roleSearchResults.Refresh();

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }

    /// <summary>
    /// Enables the role action buttons.
    /// </summary>
    private void ActivateRoleActionButtons() {
        this.buttonDeleteRole.Enabled = true;
        this.buttonEditRole.Enabled = true;
        this.buttonViewRole.Enabled = true;
    }

    /// <summary>
    /// Disables the role action buttons.
    /// </summary>
    private void DeactivateRoleActionButtons() {
        this.buttonDeleteRole.Enabled = false;
        this.buttonEditRole.Enabled = false;
        this.buttonViewRole.Enabled = false;
    }

    private void ButtonCreateRole_Click(object sender, EventArgs e) {
        try {
            Role? createdRole = this.parentApp.RoleService.OpenManagementWindowForCreation();
            if (createdRole != null) {
                _ = this.roleSearchResults.Items.Add(createdRole);
                this.roleSearchResults.SelectedItem = createdRole;
            }

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }

    }

    private void RoleSearchTextBox_TextChanged(object sender, EventArgs e) {
        try {
            List<Role> results = this.parentApp.RoleService.SearchRoles(this.roleSearchTextBox.Text.Trim());
            this.ReloadRoleSearchResults(results);

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }

    }

    private void RoleSearchResults_SelectedIndexChanged(object sender, EventArgs e) {
        Role? selectedRole = this.roleSearchResults.SelectedItem as Role;
        if (selectedRole != null) {
            this.ActivateRoleActionButtons();
        } else {
            this.DeactivateRoleActionButtons();
        }
    }

    private void ButtonViewRole_Click(object sender, EventArgs e) {
        try {
            Role? selectedRole = this.roleSearchResults.SelectedItem as Role;
            if (selectedRole != null) {
                _ = this.parentApp.RoleService.OpenManagementWindowForVisualization(selectedRole);
            }

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }

    }

    private void ButtonEditRole_Click(object sender, EventArgs e) {
        try {
            Role? selectedRole = this.roleSearchResults.SelectedItem as Role;
            if (selectedRole != null) {
                bool wasUpdated = this.parentApp.RoleService.OpenManagementWindowForEdition(selectedRole);
                if (wasUpdated) {
                    this.roleSearchResults.RefreshDisplay();
                }
            }

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }

    }

    private void ButtonDeleteRole_Click(object sender, EventArgs e) {
        try {
            Role? selectedRole = this.roleSearchResults.SelectedItem as Role;
            if (selectedRole != null) {
                bool wasDeleted = this.parentApp.RoleService.OpenManagementWindowForDeletion(selectedRole);
                if (wasDeleted) {
                    this.roleSearchResults.SelectedItem = null;
                    this.roleSearchResults.SelectedIndex = -1;
                    this.roleSearchResults.Items.Remove(selectedRole);
                }
            }

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }

    }

    #endregion


    #region GESTION DES ADRESSES

    private void btnCreateAdresse_Click(object sender, EventArgs e) {
        Adresse? adresseCreer = this.parentApp.AdresseServices.OpenAdresseWindowForCreation();
        if (adresseCreer != null) {
            _ = this.adresseSearchResults.Items.Add(adresseCreer);
            this.adresseSearchResults.SelectedItem = adresseCreer;
        }
    }

    private void AdresseSearchtextBox_TextChanged(object sender, EventArgs e) {
        string criterion = this.AdresseSearchtextBox.Text.Trim();
        List<Adresse> result = this.parentApp.AdresseServices.Search(criterion);
        this.adresseSearchResults.Items.Clear();
        this.adresseSearchResults.SelectedItem = null;
        this.adresseSearchResults.SelectedIndex = -1;
        foreach (Adresse adresse in result) {
            _ = this.adresseSearchResults.Items.Add(adresse);
        }
    }

    private void adresseSearchResults_SelectedIndexChanged(object sender, EventArgs e) {
        Adresse? selectedAdresse = this.adresseSearchResults.SelectedItem as Adresse;
        if (selectedAdresse != null) {
            this.btnCreateAdresse.Enabled = true;
            this.btnUpdateAdresse.Enabled = true;
            this.btnDeleteAdresse.Enabled = true;
        } else {
            this.btnCreateAdresse.Enabled = false;
            this.btnUpdateAdresse.Enabled = false;
            this.btnDeleteAdresse.Enabled = false;
        }
    }

    private void btnViewAdresse_Click(object sender, EventArgs e) {
        Adresse? selectedAdresse = this.adresseSearchResults.SelectedItem as Adresse;
        if (selectedAdresse != null) {
            throw new Exception("Veuillez selectionner une adresse.");
        }
        _ = this.parentApp.AdresseServices.OpenAdresseWindowForView(selectedAdresse);


    }

    private void btnUpdateAdresse_Click(object sender, EventArgs e) {
        Adresse? selectedAdresse = this.adresseSearchResults.SelectedItem as Adresse;
        if (selectedAdresse != null) {
            throw new Exception("Veuillez selectionner une adresse.");
        }
        _ = this.parentApp.AdresseServices.OpenAdresseWindowForEdition(selectedAdresse);
        this.adresseSearchResults.Refresh();
    }

    private void btnDeleteAdresse_Click(object sender, EventArgs e) {
        Adresse? selectedAdresse = this.adresseSearchResults.SelectedItem as Adresse;
        if (selectedAdresse != null) {
            throw new Exception("Veuillez selectionner une adresse.");
        }
        selectedAdresse = this.parentApp.AdresseServices.OpenAdresseWindowForDeletion(selectedAdresse);
        if (selectedAdresse != null) {
            this.adresseSearchResults.Items.Remove(selectedAdresse);
            this.adresseSearchResults.SelectedItem = null;
            this.adresseSearchResults.SelectedIndex = -1;
        }

    }
    #endregion

    #region GESTION DES EXPEDITIONS
    private void btnCreateExpedition_Click(object sender, EventArgs e) {
        Shipment? shipmentCreer = this.parentApp.ShipmentServices.OpenShipmentWindowForCreation();
        if (shipmentCreer != null) {
            _ = this.expeditionSearchResults.Items.Add(shipmentCreer);
            this.expeditionSearchResults.SelectedItem = shipmentCreer;
        }
    }

    private void ExpeditionSearchtextBox_TextChanged(object sender, EventArgs e) {
        string criterion = this.ExpeditionSearchtextBox.Text.Trim();
        List<Shipment> result = this.parentApp.ShipmentServices.Search(criterion);
        this.expeditionSearchResults.Items.Clear();
        this.expeditionSearchResults.SelectedItem = null;
        this.expeditionSearchResults.SelectedIndex = -1;
        foreach (Shipment shipment in result) {
            _ = this.expeditionSearchResults.Items.Add(shipment);
        }
    }

    private void expeditionSearchResults_SelectedIndexChanged(object sender, EventArgs e) {
        Shipment? selectedShipment = this.expeditionSearchResults.SelectedItem as Shipment;
        if (selectedShipment != null) {
            this.btnViewExpedion.Enabled = true;
        } else {
            this.btnViewExpedion.Enabled = false;
        }
    }

    private void btnViewExpedion_Click(object sender, EventArgs e) {
        Shipment? selectedShipment = this.expeditionSearchResults.SelectedItem as Shipment;
        if (selectedShipment != null) {
            throw new Exception("Veuillez selectionner une expedition");
        }
        _ = this.parentApp.ShipmentServices.OpenShipmentWindowForDetailsView(selectedShipment);

    }
    #endregion

    #region GESTION DES ENTREPÔTS

    /// <summary>
    /// Vider <see cref="Warehouse"/> de la liste <see cref="whSearchResults"/> et la remplir avec la liste a jour
    /// <paramref name="searchResults"/>.
    /// </summary>
    /// <param name="searchResults"></param>
    private void ReloadWarehouseSearchResults(List<Warehouse> searchResults) {

        this.whSearchResults.SelectedItem = null;
        this.whSearchResults.SelectedIndex = -1;
        this.whSearchResults.Items.Clear();
        foreach (Warehouse warehouse in searchResults) {
            _ = this.whSearchResults.Items.Add(warehouse);
        }
        this.whSearchResults.Refresh();


    }

    /// <summary>
    /// fonction pour activer les boutons
    /// </summary>
    private void ActivateWarehouseActionButtons() {
        this.deletewhbtn.Enabled = true;
        this.EditWhbtn.Enabled = true;
        this.viewWhbtn.Enabled = true;
    }

    /// <summary>
    /// fonction pour desactiver les boutons
    /// </summary>
    private void DeactivateWarehouseActionButtons() {
        this.deletewhbtn.Enabled = false;
        this.EditWhbtn.Enabled = false;
        this.viewWhbtn.Enabled = false;
    }

    private void ButtonCreateWarehouse_Click(object sender, EventArgs e) {

        Warehouse? createdWarehouse = this.parentApp.WarehouseService.OpenWarehouseWindowForCreation();
        if (createdWarehouse != null) {
            _ = this.whSearchResults.Items.Add(createdWarehouse);
            this.whSearchResults.SelectedItem = createdWarehouse;
        }



    }

    private void WarehouseSearchTextBox_TextChanged(object sender, EventArgs e) {

        List<Warehouse> results = this.parentApp.WarehouseService.SearchWarehouses(this.whSearchResults.Text.Trim());
        this.ReloadWarehouseSearchResults(results);


    }

    private void WarehouseSearchResults_SelectedIndexChanged(object sender, EventArgs e) {
        Warehouse? selectedWarehouse = this.whSearchResults.SelectedItem as Warehouse;
        if (selectedWarehouse != null) {
            this.ActivateWarehouseActionButtons();
        } else {
            this.DeactivateWarehouseActionButtons();
        }
    }

    private void ButtonViewWarehouse_Click(object sender, EventArgs e) {

        Warehouse? selectedWarehouse = this.whSearchResults.SelectedItem as Warehouse;
        if (selectedWarehouse != null) {
            _ = this.parentApp.WarehouseService.OpenWarehouseWindowForDetailsView(selectedWarehouse);
        } else {
            throw new Exception("Pas de selection faite");

        }
    }

    private void ButtonEditWarehouse_Click(object sender, EventArgs e) {

        Warehouse? selectedWarehouse = this.whSearchResults.SelectedItem as Warehouse;
        if (selectedWarehouse != null) {
            Warehouse? UpdatedWh = this.parentApp.WarehouseService.OpenWarehouseWindowForEdition(selectedWarehouse);
            if (UpdatedWh is Warehouse) {
                this.whSearchResults.RefreshDisplay();
            }
        } else {
            throw new Exception("pas de selection faite");

        }


    }

    private void ButtonDeleteWarehouse_Click(object sender, EventArgs e) {

        Warehouse? selectedWarehouse = this.whSearchResults.SelectedItem as Warehouse;
        if (selectedWarehouse != null) {
            Warehouse? DeletedWh = this.parentApp.WarehouseService.OpenWarehouseWindowForDeletion(selectedWarehouse);
            if (DeletedWh is Warehouse) {
                this.whSearchResults.SelectedItem = null;
                this.whSearchResults.SelectedIndex = -1;
                this.whSearchResults.Items.Remove(selectedWarehouse);
            }
        } else {
            throw new Exception("Pas de selection faite");

        }
    }

    #endregion
    #region GESTION DES COMMANDES D'EXPÉDITION

    /// <summary>
    /// Empties the <see cref="ShippingOrder"/> search results <see cref="ListBox"/> then fills it with the given
    /// <paramref name="searchResults"/>.
    /// </summary>
    /// <param name="searchResults"></param>
    private void ReloadShippingOrderSearchResults(List<ShippingOrder> searchResults) {
        try {
            this.ShipOSearchResults.SelectedItem = null;
            this.ShipOSearchResults.SelectedIndex = -1;
            this.ShipOSearchResults.Items.Clear();
            foreach (ShippingOrder order in searchResults) {
                _ = this.ShipOSearchResults.Items.Add(order);
            }
            this.ShipOSearchResults.Refresh();

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }

    /// <summary>
    /// Enables the shipping order action buttons.
    /// </summary>
    private void ActivateShippingOrderActionButtons() {
        this.deleteShipObtn.Enabled = true;
        this.updateShipObtn.Enabled = true;
        this.ViewShipObtn.Enabled = true;
    }

    /// <summary>
    /// Disables the shipping order action buttons.
    /// </summary>
    private void DeactivateShippingOrderActionButtons() {
        this.deleteShipObtn.Enabled = false;
        this.updateShipObtn.Enabled = false;
        this.ViewShipObtn.Enabled = false;
    }

    private void ButtonCreateShippingOrder_Click(object sender, EventArgs e) {
        try {
            ShippingOrder? createdOrder = this.parentApp.ShippingOrderService.OpenManagementWindowForCreation();
            if (createdOrder != null) {
                _ = this.ShipOSearchResults.Items.Add(createdOrder);
                this.ShipOSearchResults.SelectedItem = createdOrder;
            }

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }

    private void ShippingOrderSearchTextBox_TextChanged(object sender, EventArgs e) {
        try {
            List<ShippingOrder> results = this.parentApp.ShippingOrderService.ShipOSearchResults(this.shippingOrderSearchTextBox.Text.Trim());
            this.ReloadShippingOrderSearchResults(results);

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }

    private void ShippingOrderSearchResults_SelectedIndexChanged(object sender, EventArgs e) {
        ShippingOrder? selectedOrder = this.ShipOSearchResults.SelectedItem as ShippingOrder;
        if (selectedOrder != null) {
            this.ActivateShippingOrderActionButtons();
        } else {
            this.DeactivateShippingOrderActionButtons();
        }
    }

    private void ButtonViewShippingOrder_Click(object sender, EventArgs e) {
        try {
            ShippingOrder? selectedOrder = this.ShipOSearchResults.SelectedItem as ShippingOrder;
            if (selectedOrder != null) {
                _ = this.parentApp.ShippingOrderService.OpenManagementWindowForVisualization(selectedOrder);
            }

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }

    private void ButtonEditShippingOrder_Click(object sender, EventArgs e) {
        try {
            ShippingOrder? selectedOrder = this.ShipOSearchResults.SelectedItem as ShippingOrder;
            if (selectedOrder != null) {
                bool wasUpdated = this.parentApp.ShippingOrderService.ModifyShippingOrder(selectedOrder);
                if (wasUpdated) {
                    this.ShipOSearchResults.RefreshDisplay();
                }
            }

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }

    private void ButtonDeleteShippingOrder_Click(object sender, EventArgs e) {
        try {
            ShippingOrder? selectedOrder = this.ShipOSearchResults.SelectedItem as ShippingOrder;
            if (selectedOrder != null) {
                bool wasDeleted = this.parentApp.ShippingOrderService.OpenManagementWindowForDeletion(selectedOrder);
                if (wasDeleted) {
                    this.ShipOSearchResults.SelectedItem = null;
                    this.ShipOSearchResults.SelectedIndex = -1;
                    this.ShipOSearchResults.Items.Remove(selectedOrder);
                }
            }

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }

    #endregion


    #region GESTION DES SUPPLIERS

    #endregion




    #region GESTION DES PURCHASEORDERS

    #endregion

    private void centerTableLayoutPanel_Paint(object sender, PaintEventArgs e) {

    }
}
