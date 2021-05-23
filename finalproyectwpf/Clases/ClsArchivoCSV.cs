using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalproyectwpf.Clases
{
    class ClsArchivoCSV
    {
        public ClsArchivoCSV(DataTable dato)
        {
            string datoS = "NOMBRE,EDAD,TELEFONO, CARRERA, UNIVERSIDAD, FECHA\n";

            foreach (DataRow x in dato.Rows)
            {
                datoS += ($"{x[0]},{x[1]},{x[2]},{x[3]},{x[4]},{x[5]}\n");
            }

            File.WriteAllText($@"C:\Users\alumno\Desktop\CSV\Consultas.csv", datoS);


        }
    }
}
