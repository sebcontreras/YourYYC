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
            ItineraryCount.Content = window.itineraryCount.ToString();
            ItineraryCount2.Content = window.itineraryCount.ToString();

            int i = 1;
            foreach (var tile in window.itineraryList)
            {
                String itemName = "attraction" + i.ToString();
                var newItem = (Canvas)this.FindName(itemName);
                var newItemImage = (Image)this.FindName(itemName + "Image");

                newItem.Visibility = Visibility.Visible;
                newItem.Name = tile[0];
                newItemImage.Source = new BitmapImage(new Uri(tile[2], UriKind.Relative));
                itemNames.Add(itemName);

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
            foreach(var item in itemNames)
            {
                var btn = (Canvas)this.FindName(item);
                var img = (Image)this.FindName(item + "Image");

                btn.Name = btn.Tag.ToString();
                btn.Visibility = Visibility.Collapsed;
                img.Name = img.Tag.ToString();                
            }            

            window.itineraryList.Clear();
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
