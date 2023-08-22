using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    class PracticalExam : Exam
    {
        public PracticalExam(int _Time, int _NumberOfQuestions) : base(_Time, _NumberOfQuestions)
        {
        }

        public override void CreateListOfQuestions()
        {
            ListOfQuestions = new MCQQuestion[NumberOfQuestions];

            if (ListOfQuestions is not null)
            {
                for (int i = 0; i < ListOfQuestions.Length; i++)
                {
                    ListOfQuestions[i] = new MCQQuestion();
                    ListOfQuestions[i].AddQuestion();
                    Console.Clear();
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
                Console.WriteLine("====================================================\n");
            }

            Console.Clear();

            Console.WriteLine("Answers: ");

            for (int i = 0; i < ListOfQuestions.Length; i++)
            {
                Console.WriteLine($"Q{i + 1})  {ListOfQuestions[i].Body} : \nYour Answer: {ListOfQuestions[i].UserAnswer.AnswerText}");
                Console.WriteLine($"Right Answer: {ListOfQuestions[i].CorrectAnswer.AnswerText}");
            }
        }
    }
}
