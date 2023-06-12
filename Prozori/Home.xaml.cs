using System;
using System.Collections.Generic;
using System.Diagnostics;
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

using NISsoftver.Modeli;

namespace NISsoftver.Prozori
{
   
    public partial class Home : UserControl
    {
        DateTime currentDateTime;
        DateOnly currentDate;
        public List<StavkaDnevnogPlana> listaStavki = new  List<StavkaDnevnogPlana>();

        public Home()
        { 
            currentDateTime = DateTime.Now;
            currentDate = DateOnly.FromDateTime(currentDateTime);
            for (int i = 0; i < 6; i++)
            {
                StavkaDnevnogPlana st = new StavkaDnevnogPlana();
                listaStavki.Add(st);

            }
            
            InitializeComponent();
            popunjavanjePlana();
        }

        public void popunjavanjePlana()
        {
            Debug.WriteLine("Pozvao sam popunjavanjePlana");
            DnevniRaspored_Vreme1.Text = listaStavki[0].vreme.ToString();
            DnevniRaspored_Stavka1.Text = listaStavki[0].stavka;
            if (listaStavki[0].vreme == TimeOnly.MinValue)
            {
                Debug.WriteLine("Necu da prikazem jer sam supak");
                DnevniRaspored_Vreme1.Visibility = Visibility.Hidden;
                DnevniRaspored_Btn1.Visibility = Visibility.Hidden;
            }

            DnevniRaspored_Vreme2.Text = listaStavki[1].vreme.ToString();
            DnevniRaspored_Stavka2.Text = listaStavki[1].stavka;
            if (listaStavki[1].vreme == TimeOnly.MinValue)
            {
                DnevniRaspored_Vreme2.Visibility = Visibility.Hidden;
                DnevniRaspored_Btn2.Visibility = Visibility.Hidden;
            }

            DnevniRaspored_Vreme3.Text = listaStavki[2].vreme.ToString();
            DnevniRaspored_Stavka3.Text = listaStavki[2].stavka;
            if (listaStavki[2].vreme == TimeOnly.MinValue)
            {
                DnevniRaspored_Vreme3.Visibility = Visibility.Hidden;
                DnevniRaspored_Btn3.Visibility = Visibility.Hidden;
            }

            DnevniRaspored_Vreme4.Text = listaStavki[3].vreme.ToString();
            DnevniRaspored_Stavka4.Text = listaStavki[3].stavka;
            if (listaStavki[3].vreme == TimeOnly.MinValue)
            {
                DnevniRaspored_Vreme4.Visibility = Visibility.Hidden;
                DnevniRaspored_Btn4.Visibility = Visibility.Hidden;
            }
            DnevniRaspored_Vreme5.Text = listaStavki[3].vreme.ToString();
            DnevniRaspored_Stavka5.Text = listaStavki[3].stavka;
            if (listaStavki[4].vreme == TimeOnly.MinValue)
            {
                DnevniRaspored_Vreme5.Visibility = Visibility.Hidden;
                DnevniRaspored_Btn5.Visibility = Visibility.Hidden;
            }
            DnevniRaspored_Vreme6.Text = listaStavki[3].vreme.ToString();
            DnevniRaspored_Stavka6.Text = listaStavki[3].stavka;
            if (listaStavki[5].vreme == TimeOnly.MinValue)
            {
                DnevniRaspored_Vreme6.Visibility = Visibility.Hidden;
                DnevniRaspored_Btn6.Visibility = Visibility.Hidden;
            }
        }

        public void Btn_DodajStavku(object sender, RoutedEventArgs e)
        {
            Window posotjeciProzor = Application.Current.MainWindow;
            Prozori.DodavanjeStavke dodajStavku = new Prozori.DodavanjeStavke(this);
            dodajStavku.Owner = posotjeciProzor;
            dodajStavku.Show();
        }
        public void DodajNovuStavku()
        {
            Debug.WriteLine("Dodavanje nove stavke");
            Debug.WriteLine("Nova stavka" + Context.trenutnaNovaStavka.stavka);

            Context.trenutnaNovaStavka.datum = currentDate;

            listaStavki.Insert(0, Context.trenutnaNovaStavka);
            Debug.WriteLine("Novi item u listi: " + listaStavki[0].stavka);
            popunjavanjePlana();
        }

        public void Btn_Vest1(object sender, RoutedEventArgs e)
        {
            MainWindow? parent = Window.GetWindow(this) as MainWindow;
            parent.PrikaziVest1();
        }
        public void Btn_Vest2(object sender, RoutedEventArgs e)
        {
            MainWindow? parent = Window.GetWindow(this) as MainWindow;
            parent.PrikaziVest2();
        }

    }



}
