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
using System.Windows.Threading;

namespace YourYYC.Pages
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : UserControl
    {
        MainWindow window;
        DispatcherTimer timer = new DispatcherTimer();
        int counter = 0;
        public Home()
        {
            InitializeComponent();
            window = (MainWindow)Application.Current.MainWindow;
            ItineraryCount.Content = window.itineraryCount.ToString();
            //autoImgChange();
        }
        public async Task autoImgChange()
        {
            int c = await wait();
            //timer.Interval = TimeSpan.FromSeconds(4);
            //timer.Tick += new EventHandler(timer_Tick);
            //timer.Start();
        }

        public async Task<int> wait()
        {
            await Task.Delay(4000);
            counter++;            
            ImageBrush img = new ImageBrush();
            if (counter % 2 == 0)
                img.ImageSource = new BitmapImage(new Uri("../../../images/MainBackground2.png", UriKind.Relative));
            else
                img.ImageSource = new BitmapImage(new Uri("../../../images/MainBackground.png", UriKind.Relative));
            HomeMain.Background = img;
            return counter;
        }

        private void timer_Tick(object? sender, EventArgs e)
        {
            timer.Stop();
            counter++;
            ImageBrush img = new ImageBrush();
            if(counter%2 == 0)
                img.ImageSource = new BitmapImage(new Uri("../../../images/MainBackground2.png", UriKind.Relative));
            else
                img.ImageSource = new BitmapImage(new Uri("../../../images/MainBackground.png", UriKind.Relative));
            HomeMain.Background = img;
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
