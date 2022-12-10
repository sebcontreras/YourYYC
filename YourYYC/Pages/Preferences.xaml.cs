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
using System.Diagnostics;

namespace YourYYC.Pages
{
    /// <summary>
    /// Interaction logic for Preferences.xaml
    /// </summary>
    public partial class Preferences : UserControl
    {
        MainWindow window;
        List<string> selectedPreferences;
        List<string> selectedTripDuration;
        List<List<string>> attractions;
        List<List<string>> attractionList;
        public Preferences()
        {
            InitializeComponent();
            window = (MainWindow)Application.Current.MainWindow;
            selectedPreferences = window.selectedPreferences;
            attractions = window.attractions;
            attractionList = window.attractionList;
            selectedTripDuration = window.selectedTripDuration;
            SetPreferences();
            SetAttractionList();
        }

        public void SetPreferences()
        {
            foreach(string s in selectedPreferences)
            {
                Button btn = this.FindName(s) as Button;
                PreferenceOnStyle(btn);
            }

        }

        public void ClearPreferences()
        {
            foreach(string s in selectedPreferences)
            {
                Button btn = this.FindName(s) as Button;
                PreferenceOffStyle(btn);
            }
            selectedPreferences.Clear();
        }

        public void ClearSelectedTripDuration()
        {
            foreach (string s in selectedTripDuration)
            {
                Button btn = this.FindName(s) as Button;
                PreferenceOffStyle(btn);
            }
            selectedTripDuration.Clear();
        }

        public void SetAttractionList()
        {
            attractionList.Clear();
            for (int i = 0; i < attractions.Count; i++)
            {
                if (selectedPreferences.Contains(attractions[i][0]))
                {
                    attractionList.Add(attractions[i]);
                }
            }

            for (int i = 0; i < attractionList.Count; i++)
            {
                Trace.WriteLine(attractionList[i][0]);
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
            
            if (window.selectedPreferences.Contains(btn.Name.ToString()))
            {
                PreferenceOffStyle(btn);
                selectedPreferences.Remove(btn.Name.ToString());
            } else {
                PreferenceOnStyle(btn);
                selectedPreferences.Add(btn.Name.ToString());
            }
            SetAttractionList();
        }

        public void SelectTripDurationClick(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;

            if (window.selectedTripDuration.Contains(btn.Name.ToString()))
            {
                PreferenceOffStyle(btn);
                selectedTripDuration.Remove(btn.Name.ToString());
            }
            else
            {
                PreferenceOnStyle(btn);
                selectedTripDuration.Add(btn.Name.ToString());
            }
        }

        public void DoneButtonClick(object sender, RoutedEventArgs e)
        {
            SetAttractionList();
            Switcher.GoBack();
        }

        public void ClearAllButtonClick(object sender, RoutedEventArgs e)
        {
            ClearPreferences();
            ClearSelectedTripDuration();
            SetPreferences();
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
