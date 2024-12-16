namespace _420DA3_A24_Projet.Presentation.Views;

partial class CustomerView {
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
        this.dateDeletedLabel = new Label();
        this.dateModifiedLabel = new Label();
        this.dateCreatedLabel = new Label();
        this.nameValue = new TextBox();
        this.nameLabel = new Label();
        this.idValue = new NumericUpDown();
        this.idLabel = new Label();
        this.centerTLP = new TableLayoutPanel();
        this.centerPanel = new Panel();
        this.telephoneValue = new TextBox();
        this.emailValue = new TextBox();
        this.label4 = new Label();
        this.label3 = new Label();
        this.firstNameValue = new TextBox();
        this.label2 = new Label();
        this.label1 = new Label();
        this.lastNameValue = new TextBox();
        this.actionButton = new Button();
        this.cancelButton = new Button();
        this.bottomBarPanel = new Panel();
        this.actionBtn = new Button();
        this.cancelBtn = new Button();
        this.openedModeValue = new Label();
        this.openedModeLabel = new Label();
        this.topBarPanel = new Panel();
        ((System.ComponentModel.ISupportInitialize) this.idValue).BeginInit();
        this.centerTLP.SuspendLayout();
        this.centerPanel.SuspendLayout();
        this.bottomBarPanel.SuspendLayout();
        this.topBarPanel.SuspendLayout();
        this.SuspendLayout();
        // 
        // dateDeletedValue
        // 
        this.dateDeletedValue.Enabled = false;
        this.dateDeletedValue.Location = new Point(216, 356);
        this.dateDeletedValue.Margin = new Padding(3, 4, 3, 4);
        this.dateDeletedValue.Name = "dateDeletedValue";
        this.dateDeletedValue.Size = new Size(299, 27);
        this.dateDeletedValue.TabIndex = 11;
        // 
        // dateModifiedValue
        // 
        this.dateModifiedValue.Enabled = false;
        this.dateModifiedValue.Location = new Point(216, 315);
        this.dateModifiedValue.Margin = new Padding(3, 4, 3, 4);
        this.dateModifiedValue.Name = "dateModifiedValue";
        this.dateModifiedValue.Size = new Size(299, 27);
        this.dateModifiedValue.TabIndex = 10;
        // 
        // dateCreatedValue
        // 
        this.dateCreatedValue.Enabled = false;
        this.dateCreatedValue.Location = new Point(216, 272);
        this.dateCreatedValue.Margin = new Padding(3, 4, 3, 4);
        this.dateCreatedValue.Name = "dateCreatedValue";
        this.dateCreatedValue.Size = new Size(299, 27);
        this.dateCreatedValue.TabIndex = 9;
        // 
        // dateDeletedLabel
        // 
        this.dateDeletedLabel.Location = new Point(-11, 356);
        this.dateDeletedLabel.Margin = new Padding(3, 4, 3, 4);
        this.dateDeletedLabel.Name = "dateDeletedLabel";
        this.dateDeletedLabel.Size = new Size(206, 31);
        this.dateDeletedLabel.TabIndex = 8;
        this.dateDeletedLabel.Text = "Date deleted :";
        this.dateDeletedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateModifiedLabel
        // 
        this.dateModifiedLabel.Location = new Point(-11, 311);
        this.dateModifiedLabel.Margin = new Padding(3, 4, 3, 4);
        this.dateModifiedLabel.Name = "dateModifiedLabel";
        this.dateModifiedLabel.Size = new Size(206, 31);
        this.dateModifiedLabel.TabIndex = 7;
        this.dateModifiedLabel.Text = "Date last modified :";
        this.dateModifiedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateCreatedLabel
        // 
        this.dateCreatedLabel.Location = new Point(-11, 272);
        this.dateCreatedLabel.Margin = new Padding(3, 4, 3, 4);
        this.dateCreatedLabel.Name = "dateCreatedLabel";
        this.dateCreatedLabel.Size = new Size(206, 31);
        this.dateCreatedLabel.TabIndex = 6;
        this.dateCreatedLabel.Text = "Date created :";
        this.dateCreatedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // nameValue
        // 
        this.nameValue.Location = new Point(216, 42);
        this.nameValue.Margin = new Padding(3, 4, 3, 4);
        this.nameValue.Name = "nameValue";
        this.nameValue.PlaceholderText = "Customer name";
        this.nameValue.Size = new Size(299, 27);
        this.nameValue.TabIndex = 3;
        // 
        // nameLabel
        // 
        this.nameLabel.Location = new Point(-11, 40);
        this.nameLabel.Margin = new Padding(3, 4, 3, 4);
        this.nameLabel.Name = "nameLabel";
        this.nameLabel.Size = new Size(206, 31);
        this.nameLabel.TabIndex = 2;
        this.nameLabel.Text = "Customer name :";
        this.nameLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // idValue
        // 
        this.idValue.Enabled = false;
        this.idValue.Location = new Point(216, 4);
        this.idValue.Margin = new Padding(3, 4, 3, 4);
        this.idValue.Maximum = new decimal(new int[] { -1294967296, 0, 0, 0 });
        this.idValue.Name = "idValue";
        this.idValue.Size = new Size(299, 27);
        this.idValue.TabIndex = 1;
        // 
        // idLabel
        // 
        this.idLabel.Location = new Point(-11, 1);
        this.idLabel.Margin = new Padding(3, 4, 3, 4);
        this.idLabel.Name = "idLabel";
        this.idLabel.Size = new Size(206, 31);
        this.idLabel.TabIndex = 0;
        this.idLabel.Text = "Id :";
        this.idLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // centerTLP
        // 
        this.centerTLP.ColumnCount = 3;
        this.centerTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.centerTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 526F));
        this.centerTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.centerTLP.Controls.Add(this.centerPanel, 1, 0);
        this.centerTLP.Dock = DockStyle.Fill;
        this.centerTLP.Location = new Point(0, 67);
        this.centerTLP.Margin = new Padding(3, 4, 3, 4);
        this.centerTLP.Name = "centerTLP";
        this.centerTLP.RowCount = 1;
        this.centerTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.centerTLP.Size = new Size(800, 399);
        this.centerTLP.TabIndex = 5;
        // 
        // centerPanel
        // 
        this.centerPanel.Controls.Add(this.telephoneValue);
        this.centerPanel.Controls.Add(this.emailValue);
        this.centerPanel.Controls.Add(this.label4);
        this.centerPanel.Controls.Add(this.label3);
        this.centerPanel.Controls.Add(this.firstNameValue);
        this.centerPanel.Controls.Add(this.label2);
        this.centerPanel.Controls.Add(this.label1);
        this.centerPanel.Controls.Add(this.lastNameValue);
        this.centerPanel.Controls.Add(this.dateDeletedValue);
        this.centerPanel.Controls.Add(this.dateModifiedValue);
        this.centerPanel.Controls.Add(this.dateCreatedValue);
        this.centerPanel.Controls.Add(this.dateDeletedLabel);
        this.centerPanel.Controls.Add(this.dateModifiedLabel);
        this.centerPanel.Controls.Add(this.dateCreatedLabel);
        this.centerPanel.Controls.Add(this.nameValue);
        this.centerPanel.Controls.Add(this.nameLabel);
        this.centerPanel.Controls.Add(this.idValue);
        this.centerPanel.Controls.Add(this.idLabel);
        this.centerPanel.Dock = DockStyle.Fill;
        this.centerPanel.Location = new Point(140, 4);
        this.centerPanel.Margin = new Padding(3, 4, 3, 4);
        this.centerPanel.Name = "centerPanel";
        this.centerPanel.Size = new Size(520, 391);
        this.centerPanel.TabIndex = 0;
        // 
        // telephoneValue
        // 
        this.telephoneValue.Location = new Point(216, 221);
        this.telephoneValue.Margin = new Padding(3, 4, 3, 4);
        this.telephoneValue.Name = "telephoneValue";
        this.telephoneValue.PlaceholderText = "Customer telephone number";
        this.telephoneValue.Size = new Size(299, 27);
        this.telephoneValue.TabIndex = 19;
        // 
        // emailValue
        // 
        this.emailValue.Location = new Point(216, 171);
        this.emailValue.Margin = new Padding(3, 4, 3, 4);
        this.emailValue.Name = "emailValue";
        this.emailValue.PlaceholderText = "Customer email";
        this.emailValue.Size = new Size(299, 27);
        this.emailValue.TabIndex = 18;
        // 
        // label4
        // 
        this.label4.Location = new Point(-11, 219);
        this.label4.Margin = new Padding(3, 4, 3, 4);
        this.label4.Name = "label4";
        this.label4.Size = new Size(206, 31);
        this.label4.TabIndex = 17;
        this.label4.Text = "Customer Telephone :";
        this.label4.TextAlign = ContentAlignment.MiddleRight;
        // 
        // label3
        // 
        this.label3.Location = new Point(-11, 171);
        this.label3.Margin = new Padding(3, 4, 3, 4);
        this.label3.Name = "label3";
        this.label3.Size = new Size(206, 31);
        this.label3.TabIndex = 16;
        this.label3.Text = "Customer email :";
        this.label3.TextAlign = ContentAlignment.MiddleRight;
        // 
        // firstNameValue
        // 
        this.firstNameValue.Location = new Point(216, 119);
        this.firstNameValue.Margin = new Padding(3, 4, 3, 4);
        this.firstNameValue.Name = "firstNameValue";
        this.firstNameValue.PlaceholderText = "Customer First name";
        this.firstNameValue.Size = new Size(299, 27);
        this.firstNameValue.TabIndex = 15;
        // 
        // label2
        // 
        this.label2.Location = new Point(-11, 119);
        this.label2.Margin = new Padding(3, 4, 3, 4);
        this.label2.Name = "label2";
        this.label2.Size = new Size(206, 31);
        this.label2.TabIndex = 14;
        this.label2.Text = "Customer First name :";
        this.label2.TextAlign = ContentAlignment.MiddleRight;
        // 
        // label1
        // 
        this.label1.Location = new Point(-11, 73);
        this.label1.Margin = new Padding(3, 4, 3, 4);
        this.label1.Name = "label1";
        this.label1.Size = new Size(206, 31);
        this.label1.TabIndex = 13;
        this.label1.Text = "Customer Last name :";
        this.label1.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lastNameValue
        // 
        this.lastNameValue.Location = new Point(216, 77);
        this.lastNameValue.Margin = new Padding(3, 4, 3, 4);
        this.lastNameValue.Name = "lastNameValue";
        this.lastNameValue.PlaceholderText = "Customer Last name";
        this.lastNameValue.Size = new Size(299, 27);
        this.lastNameValue.TabIndex = 12;
        // 
        // actionButton
        // 
        this.actionButton.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.actionButton.Location = new Point(1271, -13);
        this.actionButton.Margin = new Padding(3, 4, 3, 4);
        this.actionButton.Name = "actionButton";
        this.actionButton.Size = new Size(137, 31);
        this.actionButton.TabIndex = 1;
        this.actionButton.Text = "PLACEHOLDER";
        this.actionButton.UseVisualStyleBackColor = true;
        // 
        // cancelButton
        // 
        this.cancelButton.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.cancelButton.Location = new Point(1415, -13);
        this.cancelButton.Margin = new Padding(3, 4, 3, 4);
        this.cancelButton.Name = "cancelButton";
        this.cancelButton.Size = new Size(86, 31);
        this.cancelButton.TabIndex = 0;
        this.cancelButton.Text = "Cancel";
        this.cancelButton.UseVisualStyleBackColor = true;
        // 
        // bottomBarPanel
        // 
        this.bottomBarPanel.Controls.Add(this.actionBtn);
        this.bottomBarPanel.Controls.Add(this.cancelBtn);
        this.bottomBarPanel.Controls.Add(this.actionButton);
        this.bottomBarPanel.Controls.Add(this.cancelButton);
        this.bottomBarPanel.Dock = DockStyle.Bottom;
        this.bottomBarPanel.Location = new Point(0, 466);
        this.bottomBarPanel.Margin = new Padding(3, 4, 3, 4);
        this.bottomBarPanel.Name = "bottomBarPanel";
        this.bottomBarPanel.Size = new Size(800, 67);
        this.bottomBarPanel.TabIndex = 4;
        // 
        // actionBtn
        // 
        this.actionBtn.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.actionBtn.Location = new Point(518, 23);
        this.actionBtn.Margin = new Padding(3, 4, 3, 4);
        this.actionBtn.Name = "actionBtn";
        this.actionBtn.Size = new Size(137, 31);
        this.actionBtn.TabIndex = 3;
        this.actionBtn.Text = "PLACEHOLDER";
        this.actionBtn.UseVisualStyleBackColor = true;
        this.actionBtn.Click += this.actionBtn_Click;
        // 
        // cancelBtn
        // 
        this.cancelBtn.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.cancelBtn.Location = new Point(677, 23);
        this.cancelBtn.Margin = new Padding(3, 4, 3, 4);
        this.cancelBtn.Name = "cancelBtn";
        this.cancelBtn.Size = new Size(86, 31);
        this.cancelBtn.TabIndex = 2;
        this.cancelBtn.Text = "Cancel";
        this.cancelBtn.UseVisualStyleBackColor = true;
        this.cancelBtn.Click += this.cancelBtn_Click;
        // 
        // openedModeValue
        // 
        this.openedModeValue.AutoSize = true;
        this.openedModeValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.openedModeValue.Location = new Point(71, 12);
        this.openedModeValue.Name = "openedModeValue";
        this.openedModeValue.Size = new Size(90, 20);
        this.openedModeValue.TabIndex = 3;
        this.openedModeValue.Text = "Placeholder";
        // 
        // openedModeLabel
        // 
        this.openedModeLabel.AutoSize = true;
        this.openedModeLabel.Location = new Point(14, 12);
        this.openedModeLabel.Name = "openedModeLabel";
        this.openedModeLabel.Size = new Size(55, 20);
        this.openedModeLabel.TabIndex = 2;
        this.openedModeLabel.Text = "Mode :";
        // 
        // topBarPanel
        // 
        this.topBarPanel.Controls.Add(this.openedModeValue);
        this.topBarPanel.Controls.Add(this.openedModeLabel);
        this.topBarPanel.Dock = DockStyle.Top;
        this.topBarPanel.Location = new Point(0, 0);
        this.topBarPanel.Margin = new Padding(3, 4, 3, 4);
        this.topBarPanel.Name = "topBarPanel";
        this.topBarPanel.Size = new Size(800, 67);
        this.topBarPanel.TabIndex = 3;
        // 
        // CustomerView
        // 
        this.AutoScaleDimensions = new SizeF(8F, 20F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(800, 533);
        this.Controls.Add(this.centerTLP);
        this.Controls.Add(this.bottomBarPanel);
        this.Controls.Add(this.topBarPanel);
        this.Name = "CustomerView";
        this.Text = "Gestion des clients";
        ((System.ComponentModel.ISupportInitialize) this.idValue).EndInit();
        this.centerTLP.ResumeLayout(false);
        this.centerPanel.ResumeLayout(false);
        this.centerPanel.PerformLayout();
        this.bottomBarPanel.ResumeLayout(false);
        this.topBarPanel.ResumeLayout(false);
        this.topBarPanel.PerformLayout();
        this.ResumeLayout(false);
    }

    #endregion

    private DateTimePicker dateDeletedValue;
    private DateTimePicker dateModifiedValue;
    private DateTimePicker dateCreatedValue;
    private Label dateDeletedLabel;
    private Label dateModifiedLabel;
    private Label dateCreatedLabel;
    private TextBox nameValue;
    private Label nameLabel;
    private NumericUpDown idValue;
    private Label idLabel;
    private TableLayoutPanel centerTLP;
    private Panel centerPanel;
    private Button actionButton;
    private Button cancelButton;
    private Panel bottomBarPanel;
    private Label openedModeValue;
    private Label openedModeLabel;
    private Panel topBarPanel;
    private Label label1;
    private TextBox lastNameValue;
    private TextBox firstNameValue;
    private Label label2;
    private Label label4;
    private Label label3;
    private TextBox telephoneValue;
    private TextBox emailValue;
    private Button cancelBtn;
    private Button actionBtn;
}