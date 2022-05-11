using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetrolStationDB.Database;
using PetrolStationDB.Database.Models;
using PetrolStationDB.Controllers;
using PetrolStationDB.Views.Profile;
using PetrolStationDB.Views.PetrolStationTypeView;
using PetrolStationDB.Views.PetrolStationView;
using PetrolStationDB.Views.EmployeesView;
using PetrolStationDB.Views.EquipmentView;
using PetrolStationDB.Views.MaterialLiabilityView;
using PetrolStationDB.Views.StructureView;

namespace PetrolStationDB.Views
{
    public partial class MainWindow : Form
    {
        User mUser = null;
        authForm aForm = null;
        PetrolStationController psCtrl;
        public MainWindow(User _user, authForm _from)
        {
            mUser = _user;
            aForm = _from;
            psCtrl = new PetrolStationController();
            InitializeComponent();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = "Вы уверены, что хотите выйти?";
            if (MessageBox.Show(message, "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                if (aForm != null)
                {
                    aForm.Show();
                }
                this.Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            ProfileWindow profWindow = new ProfileWindow(mUser);
            profWindow.Show();
        }

        private void typePsBtn_Click(object sender, EventArgs e)
        {
            PetrolStationTypeWindow psTypeWindow = new PetrolStationTypeWindow(mUser, this);
            psTypeWindow.Show();
        }

        private void addPsBtn_Click(object sender, EventArgs e)
        {
            PetrolStationWindow psWindow = new PetrolStationWindow(mUser, this);
            psWindow.Show();
        }

        private void EmployeesBtn_Click(object sender, EventArgs e)
        {
            EmployeesWindow employeesWindow = new EmployeesWindow(mUser, this);
            employeesWindow.Show();
        }

        private void structuresBtn_Click(object sender, EventArgs e)
        {
            StructureWindow structureWindow = new StructureWindow(mUser, this);
            structureWindow.Show();
        }

        private void equipmentsBtn_Click(object sender, EventArgs e)
        {
            EquipmentWindow equipmentWindow = new EquipmentWindow(mUser, this);
            equipmentWindow.Show();
        }

        private void materialLiabilityBtn_Click(object sender, EventArgs e)
        {
            MaterialLiabilityWindow materialLiabilityWindow = new MaterialLiabilityWindow(mUser, this);
            materialLiabilityWindow.Show();
        }
    }
}
