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
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }

        clsPila filaDePersonas = new clsPila();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                clsNodo ObjNodo = new clsNodo();
                try
                {
                    ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text); 
                    ObjNodo.Nombre = txtNombre.Text;
                    ObjNodo.Tramite = txtTramite.Text;
                    filaDePersonas.Agregar(ObjNodo);
                    filaDePersonas.Recorrer(dgvPila);
                    filaDePersonas.Recorrer(lstPila);
                    filaDePersonas.Recorrer();
                }
                catch (Exception) { MessageBox.Show("Ingrese un numero"); }
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
                filaDePersonas.Recorrer(dgvPila);
                filaDePersonas.Recorrer(lstPila);
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
