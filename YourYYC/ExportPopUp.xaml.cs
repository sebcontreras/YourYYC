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

namespace YourYYC
{
    /// <summary>
    /// Interaction logic for ExportPopUp.xaml
    /// </summary>
    public partial class ExportPopUp : UserControl
    {
        EmailPopUp _email = new EmailPopUp();
        TextPopUp _text = new TextPopUp();

        public ExportPopUp()
        {
            InitializeComponent();
        }

        private void emailButton_Click(object sender, RoutedEventArgs e)
        {
            exportGrid.Children.Clear();
            exportGrid.Children.Add(_email);
        }

        private void textButton_Click(object sender, RoutedEventArgs e)
        {
            exportGrid.Children.Clear();
            exportGrid.Children.Add(_text);
        }

        private void cancelButton_click(object sender, RoutedEventArgs e)
        {
            exportGrid.Children.Clear();
        }

        private void clearSessionButton_Click(object sender, RoutedEventArgs e)
        {
            Preferences newSession = new Preferences();
            Visibility = Visibility.Hidden;
            newSession.Show();
        }
    }
}
