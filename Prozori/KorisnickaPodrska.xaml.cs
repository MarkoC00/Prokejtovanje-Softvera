using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Threading;

namespace NISsoftver.Prozori
{
    /// <summary>
    /// Interaction logic for KorisnickaPodrska.xaml
    /// </summary>
    public partial class KorisnickaPodrska : Window
    {
        public ObservableCollection<string> Poruke;
        private DispatcherTimer timer;
        private TimeSpan preostaloVreme;
        private string korisnickoIme = "Marko Marković";
        private string sap = "12345";
        private bool unetoIme;
        enum izbor {KorisnickoIme,Sap,GreskaIme,GreskaSap,PocetnoStanje};
        private izbor stanjeCheta;
        public KorisnickaPodrska()
        {
            InitializeComponent();
            Poruke = new ObservableCollection<string>();
            preostaloVreme = TimeSpan.FromSeconds(5);
            stanjeCheta = izbor.PocetnoStanje;
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
            ChatListBox.ItemsSource = Poruke;
        }

        private void Btn_PovratakNaLogin(object sender, RoutedEventArgs e)
        {
            LoginProzor login = new LoginProzor();
            if(stanjeCheta == izbor.Sap)
            {
                login.promenjenaSifra = "Promenjena3";
            }
            login.Show();
            this.Close();
        }

        private void Btn_PosaljiTekst(object sender, RoutedEventArgs e)
        {
            Poruke.Add("Ti: " + MessageTextBox.Text);
            if(MessageTextBox.Text == korisnickoIme && !unetoIme)
            {
                stanjeCheta = izbor.KorisnickoIme;
                unetoIme = true;
            }
            else if(MessageTextBox.Text == sap && unetoIme)
            {
                stanjeCheta = izbor.Sap;
            }
            else if(unetoIme)
            {
                stanjeCheta = izbor.GreskaSap;
            }
            else
            {
                stanjeCheta = izbor.GreskaIme;
            }
            preostaloVreme = TimeSpan.FromSeconds(5);
            timer.Start();
            MessageTextBox.Text = string.Empty;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            preostaloVreme = preostaloVreme.Subtract(TimeSpan.FromSeconds(1));
            if (preostaloVreme.TotalSeconds <= 0)
            {
                switch (stanjeCheta)
                {
                    case izbor.PocetnoStanje:
                        Poruke.Add("Tehnicar: Unesite korisnicko ime da bih vam resetovali sifru.");
                        break;
                    case izbor.KorisnickoIme:
                        Poruke.Add("Tehnicar: Unesite vas sap broj.");
                        break;
                    case izbor.Sap:
                        Poruke.Add("Tehnicar: Vasa nova sifra je: Promenjena3");
                        Btn_Posalji.IsEnabled = false;
                        break;
                    case izbor.GreskaIme:
                        Poruke.Add("Tehnicar: korisnicko ime nije dobro");
                        break;
                    case izbor.GreskaSap:
                        Poruke.Add("Tehnicar: Sap broj nije dobar");
                        break;

                }
                timer.Stop();
            }
        }
    }
}
