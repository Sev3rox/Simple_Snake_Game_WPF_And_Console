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

namespace Snake
{
    /// <summary>
    /// Interaction logic for EndGamePage.xaml
    /// </summary>
    public partial class EndGamePage : Page
    {
        public Koniecgry kon;
        public EndGamePage(int res)
        {
           
            InitializeComponent();
            result.Content ="Twój Wynik: "+ res.ToString();
            kon = new Koniecgry(res);
        }

        private void NieZapisuj(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new MenuPage());
        }

        private void Zapisz(object sender, RoutedEventArgs e)
        {
            kon.dodawanie(nick.Text);
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new MenuPage());
        }
    }
}
