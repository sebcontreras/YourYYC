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
using System.Windows.Shapes;

namespace YourYYC
{
    /// <summary>
    /// Interaction logic for ExportClearSession.xaml
    /// </summary>
    public partial class ExportClearSession : Window
    {
        public ExportClearSession()
        {
            InitializeComponent();
        }

        // starts new session by openning preferences in new window
        private void newSession(object sender, RoutedEventArgs e)
        {
            Preferences newSession = new Preferences();
            Visibility = Visibility.Hidden;
            newSession.Show();
        }
    }
}
