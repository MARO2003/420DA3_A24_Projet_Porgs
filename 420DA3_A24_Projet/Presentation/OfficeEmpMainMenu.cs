﻿using _420DA3_A24_Projet.Business;

namespace _420DA3_A24_Projet.Presentation;
internal partial class OfficeEmpMainMenu : Form {

    private ProjectApplication parentApp;
    public OfficeEmpMainMenu(ProjectApplication application) {
        this.parentApp = application;
        this.InitializeComponent();
    }

    public DialogResult ShowOfficeEmpMainMenu() {
        return this.ShowDialog();
    }
}
