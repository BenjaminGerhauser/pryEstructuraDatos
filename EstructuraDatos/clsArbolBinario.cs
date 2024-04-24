﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EstructuraDatos
{
    class clsArbolBinario
    {
        private clsNodo primerNodo;
        private clsNodo[] Vector = new clsNodo[100];
        private Int32 i = 0;
        public clsNodo Raiz
        {
            get { return primerNodo; }
            set { primerNodo = value; }
        }
        public void Agregar(clsNodo Nuevo)
        {
            //Nuevo.Izquierdo = null;
            //Nuevo.Derecho = null;
            if (Raiz == null)
            {
                Raiz = Nuevo;
            }
            else
            {
                clsNodo Padre = Raiz;
                clsNodo Aux = Raiz;
                while (Aux != null)
                {
                    Padre = Aux;
                    if (Nuevo.Codigo < Aux.Codigo)
                    {
                        Aux = Aux.Izquierdo;           
                    }
                    else
                    {
                        Aux = Aux.Derecho;
                    }
                }
                if (Nuevo.Codigo < Padre.Codigo)
                {
                    Padre.Izquierdo = Nuevo;
                }
                else
                {
                    Padre.Derecho = Nuevo;
                }
            }
        } 
        public void Recorrer(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla,Raiz);
        }
        private void InOrdenAsc(DataGridView Grilla,clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(Grilla,R.Izquierdo);
            Grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite); 
            if (R.Derecho != null) InOrdenAsc(Grilla,R.Derecho);
        }
        public void Recorrer(ListBox Lista)
        {
            Lista.Items.Clear();
            InOrdenAsc(Lista, Raiz);
        }
        private void InOrdenAsc(ListBox Lista, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(Lista, R.Izquierdo);
            Lista.Items.Add(R.Codigo);
            if (R.Derecho != null) InOrdenAsc(Lista, R.Derecho);
        }
        public void Recorrer(ComboBox Combo)
        {
            Combo.Items.Clear();
            InOrdenAsc(Combo, Raiz);
        }
        private void InOrdenAsc(ComboBox Combo, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(Combo, R.Izquierdo);
            Combo.Items.Add(R.Codigo);
            if (R.Derecho != null) InOrdenAsc(Combo, R.Derecho);
        }
        public void RecorrerPre(TreeView Tree)
        {
            Tree.Nodes.Clear();
            TreeNode NodoPadre = new TreeNode("Árbol");
            Tree.Nodes.Add(NodoPadre);
            PreOrden(Raiz,NodoPadre);
            Tree.ExpandAll();
        }
        private void PreOrden(clsNodo R,TreeNode nodoTreeView)
        {
            TreeNode nodoPadre = new TreeNode(R.Codigo.ToString());
            nodoTreeView.Nodes.Add(nodoPadre);
            if (R.Izquierdo != null) PreOrden(R.Izquierdo, nodoPadre);
            if (R.Derecho != null) PreOrden(R.Derecho, nodoPadre);
        }
        public void RecorrerPre(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PreOrden(Raiz,Grilla);
        }
        private void PreOrden(clsNodo R, DataGridView Grilla)
        {
            Grilla.Rows.Add(R.Codigo,R.Nombre,R.Tramite);
            if (R.Izquierdo != null) PreOrden(R.Izquierdo, Grilla);
            if (R.Derecho != null) PreOrden(R.Derecho, Grilla);
        }
        public void BuscarCodigo(Int32 cod)
        {
            clsNodo Aux = Raiz;
            while (Aux != null)
            {
                if (cod == Aux.Codigo) break;
                if (cod < Aux.Codigo) Aux = Aux.Izquierdo;
                else Aux = Aux.Derecho;
            }
            return Aux;
        }
        public void Equilibrar()
        {
            i = 0;
            GrabarVectorInOrden(Raiz);
            Raiz = null;
            EquilibrarArbol(0, i - 1);
        }
        private void GrabarVectorInOrden(clsNodo NodoPadre)
        {
            if (NodoPadre.Izquierdo != null) GrabarVectorInOrden(NodoPadre.Izquierdo);
            Vector[i] = NodoPadre;
            i = i + 1;
            if (NodoPadre.Derecho != null) GrabarVectorInOrden(NodoPadre.Derecho);
        }
        private void EquilibrarArbol(Int32 ini,Int32 fin)
        {
            Int32 m = (ini + fin) / 2;
            if (ini <= fin)
            {
                Agregar(Vector[m]);
                EquilibrarArbol(ini,m-1);
                EquilibrarArbol(m + 1, fin);
            }
        }
        public void Eliminar(Int32 codigo)
        {
            i = 0;
            GrabarVectorInOrden(Raiz,codigo);
            Raiz = null;
            EquilibrarArbol(0, i - 1);
        }
        private void GrabarVectorInOrden(clsNodo NodoPadre,Int32 Codigo)
        {
            if (NodoPadre.Izquierdo != null) GrabarVectorInOrden(NodoPadre.Izquierdo, Codigo);
            if (NodoPadre.Codigo != Codigo) Vector[i] = NodoPadre;i = i + 1;
            if (NodoPadre.Derecho != null) GrabarVectorInOrden(NodoPadre.Derecho, Codigo);
        }

    }
}
