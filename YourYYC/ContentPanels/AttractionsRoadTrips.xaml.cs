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
    /// Interaction logic for AttractionsRoadTrips.xaml
    /// </summary>
    public partial class AttractionsRoadTrips : UserControl
    {
        public AttractionsRoadTrips()
        {
            InitializeComponent();
        }

        public void AddToItineraryButton(object sender, RoutedEventArgs e)
        {
            MainWindow window = (MainWindow)Application.Current.MainWindow;
            Button btn = (Button)sender;
            window.AddAttractionToItinerary(btn.Name);
        }
    }
}
