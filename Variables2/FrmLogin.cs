using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Windows.Forms;

namespace Variables2
{
    public partial class FrmLogin : Form
    {
        private int intentosFallidos = 0;
        public FrmLogin()
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
            if (Login(tbUsuario.Text, tbPassword.Text))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
                //new Form1().Show();
                //this.Hide();
            }
            else
            {
                intentosFallidos++;
                if (intentosFallidos >= 3)
                {
                    MessageBox.Show("Demasiado intentos fallidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Application.Exit();
                }
                else
                {

                    MessageBox.Show("Usario o contraseña  incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    tbPassword.Clear();
                    tbPassword.Focus();
                }
            }
        }
                
                
                
                
        private Boolean Login(String Username, String password)
        {
            return Username.Equals("admin") && password.Equals("admin");
        }
    }
}

