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

namespace PracticaPerimetros {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void cbTipoFigura_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            controlPerimetroCirculo.Visibility = Visibility.Collapsed;
            controlPerimetroCuadrado.Visibility = Visibility.Collapsed;
            controlPerimetroTrapecio.Visibility = Visibility.Collapsed;
            controlPerimetroRectangulo.Visibility = Visibility.Collapsed;

            switch(cbTipoFigura.SelectedIndex) {
                case 0: // Círculo
                    controlPerimetroCirculo.Visibility = Visibility.Visible;
                    break;
                case 1: // Cuadrado
                    controlPerimetroCuadrado.Visibility = Visibility.Visible;
                    break;
                case 2:
                    controlPerimetroTrapecio.Visibility = Visibility.Visible;
                    break;
                case 3:
                    controlPerimetroRectangulo.Visibility = Visibility.Visible;
                    break;
                default:
                    break;
            }
        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e) {
            float perimetro = 0.0f;

            switch(cbTipoFigura.SelectedIndex) {
                case 0: // Círculo
                    float radio = float.Parse(controlPerimetroCirculo.txtRadio.Text);
                    perimetro = 2 * radio * (float)Math.PI; 
                    break;
                case 1: // Cuadrado
                    float lado = float.Parse(controlPerimetroCuadrado.txtLado.Text);
                    perimetro = lado * 4;
                    break;
                case 2:
                    float ladoA = float.Parse(controlPerimetroTrapecio.txtLadoA.Text);
                    float ladoB = float.Parse(controlPerimetroTrapecio.txtLadoB.Text);
                    float ladoC = float.Parse(controlPerimetroTrapecio.txtLadoC.Text);
                    float ladoD = float.Parse(controlPerimetroTrapecio.txtLadoD.Text);
                    perimetro = ladoA + ladoB + ladoC + ladoD;
                    break;
                case 3:
                    float ladoRectanguloA = float.Parse(controlPerimetroRectangulo.txtLadoRectanguloA.Text);
                    float ladoRectanguloB = float.Parse(controlPerimetroRectangulo.txtLadoRectanguloB.Text);
                    perimetro = ladoRectanguloA * 2 + ladoRectanguloB * 2;
                    break;
                default:
                    break;
            }
            lblResultado.Text = perimetro.ToString();
        }
    }
}
