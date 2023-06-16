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
using NISsoftver.Modeli;
using NISsoftver.Prozori;
using System.Globalization;
using MySql.Data.MySqlClient;

namespace NISsoftver.Prozori
{
    public partial class DodavanjeStavke : Window
    {
        StavkaDnevnogPlana novaStavka = new StavkaDnevnogPlana();
        private Home home;

        public DodavanjeStavke(Home home)
        {
            InitializeComponent();
            this.home = home;
        }

        private void Button_Otkazi(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Sacuvaj(object sender, RoutedEventArgs e)
        {
            novaStavka.stavka = Input_Stavka.Text;

            // Provera unosa naziva
            if (string.IsNullOrWhiteSpace(novaStavka.stavka))
            {
                MessageBox.Show("Molimo vas da unesete naziv stavke.", "Greška", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Provera unosa vremena
            if (!TimeOnly.TryParse(Input_Vreme.Text, out novaStavka.vreme))
            {
                MessageBox.Show("Molimo vas da unesete validno vreme u formatu HH:mm.", "Greška", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            
            home.listaStavki.Insert(0, novaStavka);
            
            home.popunjavanjePlana();

            Close();
        }


        private void Input_Vreme_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
