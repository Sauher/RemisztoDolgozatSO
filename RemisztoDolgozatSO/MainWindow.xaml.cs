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

namespace RemisztoDolgozatSO
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

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            
            string Nev = nev.Text;
            string Szuldatum = szuldatum.Text;
            string Telefonszam = telefonszam.Text;
            string Email = email.Text;
            NameCardWindow nameCardWindow = new NameCardWindow(Nev, Szuldatum, Telefonszam, Email);
            nameCardWindow.ShowDialog();
        }

        private void colors_Click(object sender, RoutedEventArgs e)
        {
            ColorSliderWindow colorSliderWindow = new ColorSliderWindow();
            colorSliderWindow.ShowDialog();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}