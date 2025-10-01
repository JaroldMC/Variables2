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
                    Arreglo.edad[Arreglo.pos++] = edad;
                else MessageBox.Show("No se pueden agregar más elementos", "Arreglo lleno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                llenarListado();


        }
        public void llenarListado()
        {
            lbEdades.DataSource = null;
            lbEdades.DataSource = Arreglo.edad;
            lbEdades.Refresh();
            gbEdades.Text = "Edades: " + Arreglo.edad.Length;
            tbEdades.Text = "";
            tbEdades.Focus();
        }

        private void gbEdades_Enter(object sender, EventArgs e)
        {

        }
    }
}
