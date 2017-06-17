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

namespace WpfApp1
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Liczymy liczenie = new Liczymy();
        bool gdzieWpisac = true;
        bool czyWyczyscicPasekWyniku = false;

        private void liczba_Click(object sender, RoutedEventArgs e)
        {
            if (czyWyczyscicPasekWyniku)
                pasekWyniku.Text = (sender as Button).Content.ToString();
            else
                pasekWyniku.Text += (sender as Button).Content.ToString();
            czyWyczyscicPasekWyniku = false;
        }

        private void przecinek_Click(object sender, RoutedEventArgs e)
        {
            if (czyWyczyscicPasekWyniku)
                pasekWyniku.Text = "0,";
            else
                pasekWyniku.Text += ",";
            czyWyczyscicPasekWyniku = false;
        }
        private void POWIE(object sender, RoutedEventArgs e)
        {
            pasekWyniku.Text = "Kocham Agnieszke";
            czyWyczyscicPasekWyniku = false;
        }

        private void dzialanie_Click(object sender, RoutedEventArgs e)
        {
            liczenie.dzialanie = (sender as Button).Content.ToString()[0];
            czyWyczyscicPasekWyniku = true;//czyścimy pasek tekstowy
            gdzieWpisac = false;
        }
        private void silnia_Click(object sender, RoutedEventArgs e)
        {

            liczenie.dzialanie = '!';
            gdzieWpisac = true;
            liczenie.a = liczenie.licz();
            pasekWyniku.Text = liczenie.a.ToString();//wyświetlamy wynik
            czyWyczyscicPasekWyniku = true;
        }
        private void pasekWyniku_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (gdzieWpisac)
                    liczenie.a = double.Parse(pasekWyniku.Text);
                else
                    liczenie.b = double.Parse(pasekWyniku.Text);
            }
            catch (FormatException )//jeśli wprowadzono błędnie liczbę wykonuje poniższy kod
            {
                if (pasekWyniku.Text != "")
                    MessageBox.Show("I masz wirusa LoL :p", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);//komunikat o błędzie, ale tylko, jeśli pole nie jest puste
            }
        }

        private void czyszczenie_Click(object sender, RoutedEventArgs e)
        {
            liczenie.a = liczenie.b = 0;
            liczenie.dzialanie = ' ';
            pasekWyniku.Text = "";
            czyWyczyscicPasekWyniku = false;
            gdzieWpisac = true;
        }

        private void systemBinarny_Click(object sender, RoutedEventArgs e)
        {
            pasekWyniku.Text = Convert.ToString((int)liczenie.a, 2);
        }

        private void rowna_Click(object sender, RoutedEventArgs e)
        {
            pasekWyniku.Text = liczenie.licz().ToString();
            czyWyczyscicPasekWyniku = false;
        }
    }
}
