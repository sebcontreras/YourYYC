﻿using System;
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

namespace YourYYC.Pages
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Itinerary1 : UserControl
    {
        ExportPopUp _export = new ExportPopUp();
        EmailPopUp _email= new EmailPopUp();
        public Itinerary1()
        {
            InitializeComponent();
        }

        private void exportButton_Click(object sender, RoutedEventArgs e)
        {
            //mainPanel.Children.Clear();
            //mainPanel.Children.Add(_export);
            Switcher.Switch(new ExportPopUp());
        }
    }
}