namespace _420DA3_A24_Projet.Presentation.Views;

partial class SupplierView {
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
        this.openendModeValue = new Label();
        this.openedModeLabel = new Label();
        this.bottomBarPanel = new Panel();
        this.ActionBtn = new Button();
        this.cancelBtn = new Button();
        this.centerTLP = new TableLayoutPanel();
        this.centerPanel = new Panel();
        this.ProductsValue = new ListBox();
        this.dateDeletedValue = new DateTimePicker();
        this.dateModifiedValue = new DateTimePicker();
        this.dateCreatedValue = new DateTimePicker();
        this.contactTelephoneValue = new TextBox();
        this.contactEmailValue = new TextBox();
        this.contactFirstNameValue = new TextBox();
        this.contactLastNameValue = new TextBox();
        this.supplierNameValue = new TextBox();
        this.idValue = new NumericUpDown();
        this.label1 = new Label();
        this.dateDeletedLabel = new Label();
        this.dateModifiedLabel = new Label();
        this.dateCreatedLabel = new Label();
        this.contactTelephoneLabel = new Label();
        this.contactEmailLabel = new Label();
        this.contactFirstNameLabel = new Label();
        this.contactLastNameLabel = new Label();
        this.supplierNameLabel = new Label();
        this.idLabel = new Label();
        this.topBarPanel.SuspendLayout();
        this.bottomBarPanel.SuspendLayout();
        this.centerTLP.SuspendLayout();
        this.centerPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) this.idValue).BeginInit();
        this.SuspendLayout();
        // 
        // topBarPanel
        // 
        this.topBarPanel.Controls.Add(this.openendModeValue);
        this.topBarPanel.Controls.Add(this.openedModeLabel);
        this.topBarPanel.Dock = DockStyle.Top;
        this.topBarPanel.Location = new Point(0, 0);
        this.topBarPanel.Name = "topBarPanel";
        this.topBarPanel.Size = new Size(802, 50);
        this.topBarPanel.TabIndex = 0;
        this.topBarPanel.Paint += this.topBarPanel_Paint;
        // 
        // openendModeValue
        // 
        this.openendModeValue.AutoSize = true;
        this.openendModeValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.openendModeValue.Location = new Point(104, 9);
        this.openendModeValue.Name = "openendModeValue";
        this.openendModeValue.Size = new Size(90, 20);
        this.openendModeValue.TabIndex = 5;
        this.openendModeValue.Text = "Placeholder";
        // 
        // openedModeLabel
        // 
        this.openedModeLabel.AutoSize = true;
        this.openedModeLabel.Location = new Point(46, 9);
        this.openedModeLabel.Name = "openedModeLabel";
        this.openedModeLabel.Size = new Size(55, 20);
        this.openedModeLabel.TabIndex = 4;
        this.openedModeLabel.Text = "Mode :";
        // 
        // bottomBarPanel
        // 
        this.bottomBarPanel.Controls.Add(this.ActionBtn);
        this.bottomBarPanel.Controls.Add(this.cancelBtn);
        this.bottomBarPanel.Dock = DockStyle.Bottom;
        this.bottomBarPanel.Location = new Point(0, 597);
        this.bottomBarPanel.Name = "bottomBarPanel";
        this.bottomBarPanel.Size = new Size(802, 50);
        this.bottomBarPanel.TabIndex = 1;
        this.bottomBarPanel.Paint += this.bottomBarPanel_Paint;
        // 
        // ActionBtn
        // 
        this.ActionBtn.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.ActionBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.ActionBtn.Location = new Point(364, 9);
        this.ActionBtn.Name = "ActionBtn";
        this.ActionBtn.Size = new Size(224, 29);
        this.ActionBtn.TabIndex = 1;
        this.ActionBtn.Text = "Action";
        this.ActionBtn.UseVisualStyleBackColor = true;
        // 
        // cancelBtn
        // 
        this.cancelBtn.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.cancelBtn.Location = new Point(622, 9);
        this.cancelBtn.Name = "cancelBtn";
        this.cancelBtn.Size = new Size(154, 29);
        this.cancelBtn.TabIndex = 0;
        this.cancelBtn.Text = "Cancel";
        this.cancelBtn.UseVisualStyleBackColor = true;
        // 
        // centerTLP
        // 
        this.centerTLP.ColumnCount = 3;
        this.centerTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.centerTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 600F));
        this.centerTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.centerTLP.Controls.Add(this.centerPanel, 1, 0);
        this.centerTLP.Dock = DockStyle.Fill;
        this.centerTLP.Location = new Point(0, 50);
        this.centerTLP.Name = "centerTLP";
        this.centerTLP.RowCount = 1;
        this.centerTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.centerTLP.Size = new Size(802, 547);
        this.centerTLP.TabIndex = 2;
        // 
        // centerPanel
        // 
        this.centerPanel.Controls.Add(this.ProductsValue);
        this.centerPanel.Controls.Add(this.dateDeletedValue);
        this.centerPanel.Controls.Add(this.dateModifiedValue);
        this.centerPanel.Controls.Add(this.dateCreatedValue);
        this.centerPanel.Controls.Add(this.contactTelephoneValue);
        this.centerPanel.Controls.Add(this.contactEmailValue);
        this.centerPanel.Controls.Add(this.contactFirstNameValue);
        this.centerPanel.Controls.Add(this.contactLastNameValue);
        this.centerPanel.Controls.Add(this.supplierNameValue);
        this.centerPanel.Controls.Add(this.idValue);
        this.centerPanel.Controls.Add(this.label1);
        this.centerPanel.Controls.Add(this.dateDeletedLabel);
        this.centerPanel.Controls.Add(this.dateModifiedLabel);
        this.centerPanel.Controls.Add(this.dateCreatedLabel);
        this.centerPanel.Controls.Add(this.contactTelephoneLabel);
        this.centerPanel.Controls.Add(this.contactEmailLabel);
        this.centerPanel.Controls.Add(this.contactFirstNameLabel);
        this.centerPanel.Controls.Add(this.contactLastNameLabel);
        this.centerPanel.Controls.Add(this.supplierNameLabel);
        this.centerPanel.Controls.Add(this.idLabel);
        this.centerPanel.Dock = DockStyle.Fill;
        this.centerPanel.Location = new Point(104, 3);
        this.centerPanel.Name = "centerPanel";
        this.centerPanel.Size = new Size(594, 541);
        this.centerPanel.TabIndex = 0;
        // 
        // ProductsValue
        // 
        this.ProductsValue.FormattingEnabled = true;
        this.ProductsValue.ItemHeight = 20;
        this.ProductsValue.Location = new Point(229, 343);
        this.ProductsValue.Name = "ProductsValue";
        this.ProductsValue.Size = new Size(311, 184);
        this.ProductsValue.TabIndex = 19;
        // 
        // dateDeletedValue
        // 
        this.dateDeletedValue.Location = new Point(229, 290);
        this.dateDeletedValue.Name = "dateDeletedValue";
        this.dateDeletedValue.Size = new Size(250, 27);
        this.dateDeletedValue.TabIndex = 18;
        // 
        // dateModifiedValue
        // 
        this.dateModifiedValue.Location = new Point(229, 255);
        this.dateModifiedValue.Name = "dateModifiedValue";
        this.dateModifiedValue.Size = new Size(250, 27);
        this.dateModifiedValue.TabIndex = 17;
        // 
        // dateCreatedValue
        // 
        this.dateCreatedValue.Location = new Point(229, 222);
        this.dateCreatedValue.Name = "dateCreatedValue";
        this.dateCreatedValue.Size = new Size(250, 27);
        this.dateCreatedValue.TabIndex = 16;
        // 
        // contactTelephoneValue
        // 
        this.contactTelephoneValue.Location = new Point(229, 189);
        this.contactTelephoneValue.Name = "contactTelephoneValue";
        this.contactTelephoneValue.Size = new Size(270, 27);
        this.contactTelephoneValue.TabIndex = 15;
        // 
        // contactEmailValue
        // 
        this.contactEmailValue.Location = new Point(229, 156);
        this.contactEmailValue.Name = "contactEmailValue";
        this.contactEmailValue.Size = new Size(270, 27);
        this.contactEmailValue.TabIndex = 14;
        // 
        // contactFirstNameValue
        // 
        this.contactFirstNameValue.Location = new Point(229, 123);
        this.contactFirstNameValue.Name = "contactFirstNameValue";
        this.contactFirstNameValue.Size = new Size(270, 27);
        this.contactFirstNameValue.TabIndex = 13;
        // 
        // contactLastNameValue
        // 
        this.contactLastNameValue.Location = new Point(229, 90);
        this.contactLastNameValue.Name = "contactLastNameValue";
        this.contactLastNameValue.Size = new Size(270, 27);
        this.contactLastNameValue.TabIndex = 12;
        // 
        // supplierNameValue
        // 
        this.supplierNameValue.Location = new Point(229, 57);
        this.supplierNameValue.Name = "supplierNameValue";
        this.supplierNameValue.Size = new Size(270, 27);
        this.supplierNameValue.TabIndex = 11;
        // 
        // idValue
        // 
        this.idValue.Enabled = false;
        this.idValue.Location = new Point(229, 24);
        this.idValue.Name = "idValue";
        this.idValue.Size = new Size(209, 27);
        this.idValue.TabIndex = 10;
        // 
        // label1
        // 
        this.label1.Location = new Point(27, 343);
        this.label1.Name = "label1";
        this.label1.Size = new Size(196, 25);
        this.label1.TabIndex = 9;
        this.label1.Text = "Products List :";
        this.label1.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateDeletedLabel
        // 
        this.dateDeletedLabel.Location = new Point(5, 290);
        this.dateDeletedLabel.Name = "dateDeletedLabel";
        this.dateDeletedLabel.Size = new Size(218, 25);
        this.dateDeletedLabel.TabIndex = 8;
        this.dateDeletedLabel.Text = "Date Deleted :";
        this.dateDeletedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateModifiedLabel
        // 
        this.dateModifiedLabel.Location = new Point(5, 257);
        this.dateModifiedLabel.Name = "dateModifiedLabel";
        this.dateModifiedLabel.Size = new Size(218, 25);
        this.dateModifiedLabel.TabIndex = 7;
        this.dateModifiedLabel.Text = "Date Modified :";
        this.dateModifiedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateCreatedLabel
        // 
        this.dateCreatedLabel.Location = new Point(5, 222);
        this.dateCreatedLabel.Name = "dateCreatedLabel";
        this.dateCreatedLabel.Size = new Size(218, 25);
        this.dateCreatedLabel.TabIndex = 6;
        this.dateCreatedLabel.Text = "Date Created :";
        this.dateCreatedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // contactTelephoneLabel
        // 
        this.contactTelephoneLabel.Location = new Point(5, 191);
        this.contactTelephoneLabel.Name = "contactTelephoneLabel";
        this.contactTelephoneLabel.Size = new Size(218, 25);
        this.contactTelephoneLabel.TabIndex = 5;
        this.contactTelephoneLabel.Text = "Contact Telephone :";
        this.contactTelephoneLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // contactEmailLabel
        // 
        this.contactEmailLabel.Location = new Point(5, 158);
        this.contactEmailLabel.Name = "contactEmailLabel";
        this.contactEmailLabel.Size = new Size(218, 25);
        this.contactEmailLabel.TabIndex = 4;
        this.contactEmailLabel.Text = "Contact Email :";
        this.contactEmailLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // contactFirstNameLabel
        // 
        this.contactFirstNameLabel.Location = new Point(5, 125);
        this.contactFirstNameLabel.Name = "contactFirstNameLabel";
        this.contactFirstNameLabel.Size = new Size(218, 25);
        this.contactFirstNameLabel.TabIndex = 3;
        this.contactFirstNameLabel.Text = "Contact First Name :";
        this.contactFirstNameLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // contactLastNameLabel
        // 
        this.contactLastNameLabel.Location = new Point(5, 92);
        this.contactLastNameLabel.Name = "contactLastNameLabel";
        this.contactLastNameLabel.Size = new Size(218, 25);
        this.contactLastNameLabel.TabIndex = 2;
        this.contactLastNameLabel.Text = "Contact Last Name :";
        this.contactLastNameLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // supplierNameLabel
        // 
        this.supplierNameLabel.Location = new Point(5, 57);
        this.supplierNameLabel.Name = "supplierNameLabel";
        this.supplierNameLabel.Size = new Size(218, 25);
        this.supplierNameLabel.TabIndex = 1;
        this.supplierNameLabel.Text = "Supplier Name :";
        this.supplierNameLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // idLabel
        // 
        this.idLabel.Location = new Point(5, 24);
        this.idLabel.Name = "idLabel";
        this.idLabel.Size = new Size(218, 25);
        this.idLabel.TabIndex = 0;
        this.idLabel.Text = "Id :";
        this.idLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // SupplierView
        // 
        this.AutoScaleDimensions = new SizeF(8F, 20F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(802, 647);
        this.Controls.Add(this.centerTLP);
        this.Controls.Add(this.bottomBarPanel);
        this.Controls.Add(this.topBarPanel);
        this.Name = "SupplierView";
        this.Text = "SupplierView";
        this.topBarPanel.ResumeLayout(false);
        this.topBarPanel.PerformLayout();
        this.bottomBarPanel.ResumeLayout(false);
        this.centerTLP.ResumeLayout(false);
        this.centerPanel.ResumeLayout(false);
        this.centerPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize) this.idValue).EndInit();
        this.ResumeLayout(false);
    }

    #endregion

    private Panel topBarPanel;
    private Panel bottomBarPanel;
    private Button ActionBtn;
    private Button cancelBtn;
    private TableLayoutPanel centerTLP;
    private Panel centerPanel;
    private Label contactTelephoneLabel;
    private Label contactEmailLabel;
    private Label contactFirstNameLabel;
    private Label contactLastNameLabel;
    private Label supplierNameLabel;
    private Label idLabel;
    private Label dateCreatedLabel;
    private NumericUpDown idValue;
    private Label label1;
    private Label dateDeletedLabel;
    private Label dateModifiedLabel;
    private DateTimePicker dateModifiedValue;
    private DateTimePicker dateCreatedValue;
    private TextBox contactTelephoneValue;
    private TextBox contactEmailValue;
    private TextBox contactFirstNameValue;
    private TextBox contactLastNameValue;
    private TextBox supplierNameValue;
    private ListBox ProductsValue;
    private DateTimePicker dateDeletedValue;
    private Label openendModeValue;
    private Label openedModeLabel;
}