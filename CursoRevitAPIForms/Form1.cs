using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoRevitAPIForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Convert.ToDouble(txtEdad.Text);
            MessageBox.Show("Hola " + txtNombre.Text + " " + txtApellidos.Text);
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFrm2_Click(object sender, EventArgs e)
        {
            formulario2 frm = new formulario2();
            frm.ShowDialog();
        }

        private void btnformulario3_Click(object sender, EventArgs e)
        {
            formulario3 frm = new formulario3();
            frm.ShowDialog();
        }

        private void btnFormulario4_Click(object sender, EventArgs e)
        {
            formulario4 frm = new formulario4();
            frm.ShowDialog();
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            /*
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "FamiliaRevit (*.rvt)|*.rvt";

            if (open.ShowDialog() == DialogResult.OK)
            {
                txtRuta.Text = open.FileName;

            }
            */

            SaveFileDialog open = new SaveFileDialog();
            open.Filter = "FamiliaRevit (*.rvt)|*.rvt";
            open.FileName = "Archivo de Prueba";
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtRuta.Text = open.FileName;

            }
        }
    }
}
