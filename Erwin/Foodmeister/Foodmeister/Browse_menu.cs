﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodmeister
{
    public partial class Browse_menu : Form
    {
        public Browse_menu()
        {
            InitializeComponent();
        }

        private void Browse_menu_Load(object sender, EventArgs e)
        {

        }

        private void Browse_Click(object sender, EventArgs e)
        {
            
        }

        private void Bookmarks_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form currentmenu = new Bookmarks_menu();
            currentmenu.Show();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form currentmenu = new Logout_menu();
            currentmenu.Show();
        }
    }
}
