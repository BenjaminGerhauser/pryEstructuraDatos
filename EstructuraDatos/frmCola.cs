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
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }

        clsCola filaDePersonas = new clsCola();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();
            if (txtCodigo.Text != "")
            {
                ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
                ObjNodo.Nombre = txtNombre.Text;
                ObjNodo.Tramite = txtTramite.Text;
                filaDePersonas.Agregar(ObjNodo);
                filaDePersonas.Recorrer(dgvCola);
                filaDePersonas.Recorrer(lstCola);
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
                lblCodigo.Text = filaDePersonas.Primero.Codigo.ToString();
                lblNombre.Text = filaDePersonas.Primero.Nombre.ToString();
                lblTramite.Text = filaDePersonas.Primero.Tramite.ToString();
                filaDePersonas.Eliminar();
                filaDePersonas.Recorrer(dgvCola);
                filaDePersonas.Recorrer(lstCola);
                filaDePersonas.Recorrer();
            }
            else
            {
                lblCodigo.Text = "";
                lblTramite.Text = "";
                lblTramite.Text = "";
            }
        }

       
    }
}
