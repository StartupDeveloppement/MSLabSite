using System.Windows;
using MSLab.WPF.Business;

namespace MSLab.WPF.UI
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonWhatTime_Click(object sender, RoutedEventArgs e)
        {
            var demo = new DemoService();
            LabelTime.Content = string.Format("{0:MM/dd/yy H:mm:ss}", demo.WhatTimeIsIt());
        }
    }
}