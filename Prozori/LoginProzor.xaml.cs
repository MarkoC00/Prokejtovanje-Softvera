using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Text.RegularExpressions;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using System;

namespace NISsoftver.Prozori
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class LoginProzor : Window
    {
        string connectionString = "Server=localhost;Port=3306;Database=kompanija_nis;Uid=root;Pwd=zutamunja;";

        string primerKorisnickogImena = "Marko Marković";
        string primerSifra = "Polajedan123";
        public  string promenjenaSifra = "";
        public LoginProzor()
        {
           // UzmiKrisnikeSaBaze();
            InitializeComponent();
        }
        //Konekcija sa bazom
        //public void UzmiKrisnikeSaBaze() {
        //    MySqlConnection connection = new MySqlConnection(connectionString);
        //    connection.Open();

        //    string sqlQuery = "SELECT * FROM kompanija_nis.korisnik";
        //    MySqlCommand command = new MySqlCommand(sqlQuery, connection);

        //    using (MySqlDataReader reader = command.ExecuteReader())
        //    {
        //        while (reader.Read())
        //        {
        //            int korisnikId = reader.GetInt32("korisnik_id");
        //            string ime = reader.GetString("ime");
        //            string prezime = reader.GetString("prezime");
        //            string sapBroj = reader.GetString("SAP_broj");
        //            string mobilniTelefon = reader.GetString("mobilni_telefon");
        //            string email = reader.GetString("email");
        //            string password = reader.GetString("password");

        //            Debug.WriteLine($"Korisnik ID: {korisnikId}");
        //            Debug.WriteLine($"Ime: {ime}");
        //            Debug.WriteLine($"Prezime: {prezime}");
        //            Debug.WriteLine($"SAP Broj: {sapBroj}");
        //            Debug.WriteLine($"Mobilni telefon: {mobilniTelefon}");
        //            Debug.WriteLine($"Email: {email}");
        //            Debug.WriteLine($"Password: {password}");
        //        }
        //    }

        //    connection.Close();
        //}


        public void Bnt_Help(object sender, RoutedEventArgs e)
        {
            string fileName = "Materijali/NIS softver.pptx";  // Replace with the actual path to your Word file
            string filePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = filePath,
                    UseShellExecute = true
                };

                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom otvaranja fajla: {ex.Message}", "Greška", MessageBoxButton.OK, MessageBoxImage.Error);
            }
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
