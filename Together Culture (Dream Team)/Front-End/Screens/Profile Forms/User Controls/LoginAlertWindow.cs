﻿using Together_Culture__Dream_Team_.Front_End.Src.User_Controls;

namespace Together_Culture__Dream_Team_.Front_End.User_Controls
{
    public partial class LoginAlertWindow : UserControl
    {
        public LoginAlertWindow()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserControlSecurity.panel.Hide();
        }
    }
}
