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
        public Attractions()
        {
            InitializeComponent();
            window = (MainWindow)Application.Current.MainWindow;
            attractionList = window.attractionList;
            selectedPreferences = window.selectedPreferences;
            preferences = window.preferences;
            SetTiles();
        }

        public void SetTiles()
        {
            if (selectedPreferences.Count == 0)
            {
                ContainerPanel.Children.Add(art);
                ContainerPanel.Children.Add(nature);
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

        }

        public void SetTiles3()
        {
            TextBlock text = new TextBlock();
            text.Text = "REEEEEEEE";
            text.FontSize = 36;
            text.Width = 1297;
            ContainerPanel.Children.Add(text);

            //StackPanel = new StackPanel();
            AttractionsNature nature = new AttractionsNature();
            AttractionsArt art = new AttractionsArt();
            ContainerPanel.Children.Add(nature);
            ContainerPanel.Children.Add(art);
        }

        public void SetTiles2()
        {
            // NatureSection
            // loop through preferences
            // if preferences does not exist in selected
            // make invisible
            // StackPanel testPanel = this.FindName("testPanel") as StackPanel;
            // testPanel.Cont
            TextBlock text = new TextBlock();
            text.Text = "REEEEEEEE";
            text.FontSize = 36;
            text.Width = 1297;
            // testPanel.Children.Add(text);
            //if (selectedPreferences.Count == 0) { return; }
            //foreach (string p in preferences)
            //{
            //    if (selectedPreferences.Contains(p))
            //    {
            //        StackPanel sp = this.FindName(p) as StackPanel;
            //        Button btn = new Button();
            //        TextBlock text = new TextBlock();
            //        text.Text = "Nature";
            //        text.FontSize = 36;
            //        text.Width = 1297;
            //        btn.Content = "Hello button";
            //        if (sp != null)
            //        {
            //            testPanel.Children.Add(text);
            //            testPanel.Children.Add(btn);
            //            sp.Children.Add(btn);
            //            sp.Children.Add(text);
            //            // sp.Visibility = Visibility.Collapsed;
            //        }
            //    }
            //}

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
    }
}

