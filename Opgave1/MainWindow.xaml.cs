﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Opgave1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            btn2.Content = "Clicked";
        }

        private void cBox_Checked_1(object sender, RoutedEventArgs e)
        {
            btn2.Visibility = Visibility.Visible;
        }

        private void cBox_Unchecked(object sender, RoutedEventArgs e)
        {
            btn2.Visibility= Visibility.Collapsed;
        }
    }
}
