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
using System.Windows.Navigation;
using System.Windows.Shapes;
using YourYYC.Pages;

namespace YourYYC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // private Page foodPage;
        private Food food  = new Food();
        // private Home home = new Home();
        // private NavigationService navigationService;

        // public static RoutedEventHandler

        public MainWindow()
        {
            InitializeComponent();
            Switcher.pageSwitcher = this;
            Switcher.Switch(new Home());
            // foodPage= new Food();
            // navigationService = new NavigationService();
        }

        public void Navigate(UserControl nextPage)
        {
            this.Content= nextPage;
        }

        public void FoodButtonClick(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(food);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OnClickFood(object sender, RoutedEventArgs e)
        {
            //this.NavigationService.Navigate(foodPage);
        }
    }
}
