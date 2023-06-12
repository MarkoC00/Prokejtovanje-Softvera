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

namespace NISsoftver.Prozori
{
    public partial class DodavanjeStavke : Window
    {
        StavkaDnevnogPlana novaStavka = new StavkaDnevnogPlana();
        private Home home = new Home();

        public DodavanjeStavke(Home home)
        {
            InitializeComponent();
            home = home;
        }

        private void Button_Otkazi(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Sacuvaj(object sender, RoutedEventArgs e)
        {
            novaStavka.stavka = Input_Stavka.Text;
            DateTime selectedDateTime = VremeStavke.SelectedTime ?? DateTime.MinValue;
            novaStavka.vreme = new TimeOnly(selectedDateTime.Hour, selectedDateTime.Minute, selectedDateTime.Second);
            
            Context.trenutnaNovaStavka = novaStavka;

            home.DodajNovuStavku();

            Close();
        }
    }
}
