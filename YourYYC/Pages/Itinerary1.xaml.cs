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

        public Itinerary1()
        {
            InitializeComponent();
            window = (MainWindow)Application.Current.MainWindow;

            int i = 1;
            foreach (var tile in window.itineraryList)
            {
                String itemName = "attraction" + i.ToString();
                var newItem = (Button)this.FindName(itemName);
                var newItemImage = (Image)this.FindName(itemName + "Image");

                newItem.Visibility = Visibility.Visible;
                newItem.Name = tile[0];                
                newItemImage.Source = new BitmapImage(new Uri(tile[2]));

                i++;

                if (i > 8) break;
            }
        }

        private void exportButton_Click(object sender, RoutedEventArgs e)
        {
            //mainPanel.Children.Clear();
            //mainPanel.Children.Add(_export);
            Switcher.Switch(new ExportPopUp());
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

        private void ClearAllClick(object sender, RoutedEventArgs e)
        {
            int i = 1;
            foreach (var tile in window.itineraryList)
            {
                String itemName = "attraction" + i.ToString();
                var newItem = (Button)this.FindName(itemName);
                var newItemImage = (Image)this.FindName(itemName + "Image");

                newItem.Visibility = Visibility.Visible;
                newItem.Name = tile[0];
                newItemImage.Source = new BitmapImage(new Uri(tile[2]));

                i++;

                if (i > 8) break;
            }
            /*
            for (int i = 0; i < 8; i++)
            {
                String itemName = "attraction" + i.ToString();
                var newItem = (Button)this.FindName(itemName);
                newItem.Visibility = Visibility.Collapsed;

                // add later with images
                //var newItemImage = (Button)this.FindName(itemName + "Image");
                //newItemImage.SourceUpdated
            }
            */
        }
    }
}
