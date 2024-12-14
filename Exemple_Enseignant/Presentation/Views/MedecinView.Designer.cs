namespace _420DA3_A24_Exemple_Enseignant.Presentation.Views;

partial class MedecinView {
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
        this.viewModeValueLabel = new Label();
        this.viewModeHeaderLabal = new Label();
        this.bottomBarPanel = new Panel();
        this.copyrightLabel = new Label();
        this.actionButton = new Button();
        this.cancelButton = new Button();
        this.centralTableLayoutPanel = new TableLayoutPanel();
        this.centralPanel = new Panel();
        this.licenseNumericUpDown = new TextBox();
        this.dateDeletedDTPicker = new DateTimePicker();
        this.dateModifiedDTPicker = new DateTimePicker();
        this.dateCreatedDTPicker = new DateTimePicker();
        this.prenomTextBox = new TextBox();
        this.idNumericUpDown = new NumericUpDown();
        this.nomTextBox = new TextBox();
        this.dateDeletedLabel = new Label();
        this.dateModifiedLabel = new Label();
        this.dateCreatedLabel = new Label();
        this.numLicenseLabel = new Label();
        this.prenomLabel = new Label();
        this.nomLabel = new Label();
        this.idLabel = new Label();
        this.topBarPanel.SuspendLayout();
        this.bottomBarPanel.SuspendLayout();
        this.centralTableLayoutPanel.SuspendLayout();
        this.centralPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) this.idNumericUpDown).BeginInit();
        this.SuspendLayout();
        // 
        // topBarPanel
        // 
        this.topBarPanel.Controls.Add(this.viewModeValueLabel);
        this.topBarPanel.Controls.Add(this.viewModeHeaderLabal);
        this.topBarPanel.Dock = DockStyle.Top;
        this.topBarPanel.Location = new Point(0, 0);
        this.topBarPanel.Margin = new Padding(3, 4, 3, 4);
        this.topBarPanel.Name = "topBarPanel";
        this.topBarPanel.Size = new Size(772, 53);
        this.topBarPanel.TabIndex = 0;
        // 
        // viewModeValueLabel
        // 
        this.viewModeValueLabel.AutoSize = true;
        this.viewModeValueLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.viewModeValueLabel.Location = new Point(105, 12);
        this.viewModeValueLabel.Name = "viewModeValueLabel";
        this.viewModeValueLabel.Size = new Size(113, 20);
        this.viewModeValueLabel.TabIndex = 1;
        this.viewModeValueLabel.Text = "PLACEHOLDER";
        // 
        // viewModeHeaderLabal
        // 
        this.viewModeHeaderLabal.AutoSize = true;
        this.viewModeHeaderLabal.Location = new Point(14, 12);
        this.viewModeHeaderLabal.Name = "viewModeHeaderLabal";
        this.viewModeHeaderLabal.Size = new Size(94, 20);
        this.viewModeHeaderLabal.TabIndex = 0;
        this.viewModeHeaderLabal.Text = "VIEW MODE:";
        // 
        // bottomBarPanel
        // 
        this.bottomBarPanel.Controls.Add(this.copyrightLabel);
        this.bottomBarPanel.Controls.Add(this.actionButton);
        this.bottomBarPanel.Controls.Add(this.cancelButton);
        this.bottomBarPanel.Dock = DockStyle.Bottom;
        this.bottomBarPanel.Location = new Point(0, 595);
        this.bottomBarPanel.Margin = new Padding(3, 4, 3, 4);
        this.bottomBarPanel.Name = "bottomBarPanel";
        this.bottomBarPanel.Size = new Size(772, 67);
        this.bottomBarPanel.TabIndex = 1;
        // 
        // copyrightLabel
        // 
        this.copyrightLabel.AutoSize = true;
        this.copyrightLabel.Location = new Point(14, 31);
        this.copyrightLabel.Name = "copyrightLabel";
        this.copyrightLabel.Size = new Size(108, 20);
        this.copyrightLabel.TabIndex = 2;
        this.copyrightLabel.Text = "PLACEHOLDER";
        // 
        // actionButton
        // 
        this.actionButton.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.actionButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.actionButton.Location = new Point(523, 8);
        this.actionButton.Margin = new Padding(3, 4, 3, 4);
        this.actionButton.Name = "actionButton";
        this.actionButton.Size = new Size(114, 43);
        this.actionButton.TabIndex = 1;
        this.actionButton.Text = "ACTION";
        this.actionButton.UseVisualStyleBackColor = true;
        this.actionButton.Click += this.ActionButton_Click;
        // 
        // cancelButton
        // 
        this.cancelButton.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.cancelButton.Location = new Point(644, 8);
        this.cancelButton.Margin = new Padding(3, 4, 3, 4);
        this.cancelButton.Name = "cancelButton";
        this.cancelButton.Size = new Size(114, 43);
        this.cancelButton.TabIndex = 0;
        this.cancelButton.Text = "Cancel";
        this.cancelButton.UseVisualStyleBackColor = true;
        this.cancelButton.Click += this.CancelButton_Click;
        // 
        // centralTableLayoutPanel
        // 
        this.centralTableLayoutPanel.ColumnCount = 3;
        this.centralTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
        this.centralTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
        this.centralTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
        this.centralTableLayoutPanel.Controls.Add(this.centralPanel, 1, 0);
        this.centralTableLayoutPanel.Dock = DockStyle.Fill;
        this.centralTableLayoutPanel.Location = new Point(0, 53);
        this.centralTableLayoutPanel.Margin = new Padding(3, 4, 3, 4);
        this.centralTableLayoutPanel.Name = "centralTableLayoutPanel";
        this.centralTableLayoutPanel.RowCount = 1;
        this.centralTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.centralTableLayoutPanel.Size = new Size(772, 542);
        this.centralTableLayoutPanel.TabIndex = 2;
        // 
        // centralPanel
        // 
        this.centralPanel.Controls.Add(this.licenseNumericUpDown);
        this.centralPanel.Controls.Add(this.dateDeletedDTPicker);
        this.centralPanel.Controls.Add(this.dateModifiedDTPicker);
        this.centralPanel.Controls.Add(this.dateCreatedDTPicker);
        this.centralPanel.Controls.Add(this.prenomTextBox);
        this.centralPanel.Controls.Add(this.idNumericUpDown);
        this.centralPanel.Controls.Add(this.nomTextBox);
        this.centralPanel.Controls.Add(this.dateDeletedLabel);
        this.centralPanel.Controls.Add(this.dateModifiedLabel);
        this.centralPanel.Controls.Add(this.dateCreatedLabel);
        this.centralPanel.Controls.Add(this.numLicenseLabel);
        this.centralPanel.Controls.Add(this.prenomLabel);
        this.centralPanel.Controls.Add(this.nomLabel);
        this.centralPanel.Controls.Add(this.idLabel);
        this.centralPanel.Dock = DockStyle.Fill;
        this.centralPanel.Location = new Point(80, 4);
        this.centralPanel.Margin = new Padding(3, 4, 3, 4);
        this.centralPanel.Name = "centralPanel";
        this.centralPanel.Size = new Size(611, 534);
        this.centralPanel.TabIndex = 0;
        this.centralPanel.Paint += this.centralPanel_Paint;
        // 
        // licenseNumericUpDown
        // 
        this.licenseNumericUpDown.Location = new Point(246, 196);
        this.licenseNumericUpDown.Margin = new Padding(3, 4, 3, 4);
        this.licenseNumericUpDown.Name = "licenseNumericUpDown";
        this.licenseNumericUpDown.Size = new Size(285, 27);
        this.licenseNumericUpDown.TabIndex = 14;
        // 
        // dateDeletedDTPicker
        // 
        this.dateDeletedDTPicker.Enabled = false;
        this.dateDeletedDTPicker.Location = new Point(246, 353);
        this.dateDeletedDTPicker.Margin = new Padding(3, 4, 3, 4);
        this.dateDeletedDTPicker.Name = "dateDeletedDTPicker";
        this.dateDeletedDTPicker.Size = new Size(285, 27);
        this.dateDeletedDTPicker.TabIndex = 13;
        // 
        // dateModifiedDTPicker
        // 
        this.dateModifiedDTPicker.Enabled = false;
        this.dateModifiedDTPicker.Location = new Point(246, 313);
        this.dateModifiedDTPicker.Margin = new Padding(3, 4, 3, 4);
        this.dateModifiedDTPicker.Name = "dateModifiedDTPicker";
        this.dateModifiedDTPicker.Size = new Size(285, 27);
        this.dateModifiedDTPicker.TabIndex = 12;
        // 
        // dateCreatedDTPicker
        // 
        this.dateCreatedDTPicker.Enabled = false;
        this.dateCreatedDTPicker.Location = new Point(246, 273);
        this.dateCreatedDTPicker.Margin = new Padding(3, 4, 3, 4);
        this.dateCreatedDTPicker.Name = "dateCreatedDTPicker";
        this.dateCreatedDTPicker.Size = new Size(285, 27);
        this.dateCreatedDTPicker.TabIndex = 11;
        // 
        // prenomTextBox
        // 
        this.prenomTextBox.Location = new Point(246, 156);
        this.prenomTextBox.Margin = new Padding(3, 4, 3, 4);
        this.prenomTextBox.Name = "prenomTextBox";
        this.prenomTextBox.Size = new Size(285, 27);
        this.prenomTextBox.TabIndex = 9;
        // 
        // idNumericUpDown
        // 
        this.idNumericUpDown.Enabled = false;
        this.idNumericUpDown.Location = new Point(246, 49);
        this.idNumericUpDown.Margin = new Padding(3, 4, 3, 4);
        this.idNumericUpDown.Name = "idNumericUpDown";
        this.idNumericUpDown.Size = new Size(286, 27);
        this.idNumericUpDown.TabIndex = 8;
        // 
        // nomTextBox
        // 
        this.nomTextBox.Location = new Point(246, 116);
        this.nomTextBox.Margin = new Padding(3, 4, 3, 4);
        this.nomTextBox.Name = "nomTextBox";
        this.nomTextBox.Size = new Size(285, 27);
        this.nomTextBox.TabIndex = 7;
        // 
        // dateDeletedLabel
        // 
        this.dateDeletedLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.dateDeletedLabel.Location = new Point(10, 351);
        this.dateDeletedLabel.Name = "dateDeletedLabel";
        this.dateDeletedLabel.Size = new Size(229, 40);
        this.dateDeletedLabel.TabIndex = 6;
        this.dateDeletedLabel.Text = "Date de suppression: ";
        this.dateDeletedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateModifiedLabel
        // 
        this.dateModifiedLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.dateModifiedLabel.Location = new Point(10, 311);
        this.dateModifiedLabel.Name = "dateModifiedLabel";
        this.dateModifiedLabel.Size = new Size(229, 40);
        this.dateModifiedLabel.TabIndex = 5;
        this.dateModifiedLabel.Text = "Date de modification: ";
        this.dateModifiedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateCreatedLabel
        // 
        this.dateCreatedLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.dateCreatedLabel.Location = new Point(10, 271);
        this.dateCreatedLabel.Name = "dateCreatedLabel";
        this.dateCreatedLabel.Size = new Size(229, 40);
        this.dateCreatedLabel.TabIndex = 4;
        this.dateCreatedLabel.Text = "Date de création: ";
        this.dateCreatedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // numLicenseLabel
        // 
        this.numLicenseLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.numLicenseLabel.Location = new Point(10, 189);
        this.numLicenseLabel.Name = "numLicenseLabel";
        this.numLicenseLabel.Size = new Size(229, 40);
        this.numLicenseLabel.TabIndex = 3;
        this.numLicenseLabel.Text = "Num. Licence: ";
        this.numLicenseLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // prenomLabel
        // 
        this.prenomLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.prenomLabel.Location = new Point(10, 149);
        this.prenomLabel.Name = "prenomLabel";
        this.prenomLabel.Size = new Size(229, 40);
        this.prenomLabel.TabIndex = 2;
        this.prenomLabel.Text = "Prenom: ";
        this.prenomLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // nomLabel
        // 
        this.nomLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.nomLabel.Location = new Point(10, 109);
        this.nomLabel.Name = "nomLabel";
        this.nomLabel.Size = new Size(229, 40);
        this.nomLabel.TabIndex = 1;
        this.nomLabel.Text = "Nom: ";
        this.nomLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // idLabel
        // 
        this.idLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.idLabel.Location = new Point(10, 41);
        this.idLabel.Name = "idLabel";
        this.idLabel.Size = new Size(229, 40);
        this.idLabel.TabIndex = 0;
        this.idLabel.Text = "ID: ";
        this.idLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // MedecinView
        // 
        this.AutoScaleDimensions = new SizeF(8F, 20F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(772, 662);
        this.Controls.Add(this.centralTableLayoutPanel);
        this.Controls.Add(this.bottomBarPanel);
        this.Controls.Add(this.topBarPanel);
        this.Margin = new Padding(3, 4, 3, 4);
        this.Name = "MedecinView";
        this.Text = "Gestion des médecins";
        this.topBarPanel.ResumeLayout(false);
        this.topBarPanel.PerformLayout();
        this.bottomBarPanel.ResumeLayout(false);
        this.bottomBarPanel.PerformLayout();
        this.centralTableLayoutPanel.ResumeLayout(false);
        this.centralPanel.ResumeLayout(false);
        this.centralPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize) this.idNumericUpDown).EndInit();
        this.ResumeLayout(false);
    }

    #endregion

    private Panel topBarPanel;
    private Panel bottomBarPanel;
    private Button cancelButton;
    private Button actionButton;
    private TableLayoutPanel centralTableLayoutPanel;
    private Label viewModeValueLabel;
    private Label viewModeHeaderLabal;
    private Label copyrightLabel;
    private Panel centralPanel;
    private Label numLicenseLabel;
    private Label prenomLabel;
    private Label nomLabel;
    private Label idLabel;
    private Label dateCreatedLabel;
    private Label dateDeletedLabel;
    private Label dateModifiedLabel;
    private DateTimePicker dateDeletedDTPicker;
    private DateTimePicker dateModifiedDTPicker;
    private DateTimePicker dateCreatedDTPicker;
    private TextBox prenomTextBox;
    private NumericUpDown idNumericUpDown;
    private TextBox nomTextBox;
    private TextBox licenseNumericUpDown;
}