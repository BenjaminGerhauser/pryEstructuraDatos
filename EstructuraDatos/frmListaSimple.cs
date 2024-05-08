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
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }
        clsListaSimple filaDePersonas = new clsListaSimple();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                clsNodo ObjNodo = new clsNodo();
                ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
                ObjNodo.Nombre = txtNombre.Text;
                ObjNodo.Tramite = txtTramite.Text;
                filaDePersonas.Agregar(ObjNodo);
                filaDePersonas.Recorrer(dgvLista);
                filaDePersonas.Recorrer(lstLista);
                filaDePersonas.Recorrer(cboCodigo);
                filaDePersonas.Recorrer();
                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtTramite.Text = "";
            }
            else MessageBox.Show("Ingrese los datos");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (filaDePersonas.Primero != null)
            {
                Int32 x = Convert.ToInt32(cboCodigo.Text);
                filaDePersonas.Eliminar(x);
                filaDePersonas.Recorrer(dgvLista);
                filaDePersonas.Recorrer(lstLista);
                filaDePersonas.Recorrer(cboCodigo);
                filaDePersonas.Recorrer();
            }
        }
        private void cboCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCodigo.Text == ""){btnEliminar.Enabled = false;}
            else { btnEliminar.Enabled = true; }
        }
    }
}
