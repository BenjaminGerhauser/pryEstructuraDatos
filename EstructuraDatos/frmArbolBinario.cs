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
    public partial class frmArbolBinario : Form
    {
        public frmArbolBinario()
        {
            InitializeComponent();
        }
        clsArbolBinario Arbol = new clsArbolBinario();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo Nuevo = new clsNodo();
            Nuevo.Tramite = txtTramite.Text;
            Nuevo.Nombre = txtNombre.Text;
            Nuevo.Codigo = Convert.ToInt32(txtCodigo.Text);
            Arbol.Agregar(Nuevo);
            Arbol.Recorrer(dgvLista);
            //Arbol.Recorrer(cboCodigo);
            //Arbol.Recorrer(treeView1);
        }

        private void rbInOrden_CheckedChanged(object sender, EventArgs e)
        {
            //Arbol.Recorrer(dgvLista);
        }

        private void rbPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            Arbol.RecorrerPre(dgvLista);
            Arbol.RecorrerPre(treeView1);
        }
    }
}
