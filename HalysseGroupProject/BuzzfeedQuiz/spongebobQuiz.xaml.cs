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
    /// Interaction logic for spongebobQuiz.xaml
    /// </summary>
    public partial class spongebobQuiz : Window
    {
        public spongebobQuiz()
        {
            InitializeComponent();
            

        }

        DB_128040_quizletEntities db = new DB_128040_quizletEntities();

        private void ResultsBTN_Click(object sender, RoutedEventArgs e)
        {

            int ques1AnswerID = 0, ques2AnswerID = 0, ques3AnswerID = 0, ques4AnswerID = 0, answerTotal = 0;
            spongebobResults sbr = new spongebobResults();
            PatrickResults pr = new PatrickResults();
            KrabsResults kr = new KrabsResults();
            SquidwardResults sqr = new SquidwardResults();

            TAnswer answer = new TAnswer();

            if (musicRB.IsChecked == true)
            {
                ques1AnswerID = 1;
                answer.AnswerOne = "1";
            }
            else if (movieRB.IsChecked == true)
            {
                ques1AnswerID = 2;
                answer.AnswerOne = "2";
            }
            else if (hangRB.IsChecked == true)
            {
                ques1AnswerID = 3;
                answer.AnswerOne = "3";
            }
            else if (workRB.IsChecked == true)
            {
                ques1AnswerID = 4;
                answer.AnswerOne = "4";
            }
            if (greenRB.IsChecked == true)
            {
                ques2AnswerID = 1;
                answer.AnswerTwo = "1";
            }
            else if (pinkRB.IsChecked == true)
            {
                ques2AnswerID = 2;
                answer.AnswerTwo = "2";
            }
            else if (purpRB.IsChecked == true)
            {
                ques2AnswerID = 3;
                answer.AnswerTwo = "3";
            }
            else if (orangeRB.IsChecked == true)
            {
                ques2AnswerID = 4;
                answer.AnswerTwo = "3";
            }
            if(crabRB.IsChecked==true)
            {
                ques3AnswerID = 1;
                answer.AnswerThree = "1";
            }
            else if(pizzaRB.IsChecked==true)
            {
                ques3AnswerID = 2;
                answer.AnswerThree = "2";
            }
            else if(spagRB.IsChecked==true)
            {
                ques3AnswerID = 3;
                answer.AnswerThree = "3";
            }
            else if(friesRB.IsChecked==true)
            {
                ques3AnswerID = 4;
                answer.AnswerThree = "4";
            }
            if (garyRB.IsChecked == true)
            {
                ques4AnswerID = 1;
                answer.AnswerFour = "1";
            }
            else if (patRB.IsChecked == true)
            {
                ques4AnswerID = 2;
                answer.AnswerFour = "2";
            }
            else if (plankRB.IsChecked == true)
            {
                ques4AnswerID = 3;
                answer.AnswerFour = "3";
            }
            else if (sandRB.IsChecked == true)
            {
                ques4AnswerID = 4;
                answer.AnswerFour = "4";
            }
            answerTotal = ques1AnswerID + ques2AnswerID + ques3AnswerID + ques4AnswerID;
            if (answerTotal <= 4)
            {
                sqr.Show();
            }
            else if (answerTotal <= 6)
            {
                pr.Show();
            }
            else if (answerTotal <=8)
            {
                sbr.Show();
            }
            else if(answerTotal>=10)
            {
                kr.Show();
            }
            answer.TQuiz = db.TQuizs.Find(14);
            db.TAnswers.Add(answer);
            db.SaveChanges();
        }
    }
}
