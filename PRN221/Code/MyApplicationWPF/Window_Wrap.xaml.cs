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

namespace MyApplicationWPF
{
    /// <summary>
    /// Interaction logic for Window_Wrap.xaml
    /// </summary>
    public partial class Window_Wrap : Window
    {
        public Window_Wrap()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, RoutedEventArgs e)
        {
            string carInfo = "Car Name: " + txtCarName.Text + "\n"
                + "Car Color: " + txtColor.Text + "\n"
                + "Car Brand: " + txtBrand.Text + "\n"
                ;
            MessageBox.Show(carInfo, "Car Infomation");
        }
    }
}
