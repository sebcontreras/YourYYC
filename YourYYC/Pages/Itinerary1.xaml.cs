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
            ItineraryCount.Content = window.itineraryCount.ToString();

            int i = 1;
            foreach (var tile in window.itineraryList)
            {
                String itemName = "attraction" + i.ToString();
                var newItem = (Canvas)this.FindName(itemName);
                var newItemImage = (Image)this.FindName(itemName + "Image");

                newItem.Visibility = Visibility.Visible;
                newItem.Name = tile[0];
                newItemImage.Source = new BitmapImage(new Uri(tile[2], UriKind.Relative));

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
                String rename = "attraction" + i.ToString();
                var removeItem = (Canvas)this.FindName(tile[0]);
                removeItem.Name = rename;
                removeItem.Visibility= Visibility.Collapsed;

                i++;

                if (i > 8) break;
            }

            window.itineraryList.Clear();
            Switcher.Switch(new Itinerary1());
        }

        public void RemoveFromItineraryButton(object sender, RoutedEventArgs e)
        {
            Canvas btn = (Canvas)sender;
            window.RemoveAttractionFromItinerary(btn.Name);

            btn.Name = btn.Tag.ToString();
            Switcher.Switch(new Itinerary1());
        }

        public void AddToItineraryButton(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            window.AddAttractionToItinerary(btn.Name);
            Switcher.Switch(new Itinerary1());
        }
    }
}
