using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.IO;
using System.Diagnostics;
using System.Windows.Input;
using NISsoftver.Modeli;
using System.Windows.Media;

namespace NISsoftver.Prozori
{
    /// <summary>
    /// Interaction logic for PlanRadaVatrogasaca.xaml
    /// </summary>
    public partial class PlanRadaVatrogasaca : UserControl, INotifyPropertyChanged
    {
        private List<RedTabele> rasporedRada;
        private List<string> fileNameList = new List<string>();
        public int brojAktivnosti = 0;
        public PlanRada planRada = new PlanRada();

        public List<RedTabele> RasporedRada
        {
            get { return rasporedRada; }
            set
            {
                rasporedRada = value;
                OnPropertyChanged(nameof(RasporedRada));
            }
        }

        public PlanRadaVatrogasaca()
        {
            InitializeComponent();
            DataContext = this;

            fileNameList.Add("Materijali/Dnevni izveštaj PC NS  08.06.2023.docx");
            fileNameList.Add("Materijali/Dnevni izveštaj PC NS  09.06.2023.docx");
            fileNameList.Add("Materijali/Dnevni izveštaj PC NS  10.06.2023.docx");
            fileNameList.Add("Materijali/Dnevni izveštaj PC NS  11.06.2023.docx");
            tb_plan_rada.Text += DateOnly.FromDateTime(DateTime.Now).ToString() + Environment.NewLine;

            //PopuniTabelu();
        }

        public class RedTabele
        {
            public DateTime Datum { get; set; }
            public string PrvaSmenaA { get; set; }
            public string PrvaSmenaB { get; set; }
            public string DrugaSmenaA { get; set; }
            public string DrugaSmenaB { get; set; }
        }

        public partial class MainWindow : Window
        {
            public List<RedTabele> RasporedRada { get; set; }
            public List<string> MeniPodaci { get; set; }

            public MainWindow()
            {
                // InitializeComponent();
                PopuniTabelu();
                PopuniMeniPodatke();
                DataContext = this;
            }

            private void PopuniTabelu()
            {
                RasporedRada = new List<RedTabele>
        {
            new RedTabele { Datum = new DateTime(2023, 6, 9), PrvaSmenaA = "Podatak1", PrvaSmenaB = "Podatak2", DrugaSmenaA = "Podatak3", DrugaSmenaB = "Podatak4" },
            new RedTabele { Datum = new DateTime(2023, 6, 10), PrvaSmenaA = "Podatak5", PrvaSmenaB = "Podatak6", DrugaSmenaA = "Podatak7", DrugaSmenaB = "Podatak8" },
            new RedTabele { Datum = new DateTime(2023, 6, 11), PrvaSmenaA = "Podatak9", PrvaSmenaB = "Podatak10", DrugaSmenaA = "Podatak11", DrugaSmenaB = "Podatak12" },
            new RedTabele { Datum = new DateTime(2023, 6, 12), PrvaSmenaA = "Podatak13", PrvaSmenaB = "Podatak14", DrugaSmenaA = "Podatak15", DrugaSmenaB = "Podatak16" },
            new RedTabele { Datum = new DateTime(2023, 6, 13), PrvaSmenaA = "Podatak17", PrvaSmenaB = "Podatak18", DrugaSmenaA = "Podatak19", DrugaSmenaB = "Podatak20" }
        };
            }

            private void PopuniMeniPodatke()
            {
                MeniPodaci = new List<string>
        {
            "Podatak1",
            "Podatak2",
            "Podatak3",
            "Podatak4",
            "Podatak5",
            "Podatak6",
            "Podatak7",
            "Podatak8"
        };
            }
        }



        private void DatePicker_CalendarOpened(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Dostupni su izveštaji samo za ovaj mesec.", "Informacija");
        }

        public void btnAktivnost(object sender, MouseButtonEventArgs e)
        {
            TreeViewItem item = (TreeViewItem)sender;
            string parentHeader = "";
            if (item.Parent is TreeViewItem parentItem)
            {
                parentHeader = parentItem.Header.ToString();
                // Koristite parentHeader prema potrebi
            }

            brojAktivnosti++;
            if (brojAktivnosti >= 10)
            {
                MessageBox.Show("Maksimalan broj aktivnosti je 10.");
                return;
            }

            // Kreiranje novog TextBlock-a
            TextBlock newTextBlock = new TextBlock();
            newTextBlock.Text = parentHeader + " " + item.Header.ToString();
            newTextBlock.VerticalAlignment = VerticalAlignment.Top;
            newTextBlock.HorizontalAlignment = HorizontalAlignment.Stretch;
            newTextBlock.Height = 40;
            newTextBlock.TextWrapping = TextWrapping.Wrap;
            newTextBlock.Foreground = (Brush)new BrushConverter().ConvertFrom("#19499B");
            newTextBlock.TextAlignment = TextAlignment.Center;
            newTextBlock.FontSize = 22;
            newTextBlock.Margin = new Thickness(10, 10 + (brojAktivnosti * 40), 10, 0); // Gornja margina od 10

            // Dodavanje novog TextBlock-a u prazan Grid
            prazanGrid.Children.Add(newTextBlock);
        }



        





        private void PromenaIzabraneStavkeLevogTreeView(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            TreeViewItem izabranaStavka = (TreeViewItem)e.NewValue;

            if (izabranaStavka != null)
            {
                prazanGrid.Children.Clear();
                TextBlock tekstBloka = new TextBlock
                {
                    Text = izabranaStavka.Header.ToString(),
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center
                };
                prazanGrid.Children.Add(tekstBloka);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


public void btnWordOpen(object sender, RoutedEventArgs e)
    {
            int index = int.Parse(((Button)e.Source).Uid);
            string fileName = fileNameList[index];  // Replace with the actual path to your Word file
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
                MessageBox.Show($"Greška prilikom otvaranja Word fajla: {ex.Message}", "Greška", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
