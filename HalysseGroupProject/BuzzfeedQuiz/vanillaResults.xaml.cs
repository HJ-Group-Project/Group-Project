using System;
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

namespace BuzzfeedQuiz
{
    /// <summary>
    /// Interaction logic for vanillaResults.xaml
    /// </summary>
    public partial class vanillaResults : Window
    {
        public vanillaResults()
        {
            InitializeComponent();

            string imgUrl = "https://www.google.com/url?sa=i&source=images&cd=&ved=2ahUKEwiK0u2k_uLlAhUEba0KHZibCdwQjRx6BAgBEAQ&url=https%3A%2F%2Fwww.tasteslovely.com%2Fwhole30-vanilla-latte-coffee%2F&psig=AOvVaw24VIio6WW8cT5vG9-g_E9s&ust=1573590140954749";
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(imgUrl);
            bitmap.EndInit();
            vanResImg.Source = bitmap;
        }
    }
}
