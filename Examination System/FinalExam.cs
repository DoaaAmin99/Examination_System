using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    //    3. We want the application to accept different Question Types:
    //          For Final Exam:
    //          a.True or False
    //          b.MCQ(Choose one answer)

    class FinalExam : Exam
    {
        public FinalExam(int _Time, int _NumberOfQuestions) : base(_Time, _NumberOfQuestions)
        {
        }

        public override void CreateListOfQuestions()
        {
            ListOfQuestions = new Question[NumberOfQuestions];
            if (ListOfQuestions is not null)
            {
                for (int i = 0; i < ListOfQuestions.Length; i++)
                {
                    int choice;
                    do
                    {
                        Console.Write($"Please Choose Type Of Question Number({i + 1}) (1 for True OR False || 2 for MCQ): ");
                    } while (!int.TryParse(Console.ReadLine(), out choice) && choice < 1 || choice > 2);

                    Console.Clear();

                    if (choice == 1)
                    {
                        ListOfQuestions[i] = new TFQuestion();
                        ListOfQuestions[i].AddQuestion();

                    }
                    else
                    {
                        ListOfQuestions[i] = new MCQQuestion();
                        ListOfQuestions[i].AddQuestion();
                    }

                }
            }
        }

        public override void ShowExam()
        {
            foreach (Question Question in ListOfQuestions)
            {
                Console.WriteLine(Question);

                for (int i = 0; i < Question.AnswerList.Length; i++)
                    Console.Write($"{Question.AnswerList[i]}\t\t");

                Console.WriteLine("\n----------------------------------------------");

                int UserAnswerId;
                do
                {
                    Console.WriteLine("Please Enter The Number Of Your Answer : ");
                } while (!int.TryParse(Console.ReadLine(), out UserAnswerId) && UserAnswerId < 1 || UserAnswerId > 3);

                Question.UserAnswer.AnswerId = UserAnswerId;
                Question.UserAnswer.AnswerText = Question.AnswerList[UserAnswerId - 1].AnswerText;
                Console.WriteLine("====================================================");
            }

            Console.Clear();

            int TotalMarks = 0, Grade = 0;
            Console.WriteLine("Your Answers: ");

            for (int i = 0; i < ListOfQuestions.Length; i++)
            {
                TotalMarks += ListOfQuestions[i].Mark;

                if (ListOfQuestions[i].CorrectAnswer.AnswerId == ListOfQuestions[i].UserAnswer.AnswerId)
                    Grade += ListOfQuestions[i].Mark;

                Console.WriteLine($"Q{i + 1})  {ListOfQuestions[i].Body}: {ListOfQuestions[i].UserAnswer.AnswerText} ");
            }
            Console.WriteLine($"Your Exam Grade Is {Grade} from {TotalMarks}");


        }
    }
}
