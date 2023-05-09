using System;
using System.Windows;
using System.Threading;
using System.Globalization;
using System.Windows.Controls;

namespace MultiLanguageHelloWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetCulture(Thread.CurrentThread.CurrentCulture.Name);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            string? tag = button!.Tag.ToString();
            if (!string.IsNullOrEmpty(tag))
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo(tag);
                DateValue.Content = DateTime.Now.ToString();
                if (tag.Equals("en-US"))
                    HelloLabel.Content = "Hello WPF at";
                else 
                    HelloLabel.Content = "Olá WPF as";
            }
        }

        private void SetCulture(string tag)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo(tag);
            DateValue.Content = DateTime.Now.ToString();
            if (tag.Equals("en-US"))
                HelloLabel.Content = "Hello WPF at";
            else
                HelloLabel.Content = "Olá WPF as";
        }
    }
}
