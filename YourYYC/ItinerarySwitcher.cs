using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace YourYYC
{
    class ItinerarySwitcher
    {
        public static Itinerary1 pageSwitcher;
        public static void Switch(UserControl
        newPage)
        {
            pageSwitcher.Navigate(newPage);
        }
    }
}
