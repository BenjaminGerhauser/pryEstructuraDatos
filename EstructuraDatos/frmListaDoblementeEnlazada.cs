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
    public partial class frmListaDoblementeEnlazada : Form
    {
        public frmListaDoblementeEnlazada()
        {
            InitializeComponent();
        }
        clsListaDoble filaDePersonas = new clsListaDoble();

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
                    filaDePersonas.RecorrerAsc(dgvLista);
                    filaDePersonas.RecorrerAsc(lstLista);
                    filaDePersonas.RecorrerAsc(cboCodigo);
                    filaDePersonas.RecorrerAsc();
                }
                catch (Exception) { MessageBox.Show("Ingrese un numero"); }
                //ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtTramite.Text = "";
            }
            else MessageBox.Show("Ingrese los datos");
            rbAscendente.Checked = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (filaDePersonas.Primero != null && cboCodigo.SelectedIndex != -1)
            {
                Int32 x = Convert.ToInt32(cboCodigo.Text);
                filaDePersonas.Eliminar(x);
                filaDePersonas.RecorrerAsc(dgvLista);
                filaDePersonas.RecorrerAsc(lstLista);
                filaDePersonas.RecorrerAsc(cboCodigo);
                filaDePersonas.RecorrerAsc();
                rbAscendente.Checked = true;
            }
        }

        private void rbAscendente_CheckedChanged(object sender, EventArgs e)
        {
            filaDePersonas.RecorrerAsc(dgvLista);
            filaDePersonas.RecorrerAsc(lstLista);
            filaDePersonas.RecorrerAsc(cboCodigo);
            filaDePersonas.RecorrerAsc();
        }

        private void rbDescendente_CheckedChanged(object sender, EventArgs e)
        {
            filaDePersonas.RecorrerDes(dgvLista);
            filaDePersonas.RecorrerDes(lstLista);
            filaDePersonas.RecorrerDes(cboCodigo);
            filaDePersonas.RecorrerDes();
        }
    }
}
