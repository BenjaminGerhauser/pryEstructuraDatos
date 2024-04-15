using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace EstructuraDatos
{
    class clsListaDoble
    {
        private clsNodo pri;
        private clsNodo ult;

        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }
        public clsNodo Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }

        public void Agregar(clsNodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
                Ultimo = Nuevo;
            }
            else
            {
                if (Nuevo.Codigo <= Primero.Codigo)
                {
                    Nuevo.Siguiente = Primero;
                    Primero.Anterior = Nuevo;
                    Primero = Nuevo;
                }
                else
                {
                    if (Nuevo.Codigo > Ultimo.Codigo)
                    {
                        Ultimo.Siguiente = Nuevo;
                        Nuevo.Anterior = Nuevo;
                        Ultimo = Nuevo;
                    }
                    else
                    {
                        clsNodo ant = Primero;
                        clsNodo aux = Primero;
                        while (aux.Codigo < Nuevo.Codigo && aux != null)
                        {
                            ant = aux;
                            aux = aux.Siguiente;
                            if (aux == null) { break; }
                        }
                        ant.Siguiente = Nuevo;
                        Nuevo.Siguiente = aux;
                        aux.Anterior = Nuevo;
                        Nuevo.Anterior = ant;

                    }
                }
            }
        }
        public void Eliminar(Int32 cod)
        {
            if (cod == Primero.Codigo && Ultimo == Primero)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                if (Primero.Codigo == cod)
                {
                    Primero = Primero.Siguiente;
                    Primero.Anterior = null;
                }
                else
                {
                    if (Ultimo.Codigo == cod)
                    {
                        Ultimo = Ultimo.Anterior;
                        Ultimo.Siguiente = null;
                    }
                    else
                    {
                        clsNodo ant = Primero;
                        clsNodo aux = Primero;
                        while (aux.Codigo < cod)
                        {
                            ant = aux;
                            aux = aux.Siguiente;
                        }
                        ant.Siguiente = aux.Siguiente;
                        aux = aux.Siguiente;
                        aux.Anterior = ant;
                    }
                }
            }
        }
        public void RecorrerDes(DataGridView grilla)
        {
            clsNodo aux = Ultimo;
            grilla.Rows.Clear();
            while (aux != null)
            {
                grilla.Rows.Add(aux.Codigo,aux.Nombre,aux.Tramite);
                aux = aux.Anterior;
            }
        }
        public void RecorrerDes(ListBox lista)
        {
            clsNodo aux = Ultimo;
            lista.Items.Clear();
            while (aux != null)
            {
                lista.Items.Add(aux.Codigo);
                aux = aux.Anterior;
            }
        }
        public void RecorrerDes(ComboBox combo)
        {
            clsNodo aux = Ultimo;
            combo.Items.Clear();
            while (aux != null)
            {
                combo.Items.Add(aux.Codigo);
                aux = aux.Anterior;
            }
        }
        public void RecorrerDes()
        {
            clsNodo aux = Ultimo;
            StreamWriter AD = new StreamWriter("Cola.csv", false, Encoding.UTF8);
            AD.WriteLine("Lista de espera\n");
            AD.WriteLine("Código;Nombre;Trámite");
            while (aux != null)
            {
                AD.Write(aux.Codigo);
                AD.Write(";");
                AD.Write(aux.Nombre);
                AD.Write(";");
                AD.Write(aux.Tramite);
                aux = aux.Anterior;
            }
            AD.Close();
        }
        public void RecorrerAsc(DataGridView Grilla)
        {
            clsNodo aux = Primero;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }
        }
        public void RecorrerAsc(ListBox Lista)
        {
            clsNodo aux = Primero;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }
        }
        public void RecorrerAsc(ComboBox Combo)
        {
            clsNodo aux = Primero;
            Combo.Items.Clear();
            while (aux != null)
            {
                Combo.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }
        }
        public void RecorrerAsc()
        {
            clsNodo aux = Primero;
            StreamWriter AD = new StreamWriter("Cola.csv", false, Encoding.UTF8);
            AD.WriteLine("Lista de espera\n");
            AD.WriteLine("Código;Nombre;Trámite");
            while (aux != null)
            {
                AD.Write(aux.Codigo);
                AD.Write(";");
                AD.Write(aux.Nombre);
                AD.Write(";");
                AD.Write(aux.Tramite);
                aux = aux.Siguiente;
            }
            AD.Close();
        }
    }
}

