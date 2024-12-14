namespace _420DA3_A24_Projet.Presentation.Views;

partial class UserView {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        this.topBarPanel = new Panel();
        this.modeFenetreValue = new Label();
        this.modeFenetreLabel = new Label();
        this.bottomBarPanel = new Panel();
        this.btnAction = new Button();
        this.btnCancel = new Button();
        this.centerTblLayoutPanel = new TableLayoutPanel();
        this.centerPanel = new Panel();
        this.label1 = new Label();
        this.tableLayoutPanel1 = new TableLayoutPanel();
        this.userRolesValues = new ListBox();
        this.dateDeletedValue = new DateTimePicker();
        this.dateModifiedValue = new DateTimePicker();
        this.dateCreatedValue = new DateTimePicker();
        this.dateDeletedLabel = new Label();
        this.dateModifiedLabel = new Label();
        this.dateCreatedLabel = new Label();
        this.whEmployeeWarehouseValue = new ComboBox();
        this.whEmployeeWarehouseLabel = new Label();
        this.pwHashValue = new TextBox();
        this.pwHashLabel = new Label();
        this.passwordValue = new TextBox();
        this.passwordLabel = new Label();
        this.usernameValue = new TextBox();
        this.usernameLabel = new Label();
        this.idValue = new NumericUpDown();
        this.idLabel = new Label();
        this.topBarPanel.SuspendLayout();
        this.bottomBarPanel.SuspendLayout();
        this.centerTblLayoutPanel.SuspendLayout();
        this.centerPanel.SuspendLayout();
        this.tableLayoutPanel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) this.idValue).BeginInit();
        this.SuspendLayout();
        // 
        // topBarPanel
        // 
        this.topBarPanel.Controls.Add(this.modeFenetreValue);
        this.topBarPanel.Controls.Add(this.modeFenetreLabel);
        this.topBarPanel.Dock = DockStyle.Top;
        this.topBarPanel.Location = new Point(0, 0);
        this.topBarPanel.Margin = new Padding(4, 5, 4, 5);
        this.topBarPanel.Name = "topBarPanel";
        this.topBarPanel.Size = new Size(977, 83);
        this.topBarPanel.TabIndex = 0;
        // 
        // modeFenetreValue
        // 
        this.modeFenetreValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.modeFenetreValue.Location = new Point(147, 15);
        this.modeFenetreValue.Margin = new Padding(4, 0, 4, 0);
        this.modeFenetreValue.Name = "modeFenetreValue";
        this.modeFenetreValue.Size = new Size(274, 33);
        this.modeFenetreValue.TabIndex = 1;
        this.modeFenetreValue.Text = "PLACEHOLDER";
        this.modeFenetreValue.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // modeFenetreLabel
        // 
        this.modeFenetreLabel.Location = new Point(17, 15);
        this.modeFenetreLabel.Margin = new Padding(4, 0, 4, 0);
        this.modeFenetreLabel.Name = "modeFenetreLabel";
        this.modeFenetreLabel.Size = new Size(121, 33);
        this.modeFenetreLabel.TabIndex = 0;
        this.modeFenetreLabel.Text = "Mode fenêtre :";
        this.modeFenetreLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // bottomBarPanel
        // 
        this.bottomBarPanel.Controls.Add(this.btnAction);
        this.bottomBarPanel.Controls.Add(this.btnCancel);
        this.bottomBarPanel.Dock = DockStyle.Bottom;
        this.bottomBarPanel.Location = new Point(0, 824);
        this.bottomBarPanel.Margin = new Padding(4, 5, 4, 5);
        this.bottomBarPanel.Name = "bottomBarPanel";
        this.bottomBarPanel.Size = new Size(977, 83);
        this.bottomBarPanel.TabIndex = 1;
        // 
        // btnAction
        // 
        this.btnAction.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.btnAction.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.btnAction.Location = new Point(670, 25);
        this.btnAction.Margin = new Padding(4, 5, 4, 5);
        this.btnAction.Name = "btnAction";
        this.btnAction.Size = new Size(174, 38);
        this.btnAction.TabIndex = 1;
        this.btnAction.Text = "ACTION";
        this.btnAction.UseVisualStyleBackColor = true;
        this.btnAction.Click += this.BtnAction_Click;
        // 
        // btnCancel
        // 
        this.btnCancel.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.btnCancel.Location = new Point(853, 25);
        this.btnCancel.Margin = new Padding(4, 5, 4, 5);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new Size(107, 38);
        this.btnCancel.TabIndex = 0;
        this.btnCancel.Text = "Annuler";
        this.btnCancel.UseVisualStyleBackColor = true;
        this.btnCancel.Click += this.BtnCancel_Click;
        // 
        // centerTblLayoutPanel
        // 
        this.centerTblLayoutPanel.ColumnCount = 3;
        this.centerTblLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.centerTblLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 571F));
        this.centerTblLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.centerTblLayoutPanel.Controls.Add(this.centerPanel, 1, 0);
        this.centerTblLayoutPanel.Dock = DockStyle.Fill;
        this.centerTblLayoutPanel.Location = new Point(0, 83);
        this.centerTblLayoutPanel.Margin = new Padding(4, 5, 4, 5);
        this.centerTblLayoutPanel.Name = "centerTblLayoutPanel";
        this.centerTblLayoutPanel.RowCount = 1;
        this.centerTblLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.centerTblLayoutPanel.Size = new Size(977, 741);
        this.centerTblLayoutPanel.TabIndex = 2;
        // 
        // centerPanel
        // 
        this.centerPanel.Controls.Add(this.label1);
        this.centerPanel.Controls.Add(this.tableLayoutPanel1);
        this.centerPanel.Controls.Add(this.dateDeletedValue);
        this.centerPanel.Controls.Add(this.dateModifiedValue);
        this.centerPanel.Controls.Add(this.dateCreatedValue);
        this.centerPanel.Controls.Add(this.dateDeletedLabel);
        this.centerPanel.Controls.Add(this.dateModifiedLabel);
        this.centerPanel.Controls.Add(this.dateCreatedLabel);
        this.centerPanel.Controls.Add(this.whEmployeeWarehouseValue);
        this.centerPanel.Controls.Add(this.whEmployeeWarehouseLabel);
        this.centerPanel.Controls.Add(this.pwHashValue);
        this.centerPanel.Controls.Add(this.pwHashLabel);
        this.centerPanel.Controls.Add(this.passwordValue);
        this.centerPanel.Controls.Add(this.passwordLabel);
        this.centerPanel.Controls.Add(this.usernameValue);
        this.centerPanel.Controls.Add(this.usernameLabel);
        this.centerPanel.Controls.Add(this.idValue);
        this.centerPanel.Controls.Add(this.idLabel);
        this.centerPanel.Dock = DockStyle.Fill;
        this.centerPanel.Location = new Point(207, 5);
        this.centerPanel.Margin = new Padding(4, 5, 4, 5);
        this.centerPanel.Name = "centerPanel";
        this.centerPanel.Size = new Size(563, 731);
        this.centerPanel.TabIndex = 0;
        // 
        // label1
        // 
        this.label1.Location = new Point(71, 480);
        this.label1.Margin = new Padding(4, 17, 4, 0);
        this.label1.Name = "label1";
        this.label1.Size = new Size(420, 38);
        this.label1.TabIndex = 17;
        this.label1.Text = "Roles de l'utilisateur :";
        this.label1.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // tableLayoutPanel1
        // 
        this.tableLayoutPanel1.ColumnCount = 3;
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 429F));
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel1.Controls.Add(this.userRolesValues, 1, 0);
        this.tableLayoutPanel1.Location = new Point(4, 518);
        this.tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        this.tableLayoutPanel1.RowCount = 1;
        this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.tableLayoutPanel1.Size = new Size(554, 240);
        this.tableLayoutPanel1.TabIndex = 16;
        // 
        // userRolesValues
        // 
        this.userRolesValues.Dock = DockStyle.Fill;
        this.userRolesValues.FormattingEnabled = true;
        this.userRolesValues.ItemHeight = 25;
        this.userRolesValues.Location = new Point(66, 5);
        this.userRolesValues.Margin = new Padding(4, 5, 4, 5);
        this.userRolesValues.Name = "userRolesValues";
        this.userRolesValues.Size = new Size(421, 230);
        this.userRolesValues.TabIndex = 0;
        // 
        // dateDeletedValue
        // 
        this.dateDeletedValue.Enabled = false;
        this.dateDeletedValue.Location = new Point(270, 412);
        this.dateDeletedValue.Margin = new Padding(4, 5, 4, 5);
        this.dateDeletedValue.Name = "dateDeletedValue";
        this.dateDeletedValue.Size = new Size(287, 31);
        this.dateDeletedValue.TabIndex = 15;
        // 
        // dateModifiedValue
        // 
        this.dateModifiedValue.Enabled = false;
        this.dateModifiedValue.Location = new Point(270, 357);
        this.dateModifiedValue.Margin = new Padding(4, 5, 4, 5);
        this.dateModifiedValue.Name = "dateModifiedValue";
        this.dateModifiedValue.Size = new Size(287, 31);
        this.dateModifiedValue.TabIndex = 14;
        // 
        // dateCreatedValue
        // 
        this.dateCreatedValue.Enabled = false;
        this.dateCreatedValue.Location = new Point(270, 302);
        this.dateCreatedValue.Margin = new Padding(4, 5, 4, 5);
        this.dateCreatedValue.Name = "dateCreatedValue";
        this.dateCreatedValue.Size = new Size(287, 31);
        this.dateCreatedValue.TabIndex = 13;
        // 
        // dateDeletedLabel
        // 
        this.dateDeletedLabel.Location = new Point(4, 412);
        this.dateDeletedLabel.Margin = new Padding(4, 17, 4, 0);
        this.dateDeletedLabel.Name = "dateDeletedLabel";
        this.dateDeletedLabel.Size = new Size(257, 38);
        this.dateDeletedLabel.TabIndex = 12;
        this.dateDeletedLabel.Text = "Date de suppression :";
        this.dateDeletedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateModifiedLabel
        // 
        this.dateModifiedLabel.Location = new Point(4, 357);
        this.dateModifiedLabel.Margin = new Padding(4, 17, 4, 0);
        this.dateModifiedLabel.Name = "dateModifiedLabel";
        this.dateModifiedLabel.Size = new Size(257, 38);
        this.dateModifiedLabel.TabIndex = 11;
        this.dateModifiedLabel.Text = "Date de dernière modification :";
        this.dateModifiedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateCreatedLabel
        // 
        this.dateCreatedLabel.Location = new Point(4, 302);
        this.dateCreatedLabel.Margin = new Padding(4, 17, 4, 0);
        this.dateCreatedLabel.Name = "dateCreatedLabel";
        this.dateCreatedLabel.Size = new Size(257, 38);
        this.dateCreatedLabel.TabIndex = 10;
        this.dateCreatedLabel.Text = "Date de création :";
        this.dateCreatedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // whEmployeeWarehouseValue
        // 
        this.whEmployeeWarehouseValue.FormattingEnabled = true;
        this.whEmployeeWarehouseValue.Location = new Point(270, 248);
        this.whEmployeeWarehouseValue.Margin = new Padding(4, 5, 4, 5);
        this.whEmployeeWarehouseValue.Name = "whEmployeeWarehouseValue";
        this.whEmployeeWarehouseValue.Size = new Size(287, 33);
        this.whEmployeeWarehouseValue.TabIndex = 9;
        // 
        // whEmployeeWarehouseLabel
        // 
        this.whEmployeeWarehouseLabel.Location = new Point(4, 247);
        this.whEmployeeWarehouseLabel.Margin = new Padding(4, 17, 4, 0);
        this.whEmployeeWarehouseLabel.Name = "whEmployeeWarehouseLabel";
        this.whEmployeeWarehouseLabel.Size = new Size(257, 38);
        this.whEmployeeWarehouseLabel.TabIndex = 8;
        this.whEmployeeWarehouseLabel.Text = "Entrepot de travail :";
        this.whEmployeeWarehouseLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // pwHashValue
        // 
        this.pwHashValue.Enabled = false;
        this.pwHashValue.Location = new Point(270, 193);
        this.pwHashValue.Margin = new Padding(4, 5, 4, 5);
        this.pwHashValue.Name = "pwHashValue";
        this.pwHashValue.Size = new Size(287, 31);
        this.pwHashValue.TabIndex = 7;
        // 
        // pwHashLabel
        // 
        this.pwHashLabel.Location = new Point(4, 192);
        this.pwHashLabel.Margin = new Padding(4, 17, 4, 0);
        this.pwHashLabel.Name = "pwHashLabel";
        this.pwHashLabel.Size = new Size(257, 38);
        this.pwHashLabel.TabIndex = 6;
        this.pwHashLabel.Text = "Password hash :";
        this.pwHashLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // passwordValue
        // 
        this.passwordValue.Location = new Point(270, 138);
        this.passwordValue.Margin = new Padding(4, 5, 4, 5);
        this.passwordValue.Name = "passwordValue";
        this.passwordValue.PlaceholderText = "Mot de passe";
        this.passwordValue.Size = new Size(287, 31);
        this.passwordValue.TabIndex = 5;
        this.passwordValue.UseSystemPasswordChar = true;
        // 
        // passwordLabel
        // 
        this.passwordLabel.Location = new Point(4, 137);
        this.passwordLabel.Margin = new Padding(4, 17, 4, 0);
        this.passwordLabel.Name = "passwordLabel";
        this.passwordLabel.Size = new Size(257, 38);
        this.passwordLabel.TabIndex = 4;
        this.passwordLabel.Text = "Password :";
        this.passwordLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // usernameValue
        // 
        this.usernameValue.Location = new Point(270, 83);
        this.usernameValue.Margin = new Padding(4, 5, 4, 5);
        this.usernameValue.Name = "usernameValue";
        this.usernameValue.PlaceholderText = "Nom d'utilisateur";
        this.usernameValue.Size = new Size(287, 31);
        this.usernameValue.TabIndex = 3;
        // 
        // usernameLabel
        // 
        this.usernameLabel.Location = new Point(4, 82);
        this.usernameLabel.Margin = new Padding(4, 17, 4, 0);
        this.usernameLabel.Name = "usernameLabel";
        this.usernameLabel.Size = new Size(257, 38);
        this.usernameLabel.TabIndex = 2;
        this.usernameLabel.Text = "Nom d'utilisateur :";
        this.usernameLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // idValue
        // 
        this.idValue.Enabled = false;
        this.idValue.Location = new Point(270, 30);
        this.idValue.Margin = new Padding(4, 5, 4, 5);
        this.idValue.Maximum = new decimal(new int[] { -1539607552, 11, 0, 0 });
        this.idValue.Name = "idValue";
        this.idValue.Size = new Size(289, 31);
        this.idValue.TabIndex = 1;
        // 
        // idLabel
        // 
        this.idLabel.Location = new Point(4, 27);
        this.idLabel.Margin = new Padding(4, 0, 4, 0);
        this.idLabel.Name = "idLabel";
        this.idLabel.Size = new Size(257, 38);
        this.idLabel.TabIndex = 0;
        this.idLabel.Text = "ID :";
        this.idLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // UserView
        // 
        this.AutoScaleDimensions = new SizeF(10F, 25F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(977, 907);
        this.Controls.Add(this.centerTblLayoutPanel);
        this.Controls.Add(this.bottomBarPanel);
        this.Controls.Add(this.topBarPanel);
        this.Margin = new Padding(4, 5, 4, 5);
        this.MinimumSize = new Size(705, 963);
        this.Name = "UserView";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Gestion des utilisateurs";
        this.topBarPanel.ResumeLayout(false);
        this.bottomBarPanel.ResumeLayout(false);
        this.centerTblLayoutPanel.ResumeLayout(false);
        this.centerPanel.ResumeLayout(false);
        this.centerPanel.PerformLayout();
        this.tableLayoutPanel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize) this.idValue).EndInit();
        this.ResumeLayout(false);
    }

    #endregion

    private Panel topBarPanel;
    private Panel bottomBarPanel;
    private TableLayoutPanel centerTblLayoutPanel;
    private Button btnAction;
    private Button btnCancel;
    private Panel centerPanel;
    private TextBox passwordValue;
    private Label passwordLabel;
    private TextBox usernameValue;
    private Label usernameLabel;
    private NumericUpDown idValue;
    private Label idLabel;
    private Label whEmployeeWarehouseLabel;
    private TextBox pwHashValue;
    private Label pwHashLabel;
    private DateTimePicker dateDeletedValue;
    private DateTimePicker dateModifiedValue;
    private DateTimePicker dateCreatedValue;
    private Label dateDeletedLabel;
    private Label dateModifiedLabel;
    private Label dateCreatedLabel;
    private ComboBox whEmployeeWarehouseValue;
    private Label label1;
    private TableLayoutPanel tableLayoutPanel1;
    private ListBox userRolesValues;
    private Label modeFenetreValue;
    private Label modeFenetreLabel;
}