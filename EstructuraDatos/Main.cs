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

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCola cola = new frmCola();
            cola.Show();
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPila pila = new frmPila();
            pila.Show();
        }

        private void listaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaSimple listaSimple = new frmListaSimple();
            listaSimple.Show();
        }

        private void listaDobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaDoblementeEnlazada listaDoble = new frmListaDoblementeEnlazada();
            listaDoble.Show();
        }

        private void arbolBinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArbolBinario arbol = new frmArbolBinario();
            arbol.Show();
        }

        private void operacionesConTablasDeDeBasesDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaseDatosOperaciones operaciones = new frmBaseDatosOperaciones();
            operaciones.ShowDialog();
        }

        private void consultaEnLaBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaseDatosConsulta consulta = new frmBaseDatosConsulta();
            consulta.ShowDialog();
        }

        private void repasoDeOperacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaseDatosRepasoOperaciones repaso = new frmBaseDatosRepasoOperaciones();
            repaso.ShowDialog();
        }
    }
}
