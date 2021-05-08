using BaseDeDatos.Clases.ArchivoPlano;
using BaseDeDatos.Clases.BaseDatos;
using System;
using System.Data;

namespace BaseDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            string respuestaUsuario;
            Console.WriteLine("\t\t\t¿Que Base de Datos desee utilizar?");
            Console.WriteLine("\n\t\tOracle\t\t\tMySQL\t\t\tSQL");
            respuestaUsuario = Console.ReadLine();

            string[,] archivoMatriz;
            ClsArchivo ObjArchivo = new ClsArchivo();
            archivoMatriz = ObjArchivo.LeerArchivo();
            ClsConexionOracle oracle = new ClsConexionOracle();
            ClsConexionMySQL mysql = new ClsConexionMySQL();
            ClsConexion cn = new ClsConexion();






            switch (respuestaUsuario)
            {
                case "Oracle":

                    for (int i = 1; i < archivoMatriz.GetLength(0); i++)
                    {

                        DataTable dt = oracle.consultaTablaDirecta("insert into TB_ALUMNOS values (" + archivoMatriz[i, 0] + ",'" + archivoMatriz[i, 1] + "'," + archivoMatriz[i, 2] + "," + archivoMatriz[i, 3] + "," + archivoMatriz[i, 4] + ")");

                    }

                    break;

                case "MySQL":

                    for (int i = 1; i < archivoMatriz.GetLength(0); i++)
                    {

                        DataTable dt = mysql.consultaTablaDirecta("insert into tb_alumnos values (" + archivoMatriz[i, 0] + ",'" + archivoMatriz[i, 1] + "'," + archivoMatriz[i, 2] + "," + archivoMatriz[i, 3] + "," + archivoMatriz[i, 4] + ")");

                    }

                    break;

                case "SQL":

                    for (int i=1; i < archivoMatriz.GetLength(0); i++)
                    {

                        DataTable dt = cn.consultaTablaDirecta("insert into tb_alumnos values (" + archivoMatriz[i, 0] + ",'" + archivoMatriz[i, 1] + "'," + archivoMatriz[i, 2] + "," + archivoMatriz[i, 3] + "," + archivoMatriz[i, 4] + ")");


                    }
                   
                    break;
            }            

        }
    }
}
