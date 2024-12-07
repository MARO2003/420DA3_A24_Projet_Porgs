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
        this.BottomBarPanel = new Panel();
        this.centerTblLayoutPanel = new TableLayoutPanel();
        this.btnCancel = new Button();
        this.btnAction = new Button();
        this.centerPanel = new Panel();
        this.idLabel = new Label();
        this.idValue = new NumericUpDown();
        this.BottomBarPanel.SuspendLayout();
        this.centerTblLayoutPanel.SuspendLayout();
        this.centerPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) this.idValue).BeginInit();
        this.SuspendLayout();
        // 
        // topBarPanel
        // 
        this.topBarPanel.Dock = DockStyle.Top;
        this.topBarPanel.Location = new Point(0, 0);
        this.topBarPanel.Name = "topBarPanel";
        this.topBarPanel.Size = new Size(800, 50);
        this.topBarPanel.TabIndex = 0;
        // 
        // BottomBarPanel
        // 
        this.BottomBarPanel.Controls.Add(this.btnAction);
        this.BottomBarPanel.Controls.Add(this.btnCancel);
        this.BottomBarPanel.Dock = DockStyle.Bottom;
        this.BottomBarPanel.Location = new Point(0, 403);
        this.BottomBarPanel.Name = "BottomBarPanel";
        this.BottomBarPanel.Size = new Size(800, 50);
        this.BottomBarPanel.TabIndex = 1;
        // 
        // centerTblLayoutPanel
        // 
        this.centerTblLayoutPanel.ColumnCount = 3;
        this.centerTblLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.centerTblLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 400F));
        this.centerTblLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.centerTblLayoutPanel.Controls.Add(this.centerPanel, 1, 0);
        this.centerTblLayoutPanel.Dock = DockStyle.Fill;
        this.centerTblLayoutPanel.Location = new Point(0, 50);
        this.centerTblLayoutPanel.Name = "centerTblLayoutPanel";
        this.centerTblLayoutPanel.RowCount = 1;
        this.centerTblLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.centerTblLayoutPanel.Size = new Size(800, 353);
        this.centerTblLayoutPanel.TabIndex = 2;
        // 
        // btnCancel
        // 
        this.btnCancel.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.btnCancel.Location = new Point(694, 9);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new Size(94, 29);
        this.btnCancel.TabIndex = 0;
        this.btnCancel.Text = "Annuler";
        this.btnCancel.UseVisualStyleBackColor = true;
        // 
        // btnAction
        // 
        this.btnAction.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.btnAction.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.btnAction.Location = new Point(477, 9);
        this.btnAction.Name = "btnAction";
        this.btnAction.Size = new Size(211, 29);
        this.btnAction.TabIndex = 1;
        this.btnAction.Text = "Action";
        this.btnAction.UseVisualStyleBackColor = true;
        // 
        // centerPanel
        // 
        this.centerPanel.Controls.Add(this.idValue);
        this.centerPanel.Controls.Add(this.idLabel);
        this.centerPanel.Dock = DockStyle.Fill;
        this.centerPanel.Location = new Point(203, 3);
        this.centerPanel.Name = "centerPanel";
        this.centerPanel.Size = new Size(394, 347);
        this.centerPanel.TabIndex = 0;
        // 
        // idLabel
        // 
        this.idLabel.Location = new Point(3, 18);
        this.idLabel.Name = "idLabel";
        this.idLabel.Size = new Size(180, 24);
        this.idLabel.TabIndex = 0;
        this.idLabel.Text = "ID :";
        this.idLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // idValue
        // 
        this.idValue.Enabled = false;
        this.idValue.Location = new Point(215, 18);
        this.idValue.Maximum = new decimal(new int[] { 658067456, 1164, 0, 0 });
        this.idValue.Name = "idValue";
        this.idValue.Size = new Size(162, 27);
        this.idValue.TabIndex = 1;
        // 
        // SupplierView
        // 
        this.AutoScaleDimensions = new SizeF(8F, 20F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(800, 453);
        this.Controls.Add(this.centerTblLayoutPanel);
        this.Controls.Add(this.BottomBarPanel);
        this.Controls.Add(this.topBarPanel);
        this.MinimumSize = new Size(500, 500);
        this.Name = "SupplierView";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Gestion des Fournisseurs";
        this.Load += this.SupplierView_Load;
        this.BottomBarPanel.ResumeLayout(false);
        this.centerTblLayoutPanel.ResumeLayout(false);
        this.centerPanel.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize) this.idValue).EndInit();
        this.ResumeLayout(false);
    }

    #endregion

    private Panel topBarPanel;
    private Panel BottomBarPanel;
    private TableLayoutPanel centerTblLayoutPanel;
    private Button btnCancel;
    private Button btnAction;
    private Panel centerPanel;
    private Label idLabel;
    private NumericUpDown idValue;
}