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
using System.Windows.Shapes;

namespace RemisztoDolgozatSO
{
    /// <summary>
    /// Interaction logic for NameCardWindow.xaml
    /// </summary>
    public partial class NameCardWindow : Window
    {
        public NameCardWindow(string nev, string szuldatum, string teloszam, string email)
        {
            InitializeComponent();
            Feltoltes(nev, szuldatum, teloszam, email);
        }

        private void Feltoltes(string nev, string szuldatum, string teloszam, string email)
        {
            cardName.Text = nev;
            cardBirthDate.Text = szuldatum;
            cardPhoneNumber.Text = teloszam;
            cardEmail.Text = email;
        }
    }
}
