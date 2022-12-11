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

        public int itineraryCount { get; set; }

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

        public void SetTiles()
        {
            if (selectedPreferences.Count == 0)
            {
                ContainerPanel.Children.Add(art);
                ContainerPanel.Children.Add(nature);
                ContainerPanel.Children.Add(familyFriendly);
                // add remaining attractions
                return;
            }
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
            // Add remaining attractions here
        }

        public void AddToItineraryButton(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            int newCount = window.AddAttractionToItinerary(btn.Name);
            ItineraryCount.Content = newCount.ToString();
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
            //Switcher.Switch(new Food());
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

