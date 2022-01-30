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

namespace Calcular_Exponencial
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

        private void Calcular(object sender, RoutedEventArgs e)
        {
            int numero =int.Parse(Numero.Text);
            int exponente = int.Parse(Exponente.Text);

            MessageBox.Show("Resultado: " + (FuncionExponencial(numero, exponente)).ToString());
        }
        int FuncionExponencial(int numero, int exponente)
        {
            int resultado = numero;

            if (exponente == 1)
            {
                return numero;
            }
            else if (exponente == 0)
            {
                return 1;
            }
            else if (exponente < 0)
            {
                return 0;
            }
            else
            {
                for (int s = 1; s < exponente; s++)
                    resultado = resultado * numero;
            }
            return resultado;
        }

    }
}
