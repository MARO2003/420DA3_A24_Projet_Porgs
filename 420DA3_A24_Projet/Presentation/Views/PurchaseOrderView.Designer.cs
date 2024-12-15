namespace _420DA3_A24_Projet.Presentation.Views;

partial class PurchaseOrderView {
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
        this.dateDeletedValue = new DateTimePicker();
        this.dateModifiedValue = new DateTimePicker();
        this.dateCreatedValue = new DateTimePicker();
        this.contactEmailValue = new TextBox();
        this.statusValue = new TextBox();
        this.idValue = new NumericUpDown();
        this.dateDeletedLabel = new Label();
        this.dateModifiedLabel = new Label();
        this.dateCreatedLabel = new Label();
        this.quantityabel = new Label();
        this.idLabel = new Label();
        this.centerPanel = new Panel();
        this.contactTelephoneLabel = new Label();
        this.statusLabel = new Label();
        this.ActionBtn = new Button();
        this.cancelBtn = new Button();
        this.centerTLP = new TableLayoutPanel();
        this.bottomBarPanel = new Panel();
        this.topBarPanel = new Panel();
        this.completionDate = new DateTimePicker();
        this.openendModeValue = new Label();
        this.openedModeLabel = new Label();
        ((System.ComponentModel.ISupportInitialize) this.idValue).BeginInit();
        this.centerPanel.SuspendLayout();
        this.centerTLP.SuspendLayout();
        this.bottomBarPanel.SuspendLayout();
        this.topBarPanel.SuspendLayout();
        this.SuspendLayout();
        // 
        // dateDeletedValue
        // 
        this.dateDeletedValue.Location = new Point(229, 224);
        this.dateDeletedValue.Name = "dateDeletedValue";
        this.dateDeletedValue.Size = new Size(250, 27);
        this.dateDeletedValue.TabIndex = 18;
        // 
        // dateModifiedValue
        // 
        this.dateModifiedValue.Location = new Point(229, 189);
        this.dateModifiedValue.Name = "dateModifiedValue";
        this.dateModifiedValue.Size = new Size(250, 27);
        this.dateModifiedValue.TabIndex = 17;
        // 
        // dateCreatedValue
        // 
        this.dateCreatedValue.Location = new Point(229, 156);
        this.dateCreatedValue.Name = "dateCreatedValue";
        this.dateCreatedValue.Size = new Size(250, 27);
        this.dateCreatedValue.TabIndex = 16;
        // 
        // contactEmailValue
        // 
        this.contactEmailValue.Location = new Point(229, 90);
        this.contactEmailValue.Name = "contactEmailValue";
        this.contactEmailValue.Size = new Size(270, 27);
        this.contactEmailValue.TabIndex = 14;
        // 
        // statusValue
        // 
        this.statusValue.Location = new Point(229, 57);
        this.statusValue.Name = "statusValue";
        this.statusValue.Size = new Size(270, 27);
        this.statusValue.TabIndex = 11;
        // 
        // idValue
        // 
        this.idValue.Enabled = false;
        this.idValue.Location = new Point(229, 24);
        this.idValue.Name = "idValue";
        this.idValue.Size = new Size(209, 27);
        this.idValue.TabIndex = 10;
        // 
        // dateDeletedLabel
        // 
        this.dateDeletedLabel.Location = new Point(5, 224);
        this.dateDeletedLabel.Name = "dateDeletedLabel";
        this.dateDeletedLabel.Size = new Size(218, 25);
        this.dateDeletedLabel.TabIndex = 8;
        this.dateDeletedLabel.Text = "Date Deleted :";
        this.dateDeletedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateModifiedLabel
        // 
        this.dateModifiedLabel.Location = new Point(5, 191);
        this.dateModifiedLabel.Name = "dateModifiedLabel";
        this.dateModifiedLabel.Size = new Size(218, 25);
        this.dateModifiedLabel.TabIndex = 7;
        this.dateModifiedLabel.Text = "Date Modified :";
        this.dateModifiedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateCreatedLabel
        // 
        this.dateCreatedLabel.Location = new Point(5, 156);
        this.dateCreatedLabel.Name = "dateCreatedLabel";
        this.dateCreatedLabel.Size = new Size(218, 25);
        this.dateCreatedLabel.TabIndex = 6;
        this.dateCreatedLabel.Text = "Date Created :";
        this.dateCreatedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // quantityabel
        // 
        this.quantityabel.Location = new Point(5, 92);
        this.quantityabel.Name = "quantityabel";
        this.quantityabel.Size = new Size(218, 25);
        this.quantityabel.TabIndex = 4;
        this.quantityabel.Text = "Quantity :";
        this.quantityabel.TextAlign = ContentAlignment.MiddleRight;
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
        // centerPanel
        // 
        this.centerPanel.Controls.Add(this.completionDate);
        this.centerPanel.Controls.Add(this.dateDeletedValue);
        this.centerPanel.Controls.Add(this.dateModifiedValue);
        this.centerPanel.Controls.Add(this.dateCreatedValue);
        this.centerPanel.Controls.Add(this.contactEmailValue);
        this.centerPanel.Controls.Add(this.statusValue);
        this.centerPanel.Controls.Add(this.idValue);
        this.centerPanel.Controls.Add(this.dateDeletedLabel);
        this.centerPanel.Controls.Add(this.dateModifiedLabel);
        this.centerPanel.Controls.Add(this.dateCreatedLabel);
        this.centerPanel.Controls.Add(this.contactTelephoneLabel);
        this.centerPanel.Controls.Add(this.quantityabel);
        this.centerPanel.Controls.Add(this.statusLabel);
        this.centerPanel.Controls.Add(this.idLabel);
        this.centerPanel.Dock = DockStyle.Fill;
        this.centerPanel.Location = new Point(104, 3);
        this.centerPanel.Name = "centerPanel";
        this.centerPanel.Size = new Size(594, 298);
        this.centerPanel.TabIndex = 0;
        // 
        // contactTelephoneLabel
        // 
        this.contactTelephoneLabel.Location = new Point(5, 125);
        this.contactTelephoneLabel.Name = "contactTelephoneLabel";
        this.contactTelephoneLabel.Size = new Size(218, 25);
        this.contactTelephoneLabel.TabIndex = 5;
        this.contactTelephoneLabel.Text = "Completion Date :";
        this.contactTelephoneLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // statusLabel
        // 
        this.statusLabel.Location = new Point(5, 57);
        this.statusLabel.Name = "statusLabel";
        this.statusLabel.Size = new Size(218, 25);
        this.statusLabel.TabIndex = 1;
        this.statusLabel.Text = "Status :";
        this.statusLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // ActionBtn
        // 
        this.ActionBtn.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.ActionBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.ActionBtn.Location = new Point(966, -41);
        this.ActionBtn.Name = "ActionBtn";
        this.ActionBtn.Size = new Size(224, 29);
        this.ActionBtn.TabIndex = 1;
        this.ActionBtn.Text = "Action";
        this.ActionBtn.UseVisualStyleBackColor = true;
        // 
        // cancelBtn
        // 
        this.cancelBtn.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.cancelBtn.Location = new Point(1224, -41);
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
        this.centerTLP.Size = new Size(802, 304);
        this.centerTLP.TabIndex = 5;
        // 
        // bottomBarPanel
        // 
        this.bottomBarPanel.Controls.Add(this.ActionBtn);
        this.bottomBarPanel.Controls.Add(this.cancelBtn);
        this.bottomBarPanel.Dock = DockStyle.Bottom;
        this.bottomBarPanel.Location = new Point(0, 354);
        this.bottomBarPanel.Name = "bottomBarPanel";
        this.bottomBarPanel.Size = new Size(802, 50);
        this.bottomBarPanel.TabIndex = 4;
        // 
        // topBarPanel
        // 
        this.topBarPanel.Controls.Add(this.openendModeValue);
        this.topBarPanel.Controls.Add(this.openedModeLabel);
        this.topBarPanel.Dock = DockStyle.Top;
        this.topBarPanel.Location = new Point(0, 0);
        this.topBarPanel.Name = "topBarPanel";
        this.topBarPanel.Size = new Size(802, 50);
        this.topBarPanel.TabIndex = 3;
        // 
        // completionDate
        // 
        this.completionDate.Location = new Point(229, 122);
        this.completionDate.Name = "completionDate";
        this.completionDate.Size = new Size(250, 27);
        this.completionDate.TabIndex = 19;
        // 
        // openendModeValue
        // 
        this.openendModeValue.AutoSize = true;
        this.openendModeValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.openendModeValue.Location = new Point(77, 9);
        this.openendModeValue.Name = "openendModeValue";
        this.openendModeValue.Size = new Size(90, 20);
        this.openendModeValue.TabIndex = 3;
        this.openendModeValue.Text = "Placeholder";
        // 
        // openedModeLabel
        // 
        this.openedModeLabel.AutoSize = true;
        this.openedModeLabel.Location = new Point(19, 9);
        this.openedModeLabel.Name = "openedModeLabel";
        this.openedModeLabel.Size = new Size(55, 20);
        this.openedModeLabel.TabIndex = 2;
        this.openedModeLabel.Text = "Mode :";
        // 
        // PurchaseOrderView
        // 
        this.AutoScaleDimensions = new SizeF(8F, 20F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(802, 404);
        this.Controls.Add(this.centerTLP);
        this.Controls.Add(this.bottomBarPanel);
        this.Controls.Add(this.topBarPanel);
        this.Name = "PurchaseOrderView";
        this.Text = "PurchaseOrderView";
        this.Load += this.PurchaseOrderView_Load;
        ((System.ComponentModel.ISupportInitialize) this.idValue).EndInit();
        this.centerPanel.ResumeLayout(false);
        this.centerPanel.PerformLayout();
        this.centerTLP.ResumeLayout(false);
        this.bottomBarPanel.ResumeLayout(false);
        this.topBarPanel.ResumeLayout(false);
        this.topBarPanel.PerformLayout();
        this.ResumeLayout(false);
    }

    #endregion
    private DateTimePicker dateDeletedValue;
    private DateTimePicker dateModifiedValue;
    private DateTimePicker dateCreatedValue;
    private TextBox contactEmailValue;
    private TextBox statusValue;
    private NumericUpDown idValue;
    private Label dateDeletedLabel;
    private Label dateModifiedLabel;
    private Label dateCreatedLabel;
    private Label quantityabel;
    private Label idLabel;
    private Panel centerPanel;
    private Label contactTelephoneLabel;
    private Label statusLabel;
    private Button ActionBtn;
    private Button cancelBtn;
    private TableLayoutPanel centerTLP;
    private Panel bottomBarPanel;
    private Panel topBarPanel;
    private DateTimePicker completionDate;
    private Label openendModeValue;
    private Label openedModeLabel;
}