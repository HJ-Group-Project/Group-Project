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

        DB_128040_quizletEntities db = new DB_128040_quizletEntities();

        private void CofresultsBTN_Click_1(object sender, RoutedEventArgs e)
        {
            int ques1AnswerID = 0, ques2AnswerID = 0, ques3AnswerID = 0, ques4AnswerID = 0, answerTotal = 0;
            pslResults psl = new pslResults();
            americanoResults ar = new americanoResults();
            vanillaResults vr = new vanillaResults();

            TAnswer answer = new TAnswer();

            if (mornRB.IsChecked == true)
            {
                ques1AnswerID = 1;
                answer.AnswerOne = "1";
                
            }
            else if (nightRB.IsChecked == true)
            {
                ques1AnswerID = 2;
                answer.AnswerOne = "2";
            }
            if (purpRB.IsChecked == true)
            {
                ques2AnswerID = 1;
                answer.AnswerTwo = "1";
            }
            else if (orangeRB.IsChecked == true)
            {
                ques2AnswerID = 2;
                answer.AnswerTwo = "2";
            }
            else if (blueRB.IsChecked == true)
            {
                ques2AnswerID = 3;
                answer.AnswerTwo = "3";
            }
            else if (BlackRB.IsChecked == true)
            {
                ques2AnswerID = 4;
                answer.AnswerTwo = "4";
            }
            if (catRB.IsChecked == true)
            {
                ques3AnswerID = 1;
                answer.AnswerThree = "1";
            }
            else if (dogsRB.IsChecked == true)
            {
                ques3AnswerID = 2;
                answer.AnswerThree = "2";
            }
            if (moviesRB.IsChecked == true)
            {
                ques4AnswerID = 1;
                answer.AnswerFour = "1";
            }
            else if (shopRB.IsChecked == true)
            {
                ques4AnswerID = 2;
                answer.AnswerFour = "2";
            }
            else if (hikeRB.IsChecked == true)
            {
                ques4AnswerID = 3;
                answer.AnswerFour = "3";
            }
            else if (sleepRB.IsChecked == true)
            {
                ques4AnswerID = 4;
                answer.AnswerFour = "4";
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
            answer.TQuiz = db.TQuizs.Find(13);
            db.TAnswers.Add(answer);
            db.SaveChanges();
        }

        private void BlackRB_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
