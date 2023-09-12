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

namespace Opgave2
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

        private void topButton_Click(object sender, RoutedEventArgs e)
        {
            var temp = lbl1.Content.ToString();
            lbl1.Content = lbl2.Content.ToString();
            lbl2.Content = temp;
        }

        private void BottomButton_Click(object sender, RoutedEventArgs e)
        {
            var temp = lbl3.Content.ToString();
            lbl3.Content = lbl4.Content.ToString();
            lbl4.Content = temp;
        }
    }
}
