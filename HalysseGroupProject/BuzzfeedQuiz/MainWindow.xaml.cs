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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BuzzfeedQuiz
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

        private void ChooseQuizbtn_Click(object sender, RoutedEventArgs e)
        {
            int quizId;
            TQuiz quiz = new TQuiz();
            quizId=quiz.QuizID;
            const int coffeeQuizID=13;
            const int animalQuizID = 12;
            const int spongebobQuizID = 14;
            coffeeQuiz cq = new coffeeQuiz();
            animalQuiz aq = new animalQuiz();
            spongebobQuiz sq = new spongebobQuiz();

            if (coffeeQuizRB.IsChecked==true)
            {
                quizId = coffeeQuizID;
                cq.Show();
            }
            else if(animalQuizRB.IsChecked==true)
            {
                quizId = animalQuizID;
                aq.Show();
            }
            else if (spongebobQuizRB.IsChecked==true)
            {
                quizId = spongebobQuizID;
                sq.Show();
            }
        }
    }
}
