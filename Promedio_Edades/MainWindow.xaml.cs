using System;
using System.Collections.Generic;
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

namespace Promedio_Edades
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }
        int edadMayor = 0;
        int edadMenor = 0;
        int[] edades;

        List<int> lista = new List<int>();

        void Procesar(object sender, RoutedEventArgs e)
        {
            try
            {
                edades = lista.ToArray();
                MessageBox.Show("Promedio: " + CalculadoraPromedio(edades) + "\nEdad Mayor: " + edadMayor + "\nEdad Menor" + edadMenor);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void AgregarEdad(object sender, RoutedEventArgs e)
        {
            try
            {
                lista.Add(int.Parse(EdadTextBox.Text));
                MessageBox.Show("Edad Agregada con Exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        int CalculadoraPromedio(int[] edades)
        {

            int totalEdades = 0;

            for (int s = 0; s < edades.GetLength(0); s++)
            {
                totalEdades += edades[s];
                setEdadMayor(edades[s]);
                setEdadMenor(edades[s]);
            }

            var promedio = totalEdades / edades.GetLength(0);

            return promedio;
        }

        void setEdadMayor(int edad)
        {
            if (edadMayor < edad)
            {
                edadMayor = edad;
            }
        }

        void setEdadMenor(int edad)
        {
            if (edad < edadMenor || edadMenor == 0)
            {
                edadMenor = edad;
            }
        }

    }
}
