﻿using System.Data.OracleClient;
using System;
using System.Data;

namespace BaseDeDatos.Clases.BaseDatos
{
    class ClsConexionOracle
    {
        public OracleConnection conexion;
        private String _conexion { get; }

        public ClsConexionOracle()
        {

            _conexion = "DATA SOURCE = umg ; USER ID= UMG; PASSWORD = Umg$19 ;";

        }


        /// <summary>
        /// Cierra la conexion.
        /// </summary>
        public void cerrarConexionBD()
        {
            conexion.Close();
        }



        /// <summary>
        /// abre la conexion
        /// </summary>
        public void abrirConexion()
        {
            conexion = new OracleConnection(_conexion);
            conexion.Open();
        }




        /// <summary>
        /// metodo que ejecuta una consulta, esta clase maneja la apertura y clausura a la base de datos
        /// </summary>
        /// <param name="sqll"></param>
        /// <returns></returns>
        public DataTable consultaTablaDirecta(String sqll)
        {
            abrirConexion();
            OracleDataReader dr;
            OracleCommand comm = new OracleCommand(sqll, conexion);
            dr = comm.ExecuteReader();

            var dataTable = new DataTable();
            dataTable.Load(dr);
            cerrarConexionBD();
            return dataTable;
        }



        /// <summary>
        /// ejecuta una instrucción de insersion, eliminación y actualización,
        /// esta clase se encarga de manejar las aperturas y clausuras de la conexion.
        /// </summary>
        /// <param name="sqll"></param>
        public void EjecutaSQLDirecto(String sqll)
        {
            abrirConexion();
            try
            {

                OracleCommand comm = new OracleCommand(sqll, conexion);
                comm.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            finally
            {
                cerrarConexionBD();
            }



        }




        /// <summary>
        /// ejecuta instrucciones SQL, pero el progromador debe manejar la apertura y clausura
        /// de las conexiones.
        /// </summary>
        /// <param name="sqll"></param>
        public void EjecutaSQLManual(String sqll)
        {
            // se abre y cierra la conexino manualmente
            OracleCommand comm = new OracleCommand(sqll, conexion);
            comm.ExecuteReader();
        }

    }
}
