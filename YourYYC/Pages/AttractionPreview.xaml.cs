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
using YourYYC.Pages;

namespace YourYYC
{
    /// <summary>
    /// Interaction logic for AttractionPreview.xaml
    /// </summary>
    public partial class AttractionPreview : UserControl
    {
        MainWindow window;

        public AttractionPreview()
        {
            InitializeComponent();
            window = (MainWindow)Application.Current.MainWindow;
            ItineraryCount.Content = window.itineraryCount.ToString();
        }

        public void AddToItineraryButton(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            int newCount = window.AddAttractionToItinerary(btn.Name);
            ItineraryCount.Content = newCount.ToString();
        }

        public void RemoveFromItineraryButton(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            string btnName = btn.Name.Substring(6);
            int newCount = window.RemoveAttractionFromItinerary(btnName);
            ItineraryCount.Content = newCount.ToString();

            btn.Visibility = Visibility.Collapsed;

            Button addButton = (Button)this.FindName(btnName);
            addButton.Visibility = Visibility.Visible;

            Button tile = (Button)this.FindName(btnName + "Tile");
            tile.Opacity = 1;
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
