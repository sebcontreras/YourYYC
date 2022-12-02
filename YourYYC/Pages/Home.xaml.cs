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

namespace YourYYC.Pages
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }
        public void HomeButtonClick(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Home());
        }
        public void LanguageButtonClick(object sender, RoutedEventArgs e)
        {
            //Switcher.Switch(new Food());
        }

        public void HelpButtonClick(object sender, RoutedEventArgs e)
        {
            //Switcher.Switch(new Food());
        }
        public void PreferencesButtonClick(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Preferences());
        }
        public void AttractionsButtonClick(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Attractions());
        }
        public void EventsButtonClick(object sender, RoutedEventArgs e)
        {
            //Switcher.Switch(new Food());
        }
        public void FoodButtonClick(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Food());
        }
        public void MapButtonClick(object sender, RoutedEventArgs e)
        {
            //Switcher.Switch(new Food());
            var window = (MainWindow)Application.Current.MainWindow;
            int num = window.number;
            Trace.WriteLine("Home: The number is ", num.ToString());
            window.number++;
            Console.WriteLine("Home: The number is ", num.ToString());
        }
        public void GettingThereButtonClick(object sender, RoutedEventArgs e)
        {
            //Switcher.Switch(new Food());
        }
        public void ItineraryButtonClick(object sender, RoutedEventArgs e)
        {
            //Switcher.Switch(new Food());
        }
    }
}
