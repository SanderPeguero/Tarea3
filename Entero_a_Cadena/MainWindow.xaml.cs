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

namespace Entero_a_Cadena
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

        void Convertir(object sender, EventArgs e){
            int n = int.Parse(Numero.Text);
            MessageBox.Show("Resultado: " + FuncionCadena(n));
        }
        string FuncionCadena(int n)
        {           
            return n.ToString();

        }
    }
}
