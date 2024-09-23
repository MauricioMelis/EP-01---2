using System;
using System.Windows;

namespace EP_01___2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CanviarTemaClar(object sender, RoutedEventArgs e)
        {
            var theme = new ResourceDictionary();
            theme.Source = new Uri("pack://application:,,,/Themes/TemaClar.xaml");

            Application.Current.Resources.MergedDictionaries.Clear();
            Application.Current.Resources.MergedDictionaries.Add(theme);

        }
            private void CanviarTemaFosc(object sender, RoutedEventArgs e)
        {
            var theme = new ResourceDictionary();
            theme.Source = new Uri("pack://application:,,,/Themes/TemaFosc.xaml");

            Application.Current.Resources.MergedDictionaries.Clear();
            Application.Current.Resources.MergedDictionaries.Add(theme);

        }

    }
}
