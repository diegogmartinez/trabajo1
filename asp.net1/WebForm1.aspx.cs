using asp.net1.clases.Archivos;
using asp.net1.clases.Conexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp.net1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        int x = 0;

        private void cargarArchivoExterno()
        {
            string fuente = @"C:\Users\alumno\Desktop\alumnos\crudDB.csv";
            ClsLeerArchivo ar = new ClsLeerArchivo();
            //obtner todo el archivo, linea por linea dentro de un arreglo
            string[] ArregloNotas = ar.LeerArchivo(fuente);
            string sentencia_sql = "";
            int Numerolinea = 0;

            ClsConexion cn = new ClsConexion();
            ClsMySQL my = new ClsMySQL();

            foreach (string linea in ArregloNotas)
            {

                //obtener datos
                String[] datos = linea.Split(';');
                if (Numerolinea > 0)
                {
                    sentencia_sql = sentencia_sql + $"insert into tb_alumnos values({datos[0]},'{datos[1]}',{datos[2]},{datos[3]},{datos[4]},{datos[5]},'{datos[6]}');\n ";
                }

                Numerolinea++;
            }

            switch (x) 
            {
                case 1:
                    cn.EjecutaSQLDirecto(sentencia_sql);

                    break;
                case 2:
                    my.EjecutaSQLDirecto(sentencia_sql);
                    break;

            } 

            
        }

        protected void ButtonSQL_Click(object sender, EventArgs e)
        {
            x = 1;
            cargarArchivoExterno();
        }

        protected void ButtonMySQL_Click(object sender, EventArgs e)
        {
            x = 2;
            cargarArchivoExterno();
        }
    }
}