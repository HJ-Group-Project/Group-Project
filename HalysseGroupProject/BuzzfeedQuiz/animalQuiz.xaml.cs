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
            int Aques1AnswerID = 0, Aques2AnswerID = 0, Aques3AnswerID = 0, Aques4AnswerID = 0, AanswerTotal = 0;
            AlligatorResults ar = new AlligatorResults();
            HorseResult hr = new HorseResult();
            LionResults lr = new LionResults();
            CoyoteResults cr = new CoyoteResults();
        }
        TAnswer answer = new TAnswer();

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
