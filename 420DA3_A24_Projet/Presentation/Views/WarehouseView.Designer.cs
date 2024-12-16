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
        this.openendModeValue = new Label();
        this.openedModeLabel = new Label();
        this.panel3 = new Panel();
        this.btnAction = new Button();
        this.btnCancel = new Button();
        this.tableLayoutPanel1 = new TableLayoutPanel();
        this.panel4 = new Panel();
        this.AdressValue = new TextBox();
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
        this.panel1.SuspendLayout();
        this.panel2.SuspendLayout();
        this.panel3.SuspendLayout();
        this.tableLayoutPanel1.SuspendLayout();
        this.panel4.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) this.idValue).BeginInit();
        this.SuspendLayout();
        // 
        // panel1
        // 
        this.panel1.Controls.Add(this.panel2);
        this.panel1.Dock = DockStyle.Top;
        this.panel1.Location = new Point(0, 0);
        this.panel1.Name = "panel1";
        this.panel1.Size = new Size(642, 56);
        this.panel1.TabIndex = 0;
        // 
        // panel2
        // 
        this.panel2.Controls.Add(this.openendModeValue);
        this.panel2.Controls.Add(this.openedModeLabel);
        this.panel2.Dock = DockStyle.Top;
        this.panel2.Location = new Point(0, 0);
        this.panel2.Name = "panel2";
        this.panel2.Size = new Size(642, 56);
        this.panel2.TabIndex = 1;
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
        // panel3
        // 
        this.panel3.Controls.Add(this.btnAction);
        this.panel3.Controls.Add(this.btnCancel);
        this.panel3.Dock = DockStyle.Bottom;
        this.panel3.Location = new Point(0, 471);
        this.panel3.Name = "panel3";
        this.panel3.Size = new Size(642, 56);
        this.panel3.TabIndex = 1;
        // 
        // btnAction
        // 
        this.btnAction.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.btnAction.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.btnAction.Location = new Point(334, 8);
        this.btnAction.Margin = new Padding(4, 5, 4, 5);
        this.btnAction.Name = "btnAction";
        this.btnAction.Size = new Size(162, 39);
        this.btnAction.TabIndex = 3;
        this.btnAction.Text = "ACTION";
        this.btnAction.UseVisualStyleBackColor = true;
        this.btnAction.Click += this.btnAction_Click;
        // 
        // btnCancel
        // 
        this.btnCancel.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.btnCancel.Location = new Point(505, 8);
        this.btnCancel.Margin = new Padding(4, 5, 4, 5);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new Size(108, 39);
        this.btnCancel.TabIndex = 2;
        this.btnCancel.Text = "Annuler";
        this.btnCancel.UseVisualStyleBackColor = true;
        // 
        // tableLayoutPanel1
        // 
        this.tableLayoutPanel1.ColumnCount = 3;
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 500F));
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 0);
        this.tableLayoutPanel1.Dock = DockStyle.Fill;
        this.tableLayoutPanel1.Location = new Point(0, 56);
        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        this.tableLayoutPanel1.RowCount = 1;
        this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        this.tableLayoutPanel1.Size = new Size(642, 415);
        this.tableLayoutPanel1.TabIndex = 2;
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
        this.panel4.Location = new Point(74, 3);
        this.panel4.Name = "panel4";
        this.panel4.Size = new Size(494, 409);
        this.panel4.TabIndex = 0;
        // 
        // AdressValue
        // 
        this.AdressValue.Location = new Point(238, 173);
        this.AdressValue.Name = "AdressValue";
        this.AdressValue.Size = new Size(252, 31);
        this.AdressValue.TabIndex = 35;
        // 
        // dateDeletedValue
        // 
        this.dateDeletedValue.Enabled = false;
        this.dateDeletedValue.Location = new Point(194, 339);
        this.dateDeletedValue.Margin = new Padding(4, 5, 4, 5);
        this.dateDeletedValue.Name = "dateDeletedValue";
        this.dateDeletedValue.Size = new Size(296, 31);
        this.dateDeletedValue.TabIndex = 34;
        // 
        // dateModifiedValue
        // 
        this.dateModifiedValue.Enabled = false;
        this.dateModifiedValue.Location = new Point(194, 284);
        this.dateModifiedValue.Margin = new Padding(4, 5, 4, 5);
        this.dateModifiedValue.Name = "dateModifiedValue";
        this.dateModifiedValue.Size = new Size(300, 31);
        this.dateModifiedValue.TabIndex = 33;
        // 
        // dateCreatedValue
        // 
        this.dateCreatedValue.Enabled = false;
        this.dateCreatedValue.Location = new Point(194, 229);
        this.dateCreatedValue.Margin = new Padding(4, 5, 4, 5);
        this.dateCreatedValue.Name = "dateCreatedValue";
        this.dateCreatedValue.Size = new Size(296, 31);
        this.dateCreatedValue.TabIndex = 32;
        // 
        // dateDeletedLabel
        // 
        this.dateDeletedLabel.Location = new Point(4, 339);
        this.dateDeletedLabel.Margin = new Padding(8, 9, 8, 9);
        this.dateDeletedLabel.Name = "dateDeletedLabel";
        this.dateDeletedLabel.Size = new Size(180, 39);
        this.dateDeletedLabel.TabIndex = 31;
        this.dateDeletedLabel.Text = "Date de suppression :";
        this.dateDeletedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateModifiedLabel
        // 
        this.dateModifiedLabel.Location = new Point(8, 284);
        this.dateModifiedLabel.Margin = new Padding(8, 9, 8, 9);
        this.dateModifiedLabel.Name = "dateModifiedLabel";
        this.dateModifiedLabel.Size = new Size(176, 39);
        this.dateModifiedLabel.TabIndex = 30;
        this.dateModifiedLabel.Text = "Date de modification :";
        this.dateModifiedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateCreatedLabel
        // 
        this.dateCreatedLabel.Location = new Point(8, 229);
        this.dateCreatedLabel.Margin = new Padding(8, 9, 8, 9);
        this.dateCreatedLabel.Name = "dateCreatedLabel";
        this.dateCreatedLabel.Size = new Size(176, 39);
        this.dateCreatedLabel.TabIndex = 29;
        this.dateCreatedLabel.Text = "Date de création :";
        this.dateCreatedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // CreerAdressebtn
        // 
        this.CreerAdressebtn.Location = new Point(238, 128);
        this.CreerAdressebtn.Name = "CreerAdressebtn";
        this.CreerAdressebtn.Size = new Size(112, 34);
        this.CreerAdressebtn.TabIndex = 28;
        this.CreerAdressebtn.Text = "Creer";
        this.CreerAdressebtn.UseVisualStyleBackColor = true;
        // 
        // descriptionLabel
        // 
        this.descriptionLabel.Location = new Point(4, 126);
        this.descriptionLabel.Margin = new Padding(4, 5, 4, 5);
        this.descriptionLabel.Name = "descriptionLabel";
        this.descriptionLabel.Size = new Size(236, 39);
        this.descriptionLabel.TabIndex = 27;
        this.descriptionLabel.Text = "Adresse:";
        this.descriptionLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // nameValue
        // 
        this.nameValue.Location = new Point(248, 80);
        this.nameValue.Margin = new Padding(4, 5, 4, 5);
        this.nameValue.Name = "nameValue";
        this.nameValue.PlaceholderText = "warehouse name";
        this.nameValue.Size = new Size(242, 31);
        this.nameValue.TabIndex = 26;
        // 
        // nameLabel
        // 
        this.nameLabel.Location = new Point(0, 79);
        this.nameLabel.Margin = new Padding(4, 5, 4, 5);
        this.nameLabel.Name = "nameLabel";
        this.nameLabel.Size = new Size(240, 39);
        this.nameLabel.TabIndex = 25;
        this.nameLabel.Text = "Name :";
        this.nameLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // idValue
        // 
        this.idValue.Enabled = false;
        this.idValue.Location = new Point(248, 34);
        this.idValue.Margin = new Padding(4, 5, 4, 5);
        this.idValue.Maximum = new decimal(new int[] { -1294967296, 0, 0, 0 });
        this.idValue.Name = "idValue";
        this.idValue.Size = new Size(246, 31);
        this.idValue.TabIndex = 24;
        // 
        // idLabel
        // 
        this.idLabel.Location = new Point(0, 30);
        this.idLabel.Margin = new Padding(4, 5, 4, 5);
        this.idLabel.Name = "idLabel";
        this.idLabel.Size = new Size(240, 39);
        this.idLabel.TabIndex = 23;
        this.idLabel.Text = "Id :";
        this.idLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // WarehouseView
        // 
        this.AutoScaleDimensions = new SizeF(10F, 25F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(642, 527);
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
        this.ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Panel panel2;
    private Panel panel3;
    private Label openendModeValue;
    private Label openedModeLabel;
    private Button btnAction;
    private Button btnCancel;
    private TableLayoutPanel tableLayoutPanel1;
    private Panel panel4;
    private TextBox AdressValue;
    private DateTimePicker dateDeletedValue;
    private DateTimePicker dateModifiedValue;
    private DateTimePicker dateCreatedValue;
    private Label dateDeletedLabel;
    private Label dateModifiedLabel;
    private Label dateCreatedLabel;
    private Button CreerAdressebtn;
    private Label descriptionLabel;
    private TextBox nameValue;
    private Label nameLabel;
    private NumericUpDown idValue;
    private Label idLabel;
}