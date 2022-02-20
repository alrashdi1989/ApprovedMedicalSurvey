﻿using ApprovedMedicalSurvey.Models;
using ApprovedMedicalSurvey.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApprovedMedicalSurvey.UI
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

       
        private void Users_Load(object sender, EventArgs e)
        {
            FillingTheGridWithData();

        }

      
        private void FillingTheGridWithData()
        {
          usersBindingSource.DataSource=  UserServices.GetAllUsers("users");
        }
    }
}
