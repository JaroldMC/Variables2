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
           int edad = int.Parse(tbEdades.Text);
            Arreglo.edad[Arreglo.pos] = edad;


        }
        public void llenarListado()
        {
            lbEdades.Items.Clear();
            lbEdades.DataSource = Arreglo.edad;
            lbEdades.Refresh();
            gbEdades text = "Edades: " + Arreglo.edad.Length;
            tbEdades.Text = "";
            tbEdades.Focus();
        }
    }
}
