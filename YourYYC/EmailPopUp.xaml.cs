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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace YourYYC
{
    /// <summary>
    /// Interaction logic for EmailPopUp.xaml
    /// </summary>
    public partial class EmailPopUp : UserControl
    {
        ExportClearSession _clearSession = new ExportClearSession();
        public EmailPopUp()
        {
            InitializeComponent();
        }

        private void sendButton_Click(object sender, RoutedEventArgs e)
        {
            emailGrid.Children.Clear();
            emailGrid.Children.Add(_clearSession);
        }

        private void cancelButton_click(object sender, RoutedEventArgs e)
        {
            emailGrid.Children.Clear();
        }
    }
}