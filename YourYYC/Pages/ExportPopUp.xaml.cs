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

namespace YourYYC.Pages
{
    /// <summary>
    /// Interaction logic for ExportPopUp.xaml
    /// </summary>
    public partial class ExportPopUp : UserControl
    {
        MainWindow window;
        EmailPopUp _email = new EmailPopUp();
        TextPopUp _text = new TextPopUp();

        public ExportPopUp()
        {
            InitializeComponent();
            this.DataContext = this;
            window = (MainWindow)Application.Current.MainWindow;
        }

        private void emailButton_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new EmailPopUp());
            //exportGrid.Children.Clear();
            //exportGrid.Children.Add(_email);
        }

        private void textButton_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new TextPopUp());
            //exportGrid.Children.Clear();
            //exportGrid.Children.Add(_text);
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Itinerary1());
            //exportGrid.Children.Clear();
        }

        private void clearSessionButton_Click(object sender, RoutedEventArgs e)
        {
            // Preferences newSession = new Preferences();
            // Visibility = Visibility.Hidden;
            // newSession.Show();
            Switcher.Switch(new ConfirmClearSession());
        }
    }
}
