﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Together_Culture__Dream_Team_.Front_End.User_Controls
{
    public partial class RecentEmailsWindow : UserControl
    {

        private static RecentEmailsWindow _instance;
        public static RecentEmailsWindow Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new RecentEmailsWindow();
                return _instance;

            }
        }
        public RecentEmailsWindow()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }
    }
}
