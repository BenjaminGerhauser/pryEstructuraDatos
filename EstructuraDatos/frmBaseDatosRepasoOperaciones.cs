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
                    db.Listar(Grilla, sql);
                    lblDescripcion.Text = "Proyeccion Simple: \n Seleccion de los titulos de libros";
                    break;
                case 1:
                    sql = "SELECT Nombre FROM Idioma";
                    db.Listar(Grilla, sql);
                    lblDescripcion.Text = "Proyeccion Simple: \n Seleccion del nombre de los idiomas";
                    break;
                case 2:
                    sql = "SELECT Titulo,Año FROM Libro WHERE Precio < 800";
                    db.Listar(Grilla, sql);
                    lblDescripcion.Text = "Proyeccion Multiatributo: \n Seleccion de titulo y año de libros, cuando el precio sea menor a 800";
                    break;
                case 3:
                    sql = "SELECT IdAutor,Nombre FROM Autor WHERE IdAutor < 10";
                    db.Listar(Grilla,sql);
                    lblDescripcion.Text = "Proyeccion Multiatributo: \n Seleccion de idAutor y nombre de autores, cuando el idAutor sea menor a 10";
                    break;
                case 4:
                    sql = @"SELECT Libro.Titulo, Autor.Nombre
                        FROM Libro
                        INNER JOIN Autor ON Libro.IdAutor = Autor.IdAutor";
                    db.Listar(Grilla, sql);
                    lblDescripcion.Text = "Juntar: \n Seleccion del titulo de los libros y el nombre de su autor";
                    break;
                case 5:
                    sql = @"SELECT Libro.Titulo, Idioma.Nombre
                        FROM Libro
                        INNER JOIN Idioma ON Libro.IdIdioma = Idioma.IdIdioma";
                    db.Listar(Grilla, sql);
                    lblDescripcion.Text = "Juntar: \n Seleccion del titulo de los libros y el idioma correspondiente";
                    break;
                case 6:
                    sql = "SELECT * FROM Libro WHERE IdIdioma = 2";
                    db.Listar(Grilla, sql);
                    lblDescripcion.Text = "Seleccion Simple: \n Seleccion de todos los libros, cuando el idIdioma es igual a 2";
                    break;
                case 7:
                    sql = "SELECT * FROM Pais";
                    db.Listar(Grilla, sql);
                    lblDescripcion.Text = "Seleccion Simple: \n Seleccion de todos los paises";
                    break;
                case 8:
                    sql = "SELECT Titulo,Año,Precio FROM Libro WHERE Precio = 125";
                    db.Listar(Grilla, sql);
                    lblDescripcion.Text = "Seleccion Multiatributo: \n Seleccion de titulo,año y precio de libros, cuando el precio sea igual a 125 ";

                    break;
                case 9:
                    sql = "SELECT Titulo,Año,Precio FROM Libro WHERE Precio> 800";
                    db.Listar(Grilla, sql);
                    lblDescripcion.Text = "Seleccion Multiatributo: \n Seleccion de titulo,año y precio de libros, cuando el precio sea mayor a 800";
                    break;
                case 10:
                    sql = @"SELECT * FROM 
                    (SELECT * FROM Libro as T1 WHERE T1.IdIdioma > 5) as T2 WHERE T2.IdAutor > 10";
                    db.Listar(Grilla, sql);
                    lblDescripcion.Text = "Seleccion por Convolucion: \n Subtabla T1, conformada por todo los datos de libros ,cuando el idIdioma sea mayor a 5, seleccion de los datos de la misma,cuando el idAutor sea mayor a 10 ";
                    break;
                case 11:
                    sql = @"SELECT * FROM 
                    (SELECT * FROM Libro as T1 WHERE T1.Precio > 300) as T2 WHERE T2.IdIdioma > 3";
                    db.Listar(Grilla, sql);
                    lblDescripcion.Text = "Seleccion por Convolucion: \n Subtabla T1, conformada por todo los datos de libros ,cuando el precio sea mayor a 300, seleccion de todos los datos de la misma, cuando el idIdioma sea mayor a 3";
                    break;
                case 12:
                    sql = @"SELECT * FROM Libro WHERE IdIdioma = 3
                        UNION
                        SELECT * FROM Libro WHERE IdIdioma = 4
                        UNION
                        SELECT * FROM Libro WHERE IdIdioma = 2";
                    db.Listar(Grilla, sql);
                    lblDescripcion.Text = "Union: \n Seleccion de todos los libros con idIdioma igual a 3,4 y 2";
                    break;
                case 13:
                    sql = @"SELECT * FROM Libro WHERE Precio = 125
                        UNION
                        SELECT * FROM Libro WHERE Precio = 854
                        UNION
                        SELECT * FROM Libro WHERE Precio = 789";
                    db.Listar(Grilla, sql);
                    lblDescripcion.Text = "Union: \n Seleccion de todos los libros con precio igual a 125,854 y 789";
                    break;
                case 14:
                    sql = @"SELECT * FROM Libro WHERE IdIdioma
                            IN 
                            (SELECT IdIdioma FROM Libro WHERE IdIdioma < 5)";
                    db.Listar(Grilla, sql);
                    lblDescripcion.Text = "Interseccion: \n Seleccion de todos los libros, cuando el idIdioma sea menor a 5";
                    break;
                case 15:
                    sql = @"SELECT * FROM Libro WHERE IdAutor
                            IN 
                            (SELECT IdAutor FROM Libro WHERE IdAutor > 70)";
                    db.Listar(Grilla, sql);
                    lblDescripcion.Text = "Interseccion: \n Seleccion de Libros donde el IdAutor sea mayor a 70";
                    break;
                case 16:
                    sql = @"SELECT * FROM Libro WHERE IdIdioma
                    NOT IN
                    (SELECT IdIdioma FROM Libro WHERE IdIdioma < 5)";
                    db.Listar(Grilla, sql);
                    lblDescripcion.Text = "Diferencia: \n Seleccion de Libros donde el IdIdioma sea mayor a o igual a 5";
                    break;
                case 17:
                    sql = @"SELECT * FROM Libro WHERE IdAutor
                    NOT IN
                    (SELECT IdAutor FROM Libro WHERE IdAutor > 50)";
                    db.Listar(Grilla, sql);
                    lblDescripcion.Text = "Diferencia: \n Seleccion de Libros donde el IdAutor sea menor a o igual a 50";
                    break;
                case 18:
                    sql = "SELECT Nombre FROM Idioma WHERE IdIdioma > 15";
                    db.Listar(Grilla, sql);
                    lblDescripcion.Text = "Seleccion Simple: \n Seleccion del nombre de los idiomas, cuando el idIdioma sea mayor a 15";
                    break;
                case 19:
                    sql = "SELECT Nombre FROM Autor";
                    db.Listar(Grilla, sql);
                    lblDescripcion.Text = "Proyeccion Simple: \n Seleccion del nombre de los autores";
                    break;
            }
            lblDescripcion.Text += $"\n \n {sql}";
        }
    }
}
