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
    /// Interaction logic for americanoResults.xaml
    /// </summary>
    public partial class americanoResults : Window
    {
        public americanoResults()
        {
            InitializeComponent();

            string imgUrl = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fglobalassets.starbucks.com%2Fassets%2F02e313dd98204b7380730e96f8d50c38.jpg&imgrefurl=https%3A%2F%2Fwww.starbucks.co.uk%2Fmenu%2Fproduct%2F406%2Fhot%3Fparent%3D%252Fdrinks%252Fespresso-drinks%252Famericano&docid=U_FHfaJfGbeuZM&tbnid=zz5xYsLpFC5pmM%3A&vet=10ahUKEwiWpaGN_-LlAhUFSq0KHRqfD50QMwh6KAYwBg..i&w=1440&h=1440&bih=762&biw=1600&q=americano%20coffee&ved=0ahUKEwiWpaGN_-LlAhUFSq0KHRqfD50QMwh6KAYwBg&iact=mrc&uact=8";
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(imgUrl);
            bitmap.EndInit();
            amImg.Source = bitmap;
        }
    }
}
