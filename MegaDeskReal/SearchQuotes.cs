﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDeskReal
{
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void mainMenu_Click(object sender, EventArgs e)
        {
            var mainMenu = new MainMenu();
            mainMenu.Tag = this;
            mainMenu.Show();

            this.Hide();
        }
    }
}
