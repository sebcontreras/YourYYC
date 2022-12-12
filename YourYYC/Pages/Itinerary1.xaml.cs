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

namespace YourYYC.Pages
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Itinerary1 : UserControl
    {
        MainWindow window;
        List<string> itemNames= new List<string>();

        public Itinerary1()
        {
            InitializeComponent();
            this.DataContext = this;
            window = (MainWindow)Application.Current.MainWindow;
            setScreen();
        }

        public void setScreen()
        {
            ItineraryCount.Content = window.itineraryCount.ToString();
            ItineraryCount2.Content = window.itineraryCount.ToString();

            if (window.itineraryCount > 0)
            {
                //SuggestedItems.Visibility = Visibility.Visible;
                //SuggestedTitle.Visibility = Visibility.Visible;
                EmptyMessage.Visibility = Visibility.Collapsed;
                ScrollView.Visibility = Visibility.Visible;
            }

            int i = 1;
            foreach (var tile in window.itineraryList)
            {
                String itemName = "attraction" + i.ToString();
                var newItem = (Canvas)this.FindName(itemName);
                var newItemImage = (Image)this.FindName(itemName + "Image");
                var newItemRemove = (Button)this.FindName(itemName + "Remove");

                newItem.Visibility = Visibility.Visible;
                newItem.Name = tile[0];
                newItemImage.Source = new BitmapImage(new Uri(tile[2], UriKind.Relative));
                newItemRemove.Name = "Remove" + tile[0];
                itemNames.Add(itemName);

                i++;

                if (i > 8) break;
            }
        }

        private void exportButton_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new ExportPopUp());
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

        private void ClearAllClick(object sender, RoutedEventArgs e)
        {
            ClearAll();
        }

        public void ClearAll()
        {
            foreach (var item in itemNames)
            {
                var btn = (Canvas)this.FindName(item);
                var img = (Image)this.FindName(item + "Image");

                btn.Name = btn.Tag.ToString();
                btn.Visibility = Visibility.Collapsed;
                img.Name = img.Tag.ToString();
            }

            //SuggestedItems.Visibility = Visibility.Collapsed;
            //SuggestedTitle.Visibility = Visibility.Collapsed;
            ScrollView.Visibility = Visibility.Collapsed;
            EmptyMessage.Visibility = Visibility.Visible;

            window.itineraryList.Clear();
            window.itineraryCount = 0;
            ItineraryCount.Content = 0;
            ItineraryCount2.Content = 0;
        }

        public void RemoveFromItineraryButton(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            string btnName = btn.Name.Substring(6);
            int newCount = window.RemoveGenericFromItinerary(btnName);
            ItineraryCount.Content = newCount.ToString();

            // ClearAll();
            // setScreen();
            Switcher.Switch(new Itinerary1());
        }

        public void AddToItineraryButton(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            string btnName = btn.Name;
            window.AddGenericToItinerary(btnName);
            var tile = (Canvas)this.FindName(btnName + "Tile");
            tile.Visibility = Visibility.Collapsed;

            setScreen();
            // Switcher.Switch(new Itinerary1());
        }
    }
}
