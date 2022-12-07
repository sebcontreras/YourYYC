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
            "Party & Music", "Road Trips", "Family Friendly" };

        // When a user selects a preference, it will be added to this list
        // eg. selectedPreferences might have {"Art", "Road Trips"}
        public List<string> selectedPreferences = new List<string>();

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
