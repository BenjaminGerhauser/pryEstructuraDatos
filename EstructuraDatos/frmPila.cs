﻿using System;
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
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            ObjNodo.Nombre = txtNombre.Text;
            ObjNodo.Tramite = txtTramite.Text;
            filaDePersonas.Agregar(ObjNodo);
            filaDePersonas.Recorrer(dgvPila);
            filaDePersonas.Recorrer(lstPila);
            filaDePersonas.Recorrer();
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
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
