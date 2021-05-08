using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatos.Clases.ArchivoPlano
{
    class ClsArchivo
    {
        public string[,] LeerArchivo()
        {
            string[] Archivoexcel = File.ReadAllLines(@"C:\Users\alumno\Desktop\alumnos\archivoPlano.csv", Encoding.Default);

            int acumulador = 0;

            string[,] Matriz = new string[Archivoexcel.Length, 5];

            foreach (string linea in Archivoexcel)
            {
                string[] datos = linea.Split(';');

                Matriz[acumulador, 0] = datos[0];
                Matriz[acumulador, 1] = datos[1];
                Matriz[acumulador, 2] = datos[2];
                Matriz[acumulador, 3] = datos[3];
                Matriz[acumulador, 4] = datos[4];
                acumulador++;

            }

            return Matriz;


        }

    }
}
