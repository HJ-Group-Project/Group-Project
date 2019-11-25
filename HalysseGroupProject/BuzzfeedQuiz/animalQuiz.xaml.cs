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
    /// Interaction logic for animalQuiz.xaml
    /// </summary>
    public partial class animalQuiz : Window
    {
        public animalQuiz()
        {
            InitializeComponent();
        }

        DB_128040_quizletEntities db = new DB_128040_quizletEntities();

        private void ResultusBttn_Click(object sender, RoutedEventArgs e)
        {
            int ques1AnswerID = 0, ques2AnswerID = 0, ques3AnswerID = 0, ques4AnswerID = 0, answerTotal = 0;
            AlligatorResults ar = new AlligatorResults();
            HorseResult hr = new HorseResult();
            LionResults lr = new LionResults();
            CoyoteResults cr = new CoyoteResults();

            TAnswer answer = new TAnswer();

            if (comfortRB.IsChecked == true)
            {
                ques1AnswerID = 1;
                answer.AnswerOne = "1";
            }
            else if (comegoRB.IsChecked == true)
            {
                ques1AnswerID = 2;
                answer.AnswerOne = "2";
            }
            else if (spendRB.IsChecked == true)
            {
                ques1AnswerID = 3;
                answer.AnswerOne = "2";
            }
            else if (friendsRB.IsChecked == true)
            {
                ques1AnswerID = 4;
                answer.AnswerOne = "2";
            }
            if (strikeRB.IsChecked == true)
            {
                ques1AnswerID = 1;
                answer.AnswerOne = "1";
            }
            else if (walkRB.IsChecked == true)
            {
                ques1AnswerID = 2;
                answer.AnswerOne = "2";
            }
            else if (rageRB.IsChecked == true)
            {
                ques1AnswerID = 3;
                answer.AnswerOne = "3";
            }
            else if (callRB.IsChecked == true)
            {
                ques1AnswerID = 4;
                answer.AnswerOne = "4";
            }
            if (myselfRB.IsChecked == true)
            {
                ques1AnswerID = 1;
                answer.AnswerOne = "1";
            }
            else if (strangerRB.IsChecked == true)
            {
                ques1AnswerID = 2;
                answer.AnswerOne = "2";
            }
            else if (familyRB.IsChecked == true)
            {
                ques1AnswerID = 3;
                answer.AnswerOne = "3";
            }
            else if (loyalRB.IsChecked == true)
            {
                ques1AnswerID = 4;
                answer.AnswerOne = "4";
            }
            if (secretRB.IsChecked == true)
            {
                ques1AnswerID = 1;
                answer.AnswerOne = "1";
            }
            else if (bookRB.IsChecked == true)
            {
                ques1AnswerID = 2;
                answer.AnswerOne = "2";
            }
            else if (lifeRB.IsChecked == true)
            {
                ques1AnswerID = 3;
                answer.AnswerOne = "3";
            }
            else if (truthRB.IsChecked == true)
            {
                ques1AnswerID = 4;
                answer.AnswerOne = "4";
            }
            answerTotal = ques1AnswerID + ques2AnswerID + ques3AnswerID + ques4AnswerID;
            if (answerTotal <= 4)
            {
                ar.Show();
            }
            else if (answerTotal <= 6)
            {
                hr.Show();
            }
            else if (answerTotal <= 8)
            {
                lr.Show();
            }
            else if (answerTotal >= 10)
            {
                cr.Show();
            }
            answer.TQuiz = db.TQuizs.Find(14);
            db.TAnswers.Add(answer);
            db.SaveChanges();
        }
    }
}
