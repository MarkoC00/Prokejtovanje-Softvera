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
using System.Text.RegularExpressions;

namespace NISsoftver.Prozori
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        string primerKorisnickogImena = "Marko Marković";
        string primerSifra = "Polajedan123";
        public Login()
        {
            InitializeComponent();
        }
        private void BtnClose(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void KorisnickoIme_Focus(object sender, RoutedEventArgs e)
        {
            ((TextBox)sender).Text = string.Empty;
        }

        private void Btn_UlogujSe(object sender, RoutedEventArgs e)
        {
            string korisnickoIme = Input_KorisnickoIme.Text;
            string sifra = Input_Sifra.Password;

            if (korisnickoIme == null && korisnickoIme != primerKorisnickogImena)
            {
                MessageBox.Show("Korisnik ne postoji");
                return;
            }

            if(!VerifikovanjeImena(korisnickoIme))
            {
                Input_KorisnickoIme.Text = string.Empty;
                return;
            }

            if (!VerifikovanjeSifre(sifra))
            {
                Input_Sifra.Password = string.Empty;
                return;
            }

            if (sifra != primerSifra)
            {
                MessageBox.Show("Uneli ste pogresnu lozinku!");
                Input_Sifra.Password = string.Empty;
                return;
            }

            //Uloguj korisnika
            MainWindow win = new MainWindow();
            win.Show();
            this.Close();
        }

        private bool VerifikovanjeImena(string korisnickoIme)
        {
            Regex regex = new Regex("[A-Z].*[A-Z]|[A-Z]{2,}");
            bool sadrziBarDvaVelikaSlova = regex.IsMatch(korisnickoIme);
            if (!sadrziBarDvaVelikaSlova)
            {
                MessageBox.Show("Korisničko ime mora imati barem dva velika slova!");
                return false;
            }
            return true;
        }
        private bool VerifikovanjeSifre(string password)
        {
            if (password.Length <= 8)
            {
                MessageBox.Show("Lozinka mora biti duza od 8 karaktera!");
                return false;
            }
            if (!password.Any(char.IsUpper))
            {
                MessageBox.Show("Lozinka mora imati velika slova!");
                return false;
            }
            if (!password.Any(char.IsDigit))
            {
                MessageBox.Show("Lozinka mora imati brojeve!");
                return false;
            }

            return true;
        }
    }
}
