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
using YourYYC.Pages;

namespace YourYYC
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Events : UserControl
    {
        MainWindow window;
        public Events()
        {
            InitializeComponent();
            window = (MainWindow)Application.Current.MainWindow;
            ItineraryCount.Content = window.itineraryCount.ToString();
        }

        public void AddToItineraryButton(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            int newCount = window.AddEventsToItinerary(btn.Name);
            ItineraryCount.Content = newCount.ToString();
        }

        public void EventsPreviewClick(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new EventsPreview());
        }

        public void HomeButtonClick(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Home());
        }
        public void LanguageButtonClick(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new LanguageOption());
        }

        public void HelpButtonClick(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Help());
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
            Switcher.Switch(new Events());
        }
        public void FoodButtonClick(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Food());
        }
        public void MapButtonClick(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new CityMapLarge());
        }
        public void GettingThereButtonClick(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new GettingThere());
        }
        public void ItineraryButtonClick(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Itinerary1());
        }
        public void BackButtonClick(object sender, RoutedEventArgs e)
        {
            Switcher.GoBack();
        }
    }
}
