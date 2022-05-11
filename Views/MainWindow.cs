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

namespace PetrolStationDB.Views
{
    public partial class MainWindow : Form
    {
        User mUser = null;
        authForm aForm = null;
        public MainWindow(User _user, authForm _from)
        {
            mUser = _user;
            aForm = _from;
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
            //MessageBox.Show(mUser.Login);
        }
    }
}
