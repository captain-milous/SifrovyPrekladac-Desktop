﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SifrovyPrekladac.src.forms
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void PrekladBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrekladForm form = new PrekladForm();
            form.ShowDialog();
            this.Close();
        }
    }
}
