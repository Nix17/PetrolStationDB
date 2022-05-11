﻿using System;
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

namespace PetrolStationDB.Views.EmployeesView
{
    public partial class EmployeesWindow : Form
    {
        User mUser = null;
        MainWindow mainWindow = null;
        public EmployeesWindow(User _user, MainWindow _form)
        {
            mUser = _user;
            mainWindow = _form;
            InitializeComponent();
        }
    }
}
