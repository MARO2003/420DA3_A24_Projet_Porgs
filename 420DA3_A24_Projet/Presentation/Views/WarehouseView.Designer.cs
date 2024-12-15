namespace _420DA3_A24_Projet.Presentation.Views;

partial class WarehouseView {
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
        this.panel1 = new Panel();
        this.panel2 = new Panel();
        this.panel3 = new Panel();
        this.tableLayoutPanel1 = new TableLayoutPanel();
        this.panel4 = new Panel();
        this.dateDeletedValue = new DateTimePicker();
        this.dateModifiedValue = new DateTimePicker();
        this.dateCreatedValue = new DateTimePicker();
        this.dateDeletedLabel = new Label();
        this.dateModifiedLabel = new Label();
        this.dateCreatedLabel = new Label();
        this.CreerAdressebtn = new Button();
        this.descriptionLabel = new Label();
        this.nameValue = new TextBox();
        this.nameLabel = new Label();
        this.idValue = new NumericUpDown();
        this.idLabel = new Label();
        this.panel5 = new Panel();
        this.ClientsValues = new ListBox();
        this.ClientsLbl = new Label();
        this.WarehouseEmployeesValues = new ListBox();
        this.label1 = new Label();
        this.RestockOrdersValues = new ListBox();
        this.label2 = new Label();
        this.AdressValue = new TextBox();
        this.openendModeValue = new Label();
        this.openedModeLabel = new Label();
        this.btnAction = new Button();
        this.btnCancel = new Button();
        this.panel1.SuspendLayout();
        this.panel2.SuspendLayout();
        this.panel3.SuspendLayout();
        this.tableLayoutPanel1.SuspendLayout();
        this.panel4.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) this.idValue).BeginInit();
        this.panel5.SuspendLayout();
        this.SuspendLayout();
        // 
        // panel1
        // 
        this.panel1.Controls.Add(this.panel2);
        this.panel1.Dock = DockStyle.Top;
        this.panel1.Location = new Point(0, 0);
        this.panel1.Name = "panel1";
        this.panel1.Size = new Size(1052, 56);
        this.panel1.TabIndex = 0;
        // 
        // panel2
        // 
        this.panel2.Controls.Add(this.openendModeValue);
        this.panel2.Controls.Add(this.openedModeLabel);
        this.panel2.Dock = DockStyle.Top;
        this.panel2.Location = new Point(0, 0);
        this.panel2.Name = "panel2";
        this.panel2.Size = new Size(1052, 56);
        this.panel2.TabIndex = 1;
        // 
        // panel3
        // 
        this.panel3.Controls.Add(this.btnAction);
        this.panel3.Controls.Add(this.btnCancel);
        this.panel3.Dock = DockStyle.Bottom;
        this.panel3.Location = new Point(0, 514);
        this.panel3.Name = "panel3";
        this.panel3.Size = new Size(1052, 56);
        this.panel3.TabIndex = 1;
        // 
        // tableLayoutPanel1
        // 
        this.tableLayoutPanel1.ColumnCount = 4;
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 500F));
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 500F));
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 0);
        this.tableLayoutPanel1.Controls.Add(this.panel5, 2, 0);
        this.tableLayoutPanel1.Dock = DockStyle.Fill;
        this.tableLayoutPanel1.Location = new Point(0, 56);
        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        this.tableLayoutPanel1.RowCount = 1;
        this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        this.tableLayoutPanel1.Size = new Size(1052, 458);
        this.tableLayoutPanel1.TabIndex = 2;
        this.tableLayoutPanel1.Paint += this.tableLayoutPanel1_Paint;
        // 
        // panel4
        // 
        this.panel4.Controls.Add(this.AdressValue);
        this.panel4.Controls.Add(this.dateDeletedValue);
        this.panel4.Controls.Add(this.dateModifiedValue);
        this.panel4.Controls.Add(this.dateCreatedValue);
        this.panel4.Controls.Add(this.dateDeletedLabel);
        this.panel4.Controls.Add(this.dateModifiedLabel);
        this.panel4.Controls.Add(this.dateCreatedLabel);
        this.panel4.Controls.Add(this.CreerAdressebtn);
        this.panel4.Controls.Add(this.descriptionLabel);
        this.panel4.Controls.Add(this.nameValue);
        this.panel4.Controls.Add(this.nameLabel);
        this.panel4.Controls.Add(this.idValue);
        this.panel4.Controls.Add(this.idLabel);
        this.panel4.Dock = DockStyle.Fill;
        this.panel4.Location = new Point(29, 3);
        this.panel4.Name = "panel4";
        this.panel4.Size = new Size(494, 452);
        this.panel4.TabIndex = 0;
        this.panel4.Paint += this.panel4_Paint;
        // 
        // dateDeletedValue
        // 
        this.dateDeletedValue.Enabled = false;
        this.dateDeletedValue.Location = new Point(194, 326);
        this.dateDeletedValue.Margin = new Padding(4, 5, 4, 5);
        this.dateDeletedValue.Name = "dateDeletedValue";
        this.dateDeletedValue.Size = new Size(296, 31);
        this.dateDeletedValue.TabIndex = 21;
        // 
        // dateModifiedValue
        // 
        this.dateModifiedValue.Enabled = false;
        this.dateModifiedValue.Location = new Point(194, 271);
        this.dateModifiedValue.Margin = new Padding(4, 5, 4, 5);
        this.dateModifiedValue.Name = "dateModifiedValue";
        this.dateModifiedValue.Size = new Size(300, 31);
        this.dateModifiedValue.TabIndex = 20;
        // 
        // dateCreatedValue
        // 
        this.dateCreatedValue.Enabled = false;
        this.dateCreatedValue.Location = new Point(194, 216);
        this.dateCreatedValue.Margin = new Padding(4, 5, 4, 5);
        this.dateCreatedValue.Name = "dateCreatedValue";
        this.dateCreatedValue.Size = new Size(296, 31);
        this.dateCreatedValue.TabIndex = 19;
        // 
        // dateDeletedLabel
        // 
        this.dateDeletedLabel.Location = new Point(4, 326);
        this.dateDeletedLabel.Margin = new Padding(8, 9, 8, 9);
        this.dateDeletedLabel.Name = "dateDeletedLabel";
        this.dateDeletedLabel.Size = new Size(180, 39);
        this.dateDeletedLabel.TabIndex = 18;
        this.dateDeletedLabel.Text = "Date de suppression :";
        this.dateDeletedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateModifiedLabel
        // 
        this.dateModifiedLabel.Location = new Point(8, 271);
        this.dateModifiedLabel.Margin = new Padding(8, 9, 8, 9);
        this.dateModifiedLabel.Name = "dateModifiedLabel";
        this.dateModifiedLabel.Size = new Size(176, 39);
        this.dateModifiedLabel.TabIndex = 17;
        this.dateModifiedLabel.Text = "Date de modification :";
        this.dateModifiedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateCreatedLabel
        // 
        this.dateCreatedLabel.Location = new Point(8, 216);
        this.dateCreatedLabel.Margin = new Padding(8, 9, 8, 9);
        this.dateCreatedLabel.Name = "dateCreatedLabel";
        this.dateCreatedLabel.Size = new Size(176, 39);
        this.dateCreatedLabel.TabIndex = 16;
        this.dateCreatedLabel.Text = "Date de création :";
        this.dateCreatedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // CreerAdressebtn
        // 
        this.CreerAdressebtn.Location = new Point(238, 115);
        this.CreerAdressebtn.Name = "CreerAdressebtn";
        this.CreerAdressebtn.Size = new Size(112, 34);
        this.CreerAdressebtn.TabIndex = 12;
        this.CreerAdressebtn.Text = "Creer";
        this.CreerAdressebtn.UseVisualStyleBackColor = true;
        // 
        // descriptionLabel
        // 
        this.descriptionLabel.Location = new Point(4, 113);
        this.descriptionLabel.Margin = new Padding(4, 5, 4, 5);
        this.descriptionLabel.Name = "descriptionLabel";
        this.descriptionLabel.Size = new Size(236, 39);
        this.descriptionLabel.TabIndex = 10;
        this.descriptionLabel.Text = "Adresse:";
        this.descriptionLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // nameValue
        // 
        this.nameValue.Location = new Point(248, 67);
        this.nameValue.Margin = new Padding(4, 5, 4, 5);
        this.nameValue.Name = "nameValue";
        this.nameValue.PlaceholderText = "warehouse name";
        this.nameValue.Size = new Size(242, 31);
        this.nameValue.TabIndex = 9;
        // 
        // nameLabel
        // 
        this.nameLabel.Location = new Point(0, 66);
        this.nameLabel.Margin = new Padding(4, 5, 4, 5);
        this.nameLabel.Name = "nameLabel";
        this.nameLabel.Size = new Size(240, 39);
        this.nameLabel.TabIndex = 8;
        this.nameLabel.Text = "Name :";
        this.nameLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // idValue
        // 
        this.idValue.Enabled = false;
        this.idValue.Location = new Point(248, 21);
        this.idValue.Margin = new Padding(4, 5, 4, 5);
        this.idValue.Maximum = new decimal(new int[] { -1294967296, 0, 0, 0 });
        this.idValue.Name = "idValue";
        this.idValue.Size = new Size(246, 31);
        this.idValue.TabIndex = 7;
        // 
        // idLabel
        // 
        this.idLabel.Location = new Point(0, 17);
        this.idLabel.Margin = new Padding(4, 5, 4, 5);
        this.idLabel.Name = "idLabel";
        this.idLabel.Size = new Size(240, 39);
        this.idLabel.TabIndex = 6;
        this.idLabel.Text = "Id :";
        this.idLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // panel5
        // 
        this.panel5.Controls.Add(this.RestockOrdersValues);
        this.panel5.Controls.Add(this.label2);
        this.panel5.Controls.Add(this.WarehouseEmployeesValues);
        this.panel5.Controls.Add(this.label1);
        this.panel5.Controls.Add(this.ClientsValues);
        this.panel5.Controls.Add(this.ClientsLbl);
        this.panel5.Dock = DockStyle.Fill;
        this.panel5.Location = new Point(529, 3);
        this.panel5.Name = "panel5";
        this.panel5.Size = new Size(494, 452);
        this.panel5.TabIndex = 1;
        // 
        // ClientsValues
        // 
        this.ClientsValues.FormattingEnabled = true;
        this.ClientsValues.ItemHeight = 25;
        this.ClientsValues.Location = new Point(17, 35);
        this.ClientsValues.Margin = new Padding(4, 5, 4, 5);
        this.ClientsValues.Name = "ClientsValues";
        this.ClientsValues.SelectionMode = SelectionMode.MultiSimple;
        this.ClientsValues.Size = new Size(285, 104);
        this.ClientsValues.TabIndex = 19;
        // 
        // ClientsLbl
        // 
        this.ClientsLbl.Location = new Point(8, -3);
        this.ClientsLbl.Margin = new Padding(8, 9, 8, 9);
        this.ClientsLbl.Name = "ClientsLbl";
        this.ClientsLbl.Size = new Size(206, 39);
        this.ClientsLbl.TabIndex = 18;
        this.ClientsLbl.Text = "Clients";
        this.ClientsLbl.TextAlign = ContentAlignment.MiddleRight;
        this.ClientsLbl.Click += this.userRolesLabel_Click;
        // 
        // WarehouseEmployeesValues
        // 
        this.WarehouseEmployeesValues.FormattingEnabled = true;
        this.WarehouseEmployeesValues.ItemHeight = 25;
        this.WarehouseEmployeesValues.Location = new Point(17, 182);
        this.WarehouseEmployeesValues.Margin = new Padding(4, 5, 4, 5);
        this.WarehouseEmployeesValues.Name = "WarehouseEmployeesValues";
        this.WarehouseEmployeesValues.SelectionMode = SelectionMode.MultiSimple;
        this.WarehouseEmployeesValues.Size = new Size(285, 104);
        this.WarehouseEmployeesValues.TabIndex = 21;
        // 
        // label1
        // 
        this.label1.Location = new Point(8, 144);
        this.label1.Margin = new Padding(8, 9, 8, 9);
        this.label1.Name = "label1";
        this.label1.Size = new Size(206, 39);
        this.label1.TabIndex = 20;
        this.label1.Text = "Employes";
        this.label1.TextAlign = ContentAlignment.MiddleRight;
        // 
        // RestockOrdersValues
        // 
        this.RestockOrdersValues.FormattingEnabled = true;
        this.RestockOrdersValues.ItemHeight = 25;
        this.RestockOrdersValues.Location = new Point(17, 338);
        this.RestockOrdersValues.Margin = new Padding(4, 5, 4, 5);
        this.RestockOrdersValues.Name = "RestockOrdersValues";
        this.RestockOrdersValues.SelectionMode = SelectionMode.MultiSimple;
        this.RestockOrdersValues.Size = new Size(285, 104);
        this.RestockOrdersValues.TabIndex = 23;
        // 
        // label2
        // 
        this.label2.Location = new Point(8, 300);
        this.label2.Margin = new Padding(8, 9, 8, 9);
        this.label2.Name = "label2";
        this.label2.Size = new Size(206, 39);
        this.label2.TabIndex = 22;
        this.label2.Text = "Ordres de restockage";
        this.label2.TextAlign = ContentAlignment.MiddleRight;
        // 
        // AdressValue
        // 
        this.AdressValue.Location = new Point(238, 160);
        this.AdressValue.Name = "AdressValue";
        this.AdressValue.Size = new Size(252, 31);
        this.AdressValue.TabIndex = 22;
        // 
        // openendModeValue
        // 
        this.openendModeValue.AutoSize = true;
        this.openendModeValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.openendModeValue.Location = new Point(85, 9);
        this.openendModeValue.Margin = new Padding(4, 0, 4, 0);
        this.openendModeValue.Name = "openendModeValue";
        this.openendModeValue.Size = new Size(112, 25);
        this.openendModeValue.TabIndex = 3;
        this.openendModeValue.Text = "Placeholder";
        // 
        // openedModeLabel
        // 
        this.openedModeLabel.AutoSize = true;
        this.openedModeLabel.Location = new Point(13, 9);
        this.openedModeLabel.Margin = new Padding(4, 0, 4, 0);
        this.openedModeLabel.Name = "openedModeLabel";
        this.openedModeLabel.Size = new Size(68, 25);
        this.openedModeLabel.TabIndex = 2;
        this.openedModeLabel.Text = "Mode :";
        // 
        // btnAction
        // 
        this.btnAction.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.btnAction.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.btnAction.Location = new Point(744, 8);
        this.btnAction.Margin = new Padding(4, 5, 4, 5);
        this.btnAction.Name = "btnAction";
        this.btnAction.Size = new Size(162, 39);
        this.btnAction.TabIndex = 3;
        this.btnAction.Text = "ACTION";
        this.btnAction.UseVisualStyleBackColor = true;
        // 
        // btnCancel
        // 
        this.btnCancel.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.btnCancel.Location = new Point(915, 8);
        this.btnCancel.Margin = new Padding(4, 5, 4, 5);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new Size(108, 39);
        this.btnCancel.TabIndex = 2;
        this.btnCancel.Text = "Annuler";
        this.btnCancel.UseVisualStyleBackColor = true;
        // 
        // WarehouseView
        // 
        this.AutoScaleDimensions = new SizeF(10F, 25F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(1052, 570);
        this.Controls.Add(this.tableLayoutPanel1);
        this.Controls.Add(this.panel3);
        this.Controls.Add(this.panel1);
        this.Name = "WarehouseView";
        this.Text = "WarehouseView";
        this.panel1.ResumeLayout(false);
        this.panel2.ResumeLayout(false);
        this.panel2.PerformLayout();
        this.panel3.ResumeLayout(false);
        this.tableLayoutPanel1.ResumeLayout(false);
        this.panel4.ResumeLayout(false);
        this.panel4.PerformLayout();
        ((System.ComponentModel.ISupportInitialize) this.idValue).EndInit();
        this.panel5.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Panel panel2;
    private Panel panel3;
    private TableLayoutPanel tableLayoutPanel1;
    private Panel panel4;
    private Label descriptionLabel;
    private TextBox nameValue;
    private Label nameLabel;
    private NumericUpDown idValue;
    private Label idLabel;
    private Button CreerAdressebtn;
    private DateTimePicker dateDeletedValue;
    private DateTimePicker dateModifiedValue;
    private DateTimePicker dateCreatedValue;
    private Label dateDeletedLabel;
    private Label dateModifiedLabel;
    private Label dateCreatedLabel;
    private Panel panel5;
    private ListBox ClientsValues;
    private Label ClientsLbl;
    private ListBox RestockOrdersValues;
    private Label label2;
    private ListBox WarehouseEmployeesValues;
    private Label label1;
    private TextBox AdressValue;
    private Label openendModeValue;
    private Label openedModeLabel;
    private Button btnAction;
    private Button btnCancel;
}