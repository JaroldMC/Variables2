using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Variables2.Modelos;

namespace Variables2.Formularios
{
    public partial class FrmArreglo : Form
    {
        public FrmArreglo()
        {
            InitializeComponent();
        }

        private void lblPromedio_Click(object sender, EventArgs e)
        {
           
        }

        private void tbEdades_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int edad = int.Parse(tbEdades.Text);
                if (Arreglo.pos <= 10)
                    Arreglo.edades[Arreglo.pos++] = edad;
                else MessageBox.Show("No se pueden agregar más elementos", "Arreglo lleno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                llenarListado();
                MostrarCalculos();

            }
        }


        
        public void llenarListado()
        {
            lbEdades.DataSource = null;
            lbEdades.DataSource = Arreglo.edades;
            lbEdades.Refresh();
            gbEdades.Text = "Edades: " + Arreglo.edades.Length;
            tbEdades.Text = "";
            tbEdades.Focus();
        }

        private void gbEdades_Enter(object sender, EventArgs e)
        {

        }

        public void MostrarCalculos()
        {
            lblPromedio.Text = "Promedio:" + Arreglo.GetPromedio();
            lblMayor.Text = "Mayor: " + Arreglo.GetEdadMaxima();
            lblMenor.Text = "Menor: " + Arreglo.GetedadMinima();
            lblMayoresDeEdad.Text = "Mayor de edad:" + Arreglo.GetMayorEdad();
            lblMenorDeEdad.Text = "Menor de edad: " + Arreglo.GetMenorDeEdad();
        }

        private void lblMayor_Click(object sender, EventArgs e)
        {

        }

        private void lblMenor_Click(object sender, EventArgs e)
        {

        }

        private void lblMayoresDeEdad_Click(object sender, EventArgs e)
        {

        }
    }
}
