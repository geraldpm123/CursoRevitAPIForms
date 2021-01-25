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
    public partial class formulario4 : Form
    {
        public formulario4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            treeCategorias.Nodes.Add(txtNodo.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            treeCategorias.SelectedNode.Nodes.Add(txtElemento.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            treeCategorias.Nodes.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            treeCategorias.Nodes.Remove(treeCategorias.SelectedNode);
        }
    }
}
