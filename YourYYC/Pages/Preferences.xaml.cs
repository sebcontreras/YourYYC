using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;
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
    /// Interaction logic for Preferences.xaml
    /// </summary>
    public partial class Preferences : UserControl
    {
        MainWindow window;
        List<string> preferences;
        public Preferences()
        {
            InitializeComponent();
            window = (MainWindow)Application.Current.MainWindow;
            preferences = window.selectedPreferences;
            SetPreferences();
        }

        public void SetPreferences()
        {
            foreach(string s in preferences)
            {
                Button btn = this.FindName(s) as Button;
                PreferenceOnStyle(btn);
            }

        }

        public void PreferenceOnStyle(Button btn)
        {
            btn.Background = (Brush)new BrushConverter().ConvertFromString("#D94539");
            btn.Foreground = new SolidColorBrush(Colors.White);
        }

        public void PreferenceOffStyle(Button btn)
        {
            btn.Background = (Brush)new BrushConverter().ConvertFromString("#FFEDEDED");
            btn.Foreground = new SolidColorBrush(Colors.Black);
        }

        public void SelectPreferenceClick(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            
            if (window.selectedPreferences.Contains(btn.Content))
            {
                PreferenceOffStyle(btn);
                preferences.Remove(btn.Content.ToString());
            } else {
                PreferenceOnStyle(btn);
                preferences.Add(btn.Content.ToString());
            }
        }

        // Dock Buttons

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
            //Switcher.Switch(new Food());
        }
        public void BackButtonClick(object sender, RoutedEventArgs e)
        {
            Switcher.GoBack();
        }
    }
}
