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

namespace Tabla_1_al_10
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

        public void Calcular(object sender, RoutedEventArgs e)
        {
            int tabla = int.Parse(TablaDel.Text);

            FuncionTabla(tabla);
        }

        // int[] FuncionTabla(int numeroTabla)
        void FuncionTabla(int numeroTabla)
        {

            int[] tabla = new int[10];

            for (int s = 1; s < 11; s++)
            {

                tabla[s - 1] = s * numeroTabla;

            }

            //return tabla;
            MessageBox.Show(
                "1 * " + tabla[0].ToString() + "= " + tabla[0].ToString() +
                "\n 2 * " + tabla[0].ToString() + "= " + tabla[1].ToString() +
                "\n 3 * " + tabla[0].ToString() + "= " + tabla[2].ToString() +
                "\n 4 * " + tabla[0].ToString() + "= " + tabla[3].ToString() +
                "\n 5 * " + tabla[0].ToString() + "= " + tabla[4].ToString() +
                "\n 6 * " + tabla[0].ToString() + "= " + tabla[5].ToString() +
                "\n 7 * " + tabla[0].ToString() + "= " + tabla[6].ToString() +
                "\n 8 * " + tabla[0].ToString() + "= " + tabla[7].ToString() +
                "\n 9 * " + tabla[0].ToString() + "= " + tabla[8].ToString() +
                "\n 10 * " + tabla[0].ToString() + "= " + tabla[9].ToString()
            );
        }
    }
}
