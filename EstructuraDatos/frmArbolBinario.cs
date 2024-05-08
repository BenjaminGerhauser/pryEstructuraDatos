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
            if (txtCodigo.Text != "")
            {
                clsNodo Nuevo = new clsNodo();
                try 
                { 
                    Nuevo.Codigo = Convert.ToInt32(txtCodigo.Text); 
                    Arbol.Agregar(Nuevo);
                    Arbol.Recorrer(Grilla);
                    Arbol.Recorrer(cboCodigo);
                    Arbol.RecorrerPre(treeView1);
                    Arbol.Recorrer();
                }
                catch (Exception) { MessageBox.Show("Ingrese un numero"); }
                Nuevo.Tramite = txtTramite.Text;
                Nuevo.Nombre = txtNombre.Text;
                //Nuevo.Codigo = Convert.ToInt32(txtCodigo.Text);
            }
            else MessageBox.Show("Ingrese los datos");
            txtCodigo.Text = "";
            txtTramite.Text = "";
            txtNombre.Text = "";
            rbInOrden.Checked = true;

        }

        private void rbInOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (Arbol.Raiz != null)
            {
                Arbol.Recorrer(Grilla);
                Arbol.Recorrer(cboCodigo);
                Arbol.Recorrer();
            }   
        }
        private void rbInOrdenDesc_CheckedChanged(object sender, EventArgs e)
        {
            if (Arbol.Raiz != null)
            {
                Arbol.RecorrerDesc(Grilla);
                Arbol.RecorrerDesc(cboCodigo);
                Arbol.RecorrerDesc();
            }
        }
        private void rbPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (Arbol.Raiz != null)
            {
                Arbol.RecorrerPre(Grilla);
                Arbol.RecorrerPre(cboCodigo);
                Arbol.RecorrerPre();
            }
        }
        private void rbPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (Arbol.Raiz != null)
            {
                Arbol.RecorrerPost(Grilla);
                Arbol.RecorrerPost(cboCodigo);
                Arbol.RecorrerPost();
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cboCodigo.SelectedIndex != -1)
            {
                Arbol.Eliminar(Convert.ToInt32(cboCodigo.Text));
                if (Arbol.Raiz == null) { cboCodigo.Items.Clear(); Grilla.Rows.Clear(); treeView1.Nodes.Clear(); }
                else
                {
                    
                    Arbol.Recorrer(Grilla);
                    Arbol.RecorrerPre(treeView1);
                    Arbol.Recorrer(cboCodigo);
                    Arbol.Recorrer();
                }
            }
            txtCodigo.Text = "";
            txtTramite.Text = "";
            txtNombre.Text = "";
            rbInOrden.Checked = true;
        }
        private void btnEquilibrar_Click(object sender, EventArgs e)
        {
            
            Arbol.Equilibrar();
            Arbol.Recorrer(Grilla);
            Arbol.RecorrerPre(treeView1);
            Arbol.Recorrer(cboCodigo);
            rbInOrden.Checked = true;
        }

    }
}
