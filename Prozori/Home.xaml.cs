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
        public List<StavkaDnevnogPlana> listaStavki = new  List<StavkaDnevnogPlana>();

        public Home()
        { 
            for (int i = 0; i < 4; i++)
            {
                StavkaDnevnogPlana st = new StavkaDnevnogPlana();
                listaStavki.Add(st);

            }
            
            InitializeComponent();
            popunjavanjePlana();
        }

        public void popunjavanjePlana()
        {
            DnevniRaspored_Vreme1.Text = listaStavki[0].vreme.ToString();
            DnevniRaspored_Stavka1.Text = listaStavki[0].stavka;
            if (listaStavki[0].vreme == TimeOnly.MinValue)
            {
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
        }

        public void Btn_DodajStavku(object sender, RoutedEventArgs e)
        {
            //TimePicker_VremeStavke
            //Input_Stavka
            for (int i = 0; i < listaStavki.Count; i++)
            {
                if (listaStavki[i].vreme == TimeOnly.MinValue)
                {
                    listaStavki.RemoveAt(i);
                }
            }

            StavkaDnevnogPlana stavka = new StavkaDnevnogPlana();
            DateTime selectedDateTime =TimePicker_VremeStavke.SelectedTime ?? DateTime.MinValue;
            stavka.vreme = new TimeOnly(selectedDateTime.Hour, selectedDateTime.Minute, selectedDateTime.Second);
            stavka.stavka = Input_Stavka.Text;

            listaStavki.Add(stavka);

            //popunjavanjePlana();
        }

    }



}
