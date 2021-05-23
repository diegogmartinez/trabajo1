using finalproyectwpf.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace finalproyectwpf
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public string [] universidad { get; set; }
        public string [] carrerasñ { get; set; }

        string nombre, opcioncarrera, opcionuniversidad;
        int edad,telefono;
        DateTime? fecha;
        DateTime? fecha01; 
        DateTime? fecha02;

        private void guardar_Click(object sender, RoutedEventArgs e)
        {
            nombre = TexBoxNombre.Text;
            edad = Convert.ToInt32(TexBoxedad.Text);
            telefono = Convert.ToInt32(TexBoxtelefono.Text);
            opcioncarrera = Convert.ToString(ComboboxCarrera.SelectedItem);
            opcionuniversidad = Convert.ToString(ComboboxUniversidad.SelectedItem);
            ClsConexion cn = new ClsConexion();
            DataTable tb = cn.consultaTablaDirecta("insert into dbprogra.progra_proyect values ('"+nombre+"',"+edad+","+telefono+",'"+opcioncarrera+"','"+opcionuniversidad+"','"+fecha.Value.ToString("yyyyy/MM/dd")+"');");
            TexBoxNombre.Clear();
            TexBoxedad.Clear();
            TexBoxtelefono.Clear();
           

        }

        private void ingresefecha_Click(object sender, RoutedEventArgs e)
        {
            fecha = fechaPicker.SelectedDate;
        }

        private void nombrebus_Click(object sender, RoutedEventArgs e)
        {
            
            string nombre = TexBoxNombreCons.Text;
            ClsConexion cn = new ClsConexion();
            DataTable dt = cn.consultaTablaDirecta("SELECT * FROM dbprogra.progra_proyect where UPPER(Nombre) like ('%" + nombre + "%')");
            ClsArchivoCSV ar = new ClsArchivoCSV(dt);

            string datoS = "";

            foreach (DataRow x in dt.Rows)
            {
                datoS = ($"{x[0]},{x[1]},{x[2]},{x[3]},{x[4]},{x[5]}\n");
            }

            listado.ItemsSource = datoS;

            TexBoxNombreCons.Clear();


        }
        

        private void carrerabus_Click(object sender, RoutedEventArgs e)
        {
            string opcionCarrera = Convert.ToString(ComboboxConsCarrera.SelectedItem);
            ClsConexion cn = new ClsConexion();
            DataTable dt = cn.consultaTablaDirecta("SELECT * FROM dbprogra.progra_proyect where universidad= '" + opcionCarrera + "'");
            ClsArchivoCSV ar = new ClsArchivoCSV(dt);

            string datoS = "";

            foreach (DataRow x in dt.Rows)
            {
                datoS = ($"{x[0]},{x[1]},{x[2]},{x[3]},{x[4]},{x[5]}\n");
            }

            listado.ItemsSource = datoS;
        }

        private void universidadbus_Click(object sender, RoutedEventArgs e)
        {
            string opcionUniversidad = Convert.ToString(ComboboxConsUni.SelectedItem);
            ClsConexion cn = new ClsConexion();
            DataTable dt = cn.consultaTablaDirecta("SELECT * FROM dbprogra.progra_proyect where universidad= '" + opcionUniversidad + "'");
            ClsArchivoCSV ar = new ClsArchivoCSV(dt);

            string datoS = "";

            foreach (DataRow x in dt.Rows)
            {
                datoS = ($"{x[0]},{x[1]},{x[2]},{x[3]},{x[4]},{x[5]}\n");
            }

            listado.ItemsSource = datoS;

        }
        

        private void fecha1_Click(object sender, RoutedEventArgs e)
        {
            fecha01 = picker1.SelectedDate;
        }

        private void fecha2_Click(object sender, RoutedEventArgs e)
        {
            fecha02 = picker2.SelectedDate;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ClsConexion cn = new ClsConexion();
            string nombreModificar = texbosModificar.Text;

            string opcionModificar = Convert.ToString(ComboboxUniversidad_Copy.SelectedItem);
            DataTable dt = cn.consultaTablaDirecta("UPDATE dbprogra.progra_proyect SET universidad='" + opcionModificar + "' WHERE UPPER (Nombre) like('%" + nombreModificar + "%');");
            texbosModificar.Clear();
        }

        private void BsXFecha_Click(object sender, RoutedEventArgs e)
        {
            ClsConexion cn = new ClsConexion();
            DataTable dt = cn.consultaTablaDirecta("SELECT* FROM dbprogra.progra_proyect where fecha between '" + fecha01.Value.ToString("yyyy/MM/dd") + "' and '" + fecha02.Value.ToString("yyyy/MM/dd") + "'");
            ClsArchivoCSV ar = new ClsArchivoCSV(dt);

            string datoS = "";

            foreach (DataRow x in dt.Rows)
            {
                datoS = ($"{x[0]},{x[1]},{x[2]},{x[3]},{x[4]},{x[5]}\n");
            }

            listado.ItemsSource = datoS;
        }

        public MainWindow()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            universidad = new string[] { "Universidad Mariano Galvez", "Universidad da vinci", "Universidad del valle", "Universidad Rafael landivar", "Universidad Galileo", "Universidad Panamericana", "Universidad de San Carlos" };
            carrerasñ = new string[] { "Psicologia", "Ingenieria en Sistemas", "Agronomia", "Derecho", "Criminologia", "Ingenieria Industrial", "Contaduria" };

            DataContext = this;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           

        }
    }
}
