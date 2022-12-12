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
   
    public partial class ExportConfirmation: UserControl
    {
        MainWindow window;
        public ExportConfirmation()
        {
            InitializeComponent();
            window = (MainWindow)Application.Current.MainWindow;
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new ExportPopUp());
            //exportGrid.Children.Clear();
        }

        private void clearSessionButton_Click(object sender, RoutedEventArgs e)
        {
            // Preferences newSession = new Preferences();
            // Visibility = Visibility.Hidden;
            // newSession.Show();
            window.ClearState();
            Switcher.Switch(new Preferences());
        }
    }
}
