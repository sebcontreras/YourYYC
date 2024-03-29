﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace YourYYC.Pages
{
    /// <summary>
    /// Interaction logic for Food.xaml
    /// </summary>
    public partial class Food : UserControl
    {
        MainWindow window;
        DispatcherTimer timer = new DispatcherTimer();
        public Food()
        {
            InitializeComponent();
            window = (MainWindow)Application.Current.MainWindow;
            ItineraryCount.Content = window.itineraryCount.ToString();
        }

        public void AddToItineraryButton(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            int newCount = window.AddRestaurantToItinerary(btn.Name);
            ItineraryCount.Content = newCount.ToString();

            btn.Visibility = Visibility.Collapsed;

            var visibleRemove = (Button)this.FindName("Remove" + btn.Name);
            visibleRemove.Visibility = Visibility.Visible;

            Button tile = (Button)this.FindName(btn.Name + "Tile");
            tile.Opacity = 0.5;

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(3);
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
            ItemMessage.Visibility = Visibility.Visible;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            ItemMessage.Visibility = Visibility.Collapsed;
        }

        public void RemoveFromItineraryButton(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            string btnName = btn.Name.Substring(6);
            int newCount = window.RemoveRestaurantFromItinerary(btnName);
            ItineraryCount.Content = newCount.ToString();

            btn.Visibility = Visibility.Collapsed;

            Button addButton = (Button)this.FindName(btnName);
            addButton.Visibility = Visibility.Visible;

            Button tile = (Button)this.FindName(btnName + "Tile");
            tile.Opacity = 1;
        }

        public void RestaurantPreviewClick(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new RestaurantsPreview());
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
