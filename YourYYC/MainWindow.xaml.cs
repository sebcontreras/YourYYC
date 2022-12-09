using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : NavigationWindow
    {
        // All of the possible preferences
        public List<string> preferences = new List<string> {"Sightseeing", "Art", "Nature", "Science", "History", "Shopping",
            "PartyMusic", "RoadTrips", "FamilyFriendly" };

        // When a user selects a preference, it will be added to this list
        // eg. selectedPreferences might have {"Art", "Road Trips"}
        public List<string> selectedPreferences = new List<string>();

        public List<string[]> itineraryList = new List<string[]>();

        public List<List<string>> attractions = new List<List<string>>
        {
            new List<string> {"Nature", "../images/tiles/nature/bird_sanctuary.png", "url"},
            new List<string> {"Nature", "../images/tiles/nature/bowness_park.png", "url"},
            new List<string> {"Nature", "../images/tiles/nature/calgary_zoo.png", "url"},
            new List<string> {"Nature", "../images/tiles/nature/edworthy_park.png", "url"},
            new List<string> {"Nature", "../images/tiles/nature/princess_island_park.png", "url"},
            new List<string> {"Nature", "../images/tiles/downtown_calgary/peace_bridge.png", "url"},
            new List<string> {"FamilyFriendly", "../images/tiles/fun_for_the_family/calaway_park.png", "url"},
            new List<string> {"FamilyFriendly", "../images/tiles/fun_for_the_family/calgary_tower.png", "url"},
            new List<string> {"FamilyFriendly", "../images/tiles/fun_for_the_family/calgary_zoo.png", "url"},
            new List<string> {"FamilyFriendly", "../images/tiles/fun_for_the_family/heritage_park.png", "url"},
            new List<string> {"FamilyFriendly", "../images/tiles/fun_for_the_family/princess_island_park.png", "url"},
            new List<string> {"FamilyFriendly", "../images/tiles/fun_for_the_family/winsport_park.png", "url"},
            new List<string> {"RoadTrips", "../images/tiles/around_calgary/banff.png", "url"},
            new List<string> {"RoadTrips", "../images/tiles/around_calgary/drumheller.png", "url"},
            new List<string> {"RoadTrips", "../images/tiles/around_calgary/jasper.png", "url"},
            new List<string> {"RoadTrips", "../images/tiles/around_calgary/kananaskis.png", "url"},
            new List<string> {"RoadTrips", "../images/tiles/around_calgary/waterton.png", "url"},
            new List<string> {"PartyMusic", "../images/tiles/happening_this_week/class_albums_live.png", "url"},
            new List<string> {"PartyMusic", "../images/tiles/happening_this_week/live_country_music.png", "url"},
            new List<string> {"Shopping", "../images/tiles/downtown_calgary/core_shopping_center.png", "url"},
            new List<string> {"Shopping", "../images/tiles/downtown_calgary/stephen_ave.png", "url"},
            new List<string> {"History", "../images/tiles/downtown_calgary/glenbow_museum.png", "url"},
            new List<string> {"History", "../images/tiles/fun_for_the_family/heritage_park.png", "url"},
            new List<string> {"History", "../images/tiles/downtown_calgary/studio_bell.png", "url"},
            new List<string> {"Science", "../images/tiles/downtown_calgary/telus_spark.png", "url"},
            new List<string> {"Science", "../images/tiles/downtown_calgary/central_library.png", "url"},
            new List<string> {"Art", "../images/tiles/downtown_calgary/arts_commons.png", "url"},
            new List<string> {"Art", "../images/tiles/downtown_calgary/studio_bell.png", "url"},
        };

        public List<List<string>> attractionList = new List<List<string>>();

        /**
         * Possible logic for using preferences to populate
         * 
         * Loop through preferences:
         *  if selectedPreferences has the current preference:
         *      add this section to events page
         */

        public MainWindow()
        {
            InitializeComponent();
            Switcher.pageSwitcher = this;
            Switcher.Switch(new Home());
        }

        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }

        public void Back() 
        {
            if (this.CanGoBack)
            {
                this.GoBack();
            }
        }

    }
}
