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

        void Procesar()
        {
            MessageBox.Show("Promedio: " + CalculadoraPromedio(edades) + "\nEdad Mayor: " + edadMayor + "\nEdad Menor" + edadMenor );
        }

        void AgregarEdad(object sender, EventArgs e)
        {
            edades[edades.GetLength(0)] = int.Parse(EdadTextBox.Text);
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
