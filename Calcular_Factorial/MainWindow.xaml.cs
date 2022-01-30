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

namespace Calcular_Factorial
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

        void Calcular(object sender, RoutedEventArgs e){
            int numero = int.Parse(NumeroTextBox.Text);
            MessageBox.Show("Factorial: " + Factorial(numero));
        }

        int Factorial(int numero)
        {

            if (numero == 0)
            {

                return 1;

            }
            else
            {

                return numero * Factorial(numero - 1);
            }
        }
    }
}
