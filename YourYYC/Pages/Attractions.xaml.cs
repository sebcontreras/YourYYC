using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
    /// Interaction logic for Attractions.xaml
    /// </summary>
    public partial class Attractions : UserControl
    {
        MainWindow window;
        List<List<string>> attractionList;
        List<string> selectedPreferences;
        List<string> preferences;
        AttractionsNature nature = new AttractionsNature();
        AttractionsArt art = new AttractionsArt();
        AttractionsFamilyFriendly familyFriendly = new AttractionsFamilyFriendly();
        AttractionsRoadTrips roadTrips= new AttractionsRoadTrips();
        AttractionsPartyMusic partyMusic= new AttractionsPartyMusic();
        AttractionsShopping shopping = new AttractionsShopping();
        AttractionsHistory history= new AttractionsHistory();
        AttractionsScience science= new AttractionsScience();

        public Attractions()
        {
            InitializeComponent();
            window = (MainWindow)Application.Current.MainWindow;
            attractionList = window.attractionList;
            selectedPreferences = window.selectedPreferences;
            preferences = window.preferences;
            ItineraryCount.Content = window.itineraryCount.ToString();
            SetTiles();
        }

        public void AddRemainingTiles()
        {
            if (!selectedPreferences.Contains("Nature"))
            {
                ContainerPanel.Children.Add(nature);
            }
            if (!selectedPreferences.Contains("Art"))
            {
                ContainerPanel.Children.Add(art);
            }
            if (!selectedPreferences.Contains("FamilyFriendly"))
            {
                ContainerPanel.Children.Add(familyFriendly);
            }
            if (!selectedPreferences.Contains("RoadTrips"))
            {
                ContainerPanel.Children.Add(roadTrips);
            }
            if (!selectedPreferences.Contains("PartyMusic"))
            {
                ContainerPanel.Children.Add(partyMusic);
            }
            if (!selectedPreferences.Contains("Shopping"))
            {
                ContainerPanel.Children.Add(shopping);
            }
            if (!selectedPreferences.Contains("History"))
            {
                ContainerPanel.Children.Add(history);
            }
            if (!selectedPreferences.Contains("Science"))
            {
                ContainerPanel.Children.Add(science);
            }
        }

        public void SetTiles()
        {
            if(selectedPreferences.Contains("Nature"))
            {
                ContainerPanel.Children.Add(nature);
            }
            if (selectedPreferences.Contains("Art"))
            {
                ContainerPanel.Children.Add(art);
            }
            if (selectedPreferences.Contains("FamilyFriendly"))
            {
                ContainerPanel.Children.Add(familyFriendly);
            }
            if (selectedPreferences.Contains("RoadTrips"))
            {
                ContainerPanel.Children.Add(roadTrips);
            }
            if (selectedPreferences.Contains("PartyMusic"))
            {
                ContainerPanel.Children.Add(partyMusic);
            }
            if (selectedPreferences.Contains("Shopping"))
            {
                ContainerPanel.Children.Add(shopping);
            }
            if (selectedPreferences.Contains("History"))
            {
                ContainerPanel.Children.Add(history);
            }
            if (selectedPreferences.Contains("Science"))
            {
                ContainerPanel.Children.Add(science);
            }
            // Add remaining attractions here
            AddRemainingTiles();
        }

        public void AttractionPreviewClick(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new AttractionPreview());
        }

        public void AddToItineraryButton(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            int newCount = window.AddAttractionToItinerary(btn.Name);
            ItineraryCount.Content = newCount.ToString();

            string name = Button.NameProperty.ToString();

            var collapseAdd = (Button)this.FindName(name);
            collapseAdd.Visibility = Visibility.Collapsed;

            var visibleRemove = (Button)this.FindName("Remove" + name);
            visibleRemove.Visibility = Visibility.Visible;
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

