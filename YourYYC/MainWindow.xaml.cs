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

        public List<string> tripDuration = new List<string> {"TwoToThreeDays", "OneWeek", "TwoWeeks", "ILiveHere"};

        // When a user selects a preference, it will be added to this list
        // eg. selectedPreferences might have {"Art", "Road Trips"}
        // public List<string> selectedPreferences = new List<string>();
        // TEMPORARY MOCK FOR TESTING PURPOSES
        public List<string> selectedPreferences = new List<string>();

        public string selectedTripDuration;

        public List<List<string>> itineraryList = new List<List<string>>();

        public int itineraryCount = 0;

        public List<List<string>> attractions = new List<List<string>>
        {
            new List<string> {"BirdSanctuary", "Nature", "../images/tiles/nature/bird_sanctuary.png", "url"},
            new List<string> {"BownessPark", "Nature", "../images/tiles/nature/bowness_park.png", "url"},
            new List<string> {"CalgaryZoo", "Nature", "../images/tiles/nature/calgary_zoo.png", "url"},
            new List<string> {"EdworthyPark", "Nature", "../images/tiles/nature/edworthy_park.png", "url"},
            new List<string> {"PrincessIslandPark", "Nature", "../images/tiles/nature/princess_island_park.png", "url"},
            new List<string> {"PeaceBridge", "Nature", "../images/tiles/downtown_calgary/peace_bridge.png", "url"},
            new List<string> {"CalgaryPark", "FamilyFriendly", "../images/tiles/fun_for_the_family/calaway_park.png", "url"},
            new List<string> {"CalgaryTower", "FamilyFriendly", "../images/tiles/fun_for_the_family/calgary_tower.png", "url"},
            new List<string> {"CalgaryZoo2", "FamilyFriendly", "../images/tiles/fun_for_the_family/calgary_zoo.png", "url"},
            new List<string> {"HeritagePark", "FamilyFriendly", "../images/tiles/fun_for_the_family/heritage_park.png", "url"},
            new List<string> {"PrincessIslandPark2", "FamilyFriendly", "../images/tiles/fun_for_the_family/princess_island_park.png", "url"},
            new List<string> {"WinsportPark", "FamilyFriendly", "../images/tiles/fun_for_the_family/winsport_park.png", "url"},
            new List<string> {"Banff", "RoadTrips", "../images/tiles/around_calgary/banff.png", "url"},
            new List<string> {"Drumheller", "RoadTrips", "../images/tiles/around_calgary/drumheller.png", "url"},
            new List<string> {"Jasper", "RoadTrips", "../images/tiles/around_calgary/jasper.png", "url"},
            new List<string> {"Kananaskis", "RoadTrips", "../images/tiles/around_calgary/kananaskis.png", "url"},
            new List<string> {"Waterton", "RoadTrips", "../images/tiles/around_calgary/waterton.png", "url"},
            new List<string> {"ClassAlbumsLive", "PartyMusic", "../images/tiles/happening_this_week/class_albums_live.png", "url"},
            new List<string> {"LiveCountryMusic", "PartyMusic", "../images/tiles/happening_this_week/live_country_music.png", "url"},
            new List<string> {"CoreShoppingCenter", "Shopping", "../images/tiles/downtown_calgary/core_shopping_center.png", "url"},
            new List<string> {"StephenAve", "Shopping", "../images/tiles/downtown_calgary/stephen_ave.png", "url"},
            new List<string> {"GlenbowMuseum", "History", "../images/tiles/downtown_calgary/glenbow_museum.png", "url"},
            new List<string> {"HeritagePark2", "History", "../images/tiles/fun_for_the_family/heritage_park.png", "url"},
            new List<string> {"StudioBell", "History", "../images/tiles/downtown_calgary/studio_bell.png", "url"},
            new List<string> {"TelusSpark", "Science", "../images/tiles/downtown_calgary/telus_spark.png", "url"},
            new List<string> {"CentralLibrary", "Science", "../images/tiles/downtown_calgary/central_library.png", "url"},
            new List<string> {"ArtsCommons", "Art", "../images/tiles/downtown_calgary/arts_commons.png", "url"},
            new List<string> {"StudioBell2", "Art", "../images/tiles/downtown_calgary/studio_bell.png", "url"},
        };

        public List<List<string>> restaurants = new List<List<string>>
        {
            new List<string> {"DeaneHouse", "MustTry", "../images/tiles/restaurants/deane_house.png", "url"},
            new List<string> {"Charcut", "MustTry", "../images/tiles/restaurants/charcut.png", "url"},
            new List<string> {"Rouge", "MustTry", "../images/tiles/restaurants/rouge.png", "url"},
            new List<string> {"RiverCafe", "MustTry", "../images/tiles/restaurants/river_cafe.png", "url"},
            new List<string> {"ComeryBlock", "BBQ", "../images/tiles/restaurants/bbq/comery_block.png", "url"},
            new List<string> {"Cowtown", "BBQ", "../images/tiles/restaurants/bbq/cowtown.png", "url"},
            new List<string> {"Palamino", "BBQ", "../images/tiles/restaurants/bbq/palamino.png", "url"},
            new List<string> {"BigT", "BBQ", "../images/tiles/restaurants/bbq/bigT.png", "url"},
        };

        public List<List<string>> events = new List<List<string>>
        {
            new List<string> {"DisneyOnIce", "ThisWeek", "../images/tiles/happening_this_week/disney.png", "url"},
            new List<string> {"ArtExhibition", "ThisWeek", "../images/tiles/happening_this_week/art_exhibition.png", "url"},
            new List<string> {"Opera", "ThisWeek", "../images/tiles/happening_this_week/opera.png", "url"},
            new List<string> {"ClassAlbumsLive", "ThisWeek", "../images/tiles/happening_this_week/class_albums_live.png", "url"},
            new List<string> {"LiveCountryMusic", "ThisWeek", "../images/tiles/happening_this_week/live_country_music.png", "url"},
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
            Switcher.Switch(new Preferences());
            ShowsNavigationUI = false;
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

        public void ClearState()
        {
            itineraryCount = 0;
            itineraryList = new List<List<string>>();
            selectedPreferences = new List<string>();
            selectedTripDuration = "";
        }

        public int AddAttractionToItinerary(string newItem)
        {
            foreach (var tile in attractions)
            {
                    if (tile.Contains(newItem) && !itineraryList.Contains(tile)) {
                        itineraryList.Add(tile);
                        itineraryCount = itineraryList.Count();
                        break;
                    }
            }
            return itineraryCount;
        }

        public int RemoveAttractionFromItinerary(string item)
        {
            foreach (var tile in attractions)
            {
                if (tile.Contains(item) && itineraryList.Contains(tile))
                {
                    itineraryList.Remove(tile);
                    itineraryCount = itineraryList.Count();
                    break;
                }
            }
            return itineraryCount;
        }

        public int AddRestaurantToItinerary(string newItem)
        {
            foreach (var tile in restaurants)
            {
                if (tile.Contains(newItem) && !itineraryList.Contains(tile))
                {
                    itineraryList.Add(tile);
                    itineraryCount = itineraryList.Count();
                    break;
                }
            }
            return itineraryCount;
        }

        public int RemoveRestaurantFromItinerary(string item)
        {
            foreach (var tile in restaurants)
            {
                if (tile.Contains(item) && itineraryList.Contains(tile))
                {
                    itineraryList.Remove(tile);
                    itineraryCount = itineraryList.Count();
                    break;
                }
            }
            return itineraryCount;
        }

        public int AddEventsToItinerary(string newItem)
        {
            foreach (var tile in events)
            {
                if (tile.Contains(newItem) && !itineraryList.Contains(tile))
                {
                    itineraryList.Add(tile);
                    itineraryCount = itineraryList.Count();
                    break;
                }
            }
            return itineraryCount;
        }

        public int RemoveEventsFromItinerary(string item)
        {
            foreach (var tile in events)
            {
                if (tile.Contains(item) && itineraryList.Contains(tile))
                {
                    itineraryList.Remove(tile);
                    itineraryCount = itineraryList.Count();
                    break;
                }
            }
            return itineraryCount;
        }

        public int RemoveGenericFromItinerary(string item)
        {
            foreach (var tile in events)
            {
                if (tile.Contains(item) && itineraryList.Contains(tile))
                {
                    itineraryList.Remove(tile);
                    itineraryCount = itineraryList.Count();
                    break;
                }
            }
            foreach (var tile in restaurants)
            {
                if (tile.Contains(item) && itineraryList.Contains(tile))
                {
                    itineraryList.Remove(tile);
                    itineraryCount = itineraryList.Count();
                    break;
                }
            }
            foreach (var tile in attractions)
            {
                if (tile.Contains(item) && itineraryList.Contains(tile))
                {
                    itineraryList.Remove(tile);
                    itineraryCount = itineraryList.Count();
                    break;
                }
            }
            return itineraryCount;
        }

        public int AddGenericToItinerary(string newItem)
        {
            foreach (var tile in events)
            {
                if (tile.Contains(newItem) && !itineraryList.Contains(tile))
                {
                    itineraryList.Add(tile);
                    itineraryCount = itineraryList.Count();
                    break;
                }
            }
            foreach (var tile in restaurants)
            {
                if (tile.Contains(newItem) && !itineraryList.Contains(tile))
                {
                    itineraryList.Add(tile);
                    itineraryCount = itineraryList.Count();
                    break;
                }
            }
            foreach (var tile in attractions)
            {
                if (tile.Contains(newItem) && !itineraryList.Contains(tile))
                {
                    itineraryList.Add(tile);
                    itineraryCount = itineraryList.Count();
                    break;
                }
            }
            return itineraryCount;
        }

    }
}
