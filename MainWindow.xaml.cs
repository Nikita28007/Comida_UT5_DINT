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


namespace Comida_UT5_DINT
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Plato> platos;
        public MainWindow()
        {
            InitializeComponent();
            nombresComboBox();
            platos = Plato.GetSamples(Path.GetFileName(@"../Resources/Imagenes"));
            PlatosListBox.DataContext = platos;
        }
        private void nombresComboBox()
        {
            List<String> paises = new List<string>() { "Americana", "China", "Mexicana" };
            opcionesComboBox.ItemsSource = paises;
        }
    }
}
