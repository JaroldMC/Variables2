using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Windows.Forms;

namespace Variables2
{
    public partial class pdfloyal : Form
    {
        public pdfloyal()
        {
            InitializeComponent();
        }

        private void lblUser_Click(object sender, EventArgs e)
        {
            tbPassword.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Login(tbUsuario.Text, tbPassword.Text));
            new Form1().Show();
            this.Hide();
        }

        private Boolean Login(String Username, String password)
        {
            return Username.Equals("admin") && password.Equals("admin");
    }
    }
}

