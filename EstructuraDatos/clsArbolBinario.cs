using System;
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
        public clsNodo Raiz
        {
            get { return primerNodo; }
            set { primerNodo = value; }
        }
        public void Agregar(clsNodo Nuevo)
        {
            Nuevo.Izquierdo = null;
            Nuevo.Derecho = null;
            if (Raiz == null)
            {
                Raiz = Nuevo;
            }
            else
            {
                clsNodo Aux = Raiz;
                clsNodo Padre = Raiz;
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
        public void Recorrer(TreeView Tree)
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
    }
}
