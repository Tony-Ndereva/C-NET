﻿using System.Windows;
using System.Windows.Controls;

namespace WpfAppDemo
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                MessageBox.Show(button.ActualHeight.ToString());
            }
            MessageBox.Show("Hello world!");
        }
    }
}
