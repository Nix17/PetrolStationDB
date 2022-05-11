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

namespace PetrolStationDB.Views.StructureView
{
    public partial class StructureWindow : Form
    {
        User mUser = null;
        MainWindow mainWindow = null;
        public StructureWindow(User _user, MainWindow _form)
        {
            mainWindow = _form;
            mUser = _user;
            InitializeComponent();
        }
    }
}
