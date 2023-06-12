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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NISsoftver
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.mainContentControl.Content = new Prozori.Home();
        }

        private void BtnClose(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void BtnMinimize(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        public void PrikaziVest1()
        {
            GridUserContol.Children.Clear();
            GridUserContol.Children.Add(new Prozori.Vesti1());
        }

        public void PrikaziVest2()
        {
            GridUserContol.Children.Clear();
            GridUserContol.Children.Add(new Prozori.Vest2());
        }
        private void ButtonTab(object sender, RoutedEventArgs e)
        {
            int index = int.Parse(((Button)e.Source).Uid);

            switch (index)
            {
                case 0:
                    GridUserContol.Children.Clear();
                    GridUserContol.Children.Add(new Prozori.Home());
                    break;
                case 1:
                    GridUserContol.Children.Clear();
                    GridUserContol.Children.Add(new Prozori.PlanRadaVatrogasaca());
                    break;
                case 2:
                    GridUserContol.Children.Clear();
                    //GridUserContol.Children.Add(new View.UC_PocetakDana());
                    break;
                case 3:
                    GridUserContol.Children.Clear();
                    //GridUserContol.Children.Add(new View.UC_PocetakDana());
                    break;
                case 4:
                    GridUserContol.Children.Clear();
                    //GridUserContol.Children.Add(new View.UC_PocetakDana());
                    break;
                default:
                    break;
            }
        }
    }
}
