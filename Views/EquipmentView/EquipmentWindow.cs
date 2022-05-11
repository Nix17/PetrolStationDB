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

namespace PetrolStationDB.Views.EquipmentView
{
    public partial class EquipmentWindow : Form
    {
        User mUser = null;
        MainWindow mainWindow = null;
        public EquipmentWindow(User _user, MainWindow _form)
        {
            mUser = _user;
            mainWindow = _form;
            InitializeComponent();
        }
    }
}
