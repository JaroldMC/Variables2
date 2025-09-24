using System;
using Variables2.Modelos;
using System.Windows.Forms;

namespace Variables2
{
    public partial class Form1 : Form
    {
        Facultad fac = new Facultad();
     
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            Facultad fia = new Facultad();
            fia.Codigo = tbCodigo.Text;
            fia.Nombre = tbNombre.Text;

            lblVariableLocal.Text = fia.MostrarDatos();
            fac = fia;

        }

        private void btnVerificarG_Click(object sender, EventArgs e)
        {
            lblVariableGlobal.Text = fac.MostrarDatos();
        }
    }
}
