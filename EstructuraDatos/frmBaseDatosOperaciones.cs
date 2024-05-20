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
    public partial class frmBaseDatosOperaciones : Form
    {
        public frmBaseDatosOperaciones()
        {
            InitializeComponent();
        }
        clsBaseDatos DB = new clsBaseDatos();
        private void btnProyeccionSimple_Click(object sender, EventArgs e)
        {
            string querySQL = "SELECT Titulo FROM Libro";
             //querySQL = "SELECT Año FROM Libro GROUP BY Año";
            DB.Listar(dataGridView1, querySQL);
        }

        private void btnProyeccionMultiatributo_Click(object sender, EventArgs e)
        {
            string querySQL = "SELECT Titulo,Año FROM Libro";
            DB.Listar(dataGridView1, querySQL);
        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {
            string querySQL = @"SELECT Libro.Titulo, Autor.Nombre
                            FROM Libro
                            INNER JOIN Autor ON Libro.IdAutor = Autor.IdAutor";
            DB.Listar(dataGridView1, querySQL);
        }

        private void btnSeleccionSimple_Click(object sender, EventArgs e)
        {
            string querySQL = "SELECT * FROM Libro WHERE IdIdioma = 2";
            DB.Listar(dataGridView1, querySQL);
        }

        private void btnSeleccionMultiatributo_Click(object sender, EventArgs e)
        {
            string querySQL = "SELECT Titulo,Año,Precio FROM Libro WHERE Precio = 125";
            DB.Listar(dataGridView1, querySQL);
        }

        private void btnSeleccionConvolucion_Click(object sender, EventArgs e)
        {
            string querySQL = @"SELECT * FROM 
                    (SELECT * FROM Libro as T1 WHERE T1.IdIdioma > 5) as T2 WHERE T2.IdAutor > 10";
            DB.Listar(dataGridView1, querySQL);
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            string querySQL = @"SELECT * FROM Libro WHERE IdIdioma = 3
                UNION
                SELECT * FROM Libro WHERE IdIdioma = 4
                UNION
               SELECT * FROM Libro WHERE IdIdioma = 2";
            DB.Listar(dataGridView1,querySQL);
        }

        private void btnInterseccion_Click(object sender, EventArgs e)
        {
            string querySQL = @"SELECT * FROM Libro WHERE IdIdioma
                            IN 
                            (SELECT DISTINCT IdIdioma FROM Libro WHERE IdIdioma < 5)";
            DB.Listar(dataGridView1, querySQL);
        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            string querySQL = @"SELECT * FROM Libro WHERE IdIdioma
                    NOT IN
                    (SELECT DISTINCT IdIdioma FROM Libro WHERE IdIdioma < 5)";
            DB.Listar(dataGridView1, querySQL);
        }
    }
}
