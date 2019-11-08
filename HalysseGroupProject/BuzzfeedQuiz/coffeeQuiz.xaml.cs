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
    /// Interaction logic for coffeeQuiz.xaml
    /// </summary>
    public partial class coffeeQuiz : Window
    {
        public coffeeQuiz()
        {
            InitializeComponent();
        }

      

        private void CofresultsBTN_Click_1(object sender, RoutedEventArgs e)
        {
            int ques1AnswerID = 0, ques2AnswerID = 0, ques3AnswerID = 0, ques4AnswerID = 0, answerTotal = 0;
            pslResults psl = new pslResults();
            americanoResults ar = new americanoResults();
            vanillaResults vr = new vanillaResults();

            if (mornRB.IsChecked == true)
            {
                ques1AnswerID = 1;
            }
            else if (nightRB.IsChecked == true)
            {
                ques1AnswerID = 2;
            }
            if (purpRB.IsChecked == true)
            {
                ques2AnswerID = 1;
            }
            else if (orangeRB.IsChecked == true)
            {
                ques2AnswerID = 2;
            }
            else if (blueRB.IsChecked == true)
            {
                ques2AnswerID = 3;
            }
            else if (BlackRB.IsChecked == true)
            {
                ques2AnswerID = 4;
            }
            if (catRB.IsChecked == true)
            {
                ques3AnswerID = 1;
            }
            else if (dogsRB.IsChecked == true)
            {
                ques3AnswerID = 2;
            }
            if (moviesRB.IsChecked == true)
            {
                ques4AnswerID = 1;
            }
            else if (shopRB.IsChecked == true)
            {
                ques4AnswerID = 2;
            }
            else if (hikeRB.IsChecked == true)
            {
                ques4AnswerID = 3;
            }
            else if (sleepRB.IsChecked == true)
            {
                ques4AnswerID = 4;
            }
            answerTotal = ques1AnswerID + ques2AnswerID + ques3AnswerID + ques4AnswerID;
            if (answerTotal <= 5)
            {
                vr.Show();
            }
            else if (answerTotal <= 9)
            {
                psl.Show();
            }
            else if (answerTotal >= 10)
            {
                ar.Show();
            }
        }
    }
}
