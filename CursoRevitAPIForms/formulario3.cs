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
    public partial class formulario3 : Form
    {
        public formulario3()
        {
            InitializeComponent();

        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            //Adicionar nuevo reglon
            int n = dgvElementos.Rows.Add();
            //Colocar la informacion
            dgvElementos.Rows[n].Cells[0].Value = txtId.Text;
            dgvElementos.Rows[n].Cells[1].Value = txtNombre.Text;
            dgvElementos.Rows[n].Cells[2].Value = txtLongitud.Text;
        }
    }
}
