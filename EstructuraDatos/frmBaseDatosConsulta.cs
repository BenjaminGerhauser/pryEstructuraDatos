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
    public partial class frmBaseDatosConsulta : Form
    {
        public frmBaseDatosConsulta()
        {
            InitializeComponent();
        }
        clsBaseDatos baseDatos;
        private void btnListar_Click(object sender, EventArgs e)
        {
            baseDatos = new clsBaseDatos();
            string querySQL = txtConsulta.Text;
            baseDatos.Listar(dataGridView1,querySQL);
        }
    }
}
