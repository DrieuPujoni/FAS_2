﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace SilverlightSite
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnVideo_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Thank you for your feedback");
            Page1 pg = new Page1();

            LayoutRoot.Children.Clear();

            LayoutRoot.Children.Add(pg);
        }

    }
}
