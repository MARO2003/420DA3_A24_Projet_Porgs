using _420DA3_A24_Projet.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _420DA3_A24_Projet.Presentation;
internal partial class MainMenu : Form {
    private ProjectApplication parentApp;
    public MainMenu(ProjectApplication app) {
        InitializeComponent();
        this.parentApp = app;
    }

    private void MainMenu_Load(object sender, EventArgs e) {

    }
}
