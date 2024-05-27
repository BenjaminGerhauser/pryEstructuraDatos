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
    public partial class frmBaseDatosRepasoOperaciones : Form
    {
        public frmBaseDatosRepasoOperaciones()
        {
            InitializeComponent();
        }
        clsBaseDatos db = new clsBaseDatos();
        private void btnListar_Click(object sender, EventArgs e)
        {
            string sql = "";
            switch (cboSQL.SelectedIndex)
            {
                case 0:
                    sql = "SELECT Titulo FROM Libro";
                    db.Listar(Grilla,sql);
                    break;
                case 1:
                    sql = "SELECT Nombre FROM Idioma";
                    db.Listar(Grilla, sql);

                    break;
                case 2:
                    sql = "SELECT Titulo,Año FROM Libro WHERE Precio < 800";
                    db.Listar(Grilla, sql);

                    break;
                case 3:
                    sql = "SELECT IdAutor,Nombre FROM Autor WHERE IdAutor < 10";
                    db.Listar(Grilla,sql);

                    break;
                case 4:
                    sql = @"SELECT Libro.Titulo, Autor.Nombre
                        FROM Libro
                        INNER JOIN Autor ON Libro.IdAutor = Autor.IdAutor";
                    db.Listar(Grilla, sql);

                    break;
                case 5:
                    sql = @"SELECT Libro.Titulo, Idioma.Nombre
                        FROM Libro
                        INNER JOIN Idioma ON Libro.IdIdioma = Idioma.IdIdioma";
                    db.Listar(Grilla, sql);

                    break;
                case 6:
                    sql = "SELECT * FROM Libro WHERE IdIdioma = 2";
                    db.Listar(Grilla, sql);

                    break;
                case 7:
                    sql = "SELECT * FROM Pais";
                    db.Listar(Grilla, sql);

                    break;
                case 8:
                    sql = "SELECT Titulo,Año,Precio FROM Libro WHERE Precio = 125";
                    db.Listar(Grilla, sql);

                    break;
                case 9:
                    sql = "SELECT Titulo,Año,Precio FROM Libro WHERE Precio> 800";
                    db.Listar(Grilla, sql);

                    break;
                case 10:
                    sql = @"SELECT * FROM 
                    (SELECT * FROM Libro as T1 WHERE T1.IdIdioma > 5) as T2 WHERE T2.IdAutor > 10";
                    db.Listar(Grilla, sql);

                    break;
                case 11:
                    sql = @"SELECT * FROM 
                    (SELECT * FROM Libro as T1 WHERE T1.Precio > 300) as T2 WHERE T2.IdIdioma > 3";
                    db.Listar(Grilla, sql);

                    break;
                case 12:
                    sql = @"SELECT * FROM Libro WHERE IdIdioma = 3
                        UNION
                        SELECT * FROM Libro WHERE IdIdioma = 4
                        UNION
                        SELECT * FROM Libro WHERE IdIdioma = 2";
                    db.Listar(Grilla, sql);

                    break;
                case 13:
                    sql = @"SELECT * FROM Libro WHERE Precio = 125
                        UNION
                        SELECT * FROM Libro WHERE Precio = 854
                        UNION
                        SELECT * FROM Libro WHERE Precio = 789";
                    db.Listar(Grilla, sql);

                    break;
                case 14:
                    sql = @"SELECT * FROM Libro WHERE IdIdioma
                            IN 
                            (SELECT DISTINCT IdIdioma FROM Libro WHERE IdIdioma < 5)";
                    db.Listar(Grilla, sql);

                    break;
                case 15:
                    sql = @"SELECT * FROM Libro WHERE IdAutor
                            IN 
                            (SELECT DISTINCT IdAutor FROM Libro WHERE IdAutor > 70)";
                    db.Listar(Grilla, sql);

                    break;
                case 16:
                    sql = @"SELECT * FROM Libro WHERE IdIdioma
                    NOT IN
                    (SELECT DISTINCT IdIdioma FROM Libro WHERE IdIdioma < 5)";
                    db.Listar(Grilla, sql);

                    break;
                case 17:
                    sql = @"SELECT * FROM Libro WHERE IdAutor
                    NOT IN
                    (SELECT DISTINCT IdAutor FROM Libro WHERE IdAutor > 50)";
                    db.Listar(Grilla, sql);

                    break;
                case 18:
                    sql = "SELECT Nombre FROM Idioma";
                    db.Listar(Grilla, sql);

                    break;
                case 19:
                    sql = "SELECT Nombre FROM Autor";
                    db.Listar(Grilla, sql);

                    break;
            }
        }
    }
}
