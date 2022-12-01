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
    /// Interaction logic for EmailExport.xaml
    /// </summary>
    public partial class EmailExport : Window
    {
        public EmailExport()
        {
            InitializeComponent();

            //EmailEntered send = new EmailEntered();
        }

        private void sendButton_Click(object sender, RoutedEventArgs e)
        {
            ExportClearSession clearSession = new ExportClearSession();
            Visibility = Visibility.Hidden;
            clearSession.Show();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
