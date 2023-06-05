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
        public  string promenjenaSifra = "";
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

            if (!VerifikovanjeImena(korisnickoIme))
            {
                Input_KorisnickoIme.Text = string.Empty;
                return;
            }

            if (!VerifikovanjeSifre(sifra))
            {
                Input_Sifra.Password = string.Empty;
                return;
            }

            if (sifra != primerSifra && string.IsNullOrEmpty(promenjenaSifra))
            {
                MessageBox.Show("Uneli ste pogresno korisnicko ime ili lozinku!");
                Input_Sifra.Password = string.Empty;
                return;
            }

            if(!string.IsNullOrEmpty(promenjenaSifra) && sifra != promenjenaSifra)
            {
                MessageBox.Show("Uneli ste pogresno korisnicko ime ili lozinku!");
                Input_Sifra.Password = string.Empty;
                return;
            }

            //Uloguj korisnika
            MainWindow win = new MainWindow();
            win.Show();
            this.Close();
        }

        private void Btn_ZaboravljenaLozinka(object sender, RoutedEventArgs e)
        {
            KorisnickaPodrska korisnickaPodrska = new KorisnickaPodrska();
            korisnickaPodrska.Show();
            this.Close();
        }

        private bool VerifikovanjeImena(string korisnickoIme)
        {
            Regex regex = new Regex("[A-Z].*[A-Z]|[A-Z]{2,}");
            bool sadrziBarDvaVelikaSlova = regex.IsMatch(korisnickoIme);
            if (!sadrziBarDvaVelikaSlova)
            {
                MessageBox.Show("Uneli ste pogresno korisnicko ime ili lozinku!");
                return false;
            }
            return true;
        }
        private bool VerifikovanjeSifre(string password)
        {
            if (password.Length <= 8)
            {
                MessageBox.Show("Uneli ste pogresno korisnicko ime ili lozinku!");
                return false;
            }
            if (!password.Any(char.IsUpper))
            {
                MessageBox.Show("Uneli ste pogresno korisnicko ime ili lozinku!");
                return false;
            }
            if (!password.Any(char.IsDigit))
            {
                MessageBox.Show("Uneli ste pogresno korisnicko ime ili lozinku!");
                return false;
            }

            return true;
        }

        private void PritisakEntera(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                e.Handled = true;

                if (sender == Input_KorisnickoIme)
                {
                    Input_Sifra.Focus();
                }
                else if (sender == Input_Sifra)
                {
                    Btn_UlogujSe(sender, e);
                }
            }
        }
    }
}
