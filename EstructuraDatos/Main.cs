using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraDatos
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void datosDeDesarrolladorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatosDesarrolados datos = new DatosDesarrolados();
            datos.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
