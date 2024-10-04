using BibliotecaDeClases;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfEjercicio1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private String texto;
        ClsPersona miPersona = new ClsPersona();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            texto = textBox.Text;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            miPersona.Nombre = texto;
            MessageBox.Show("Bienvenido  " + miPersona.Nombre);
        }

    }
}