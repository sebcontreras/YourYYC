using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    /// Interaction logic for CityMapMedium.xaml
    /// </summary>
    public partial class CityMapSmall : UserControl
    {
        MainWindow window;
        public CityMapSmall()
        {
            InitializeComponent();
            window = (MainWindow)Application.Current.MainWindow;
            ItineraryCount.Content = window.itineraryCount.ToString();
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

        private void DowntownPinClick(object sender, RoutedEventArgs e)
        {
            InglewoodSelected.Visibility = Visibility.Hidden;
            PopUp.Visibility = Visibility.Visible;
            DowntownSelected.Visibility = Visibility.Visible;
        }

        private void InglewoodPinClick(object sender, RoutedEventArgs e)
        {
            DowntownSelected.Visibility = Visibility.Hidden;
            PopUp.Visibility = Visibility.Visible;
            InglewoodSelected.Visibility = Visibility.Visible;
        }


        private void ZoomOutClick(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new CityMapMedium());
        }

        private void SideBarAttractionsClick(object sender, RoutedEventArgs e)
        {
            SideBarEventsTile.Visibility = Visibility.Collapsed;
            SideBarFoodTile.Visibility = Visibility.Collapsed;
        }

        private void SideBarEventsClick(object sender, RoutedEventArgs e)
        {
            SideBarAttractionsTile.Visibility = Visibility.Collapsed;
            SideBarFoodTile.Visibility = Visibility.Collapsed;
        }

        private void SideBarFoodClick(object sender, RoutedEventArgs e)
        {
            SideBarEventsTile.Visibility = Visibility.Collapsed;
            SideBarAttractionsTile.Visibility = Visibility.Collapsed;
        }
    }
}
