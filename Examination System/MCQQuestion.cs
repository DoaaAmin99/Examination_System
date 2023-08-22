using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    class MCQQuestion : Question
    {
        public override string Header => "Choose one Answer Question";
        public MCQQuestion()
        {
            AnswerList = new Answers[3];
        }

        public override void AddQuestion()
        {
            Console.WriteLine(Header);

            //Enter Body 

            do
            {
                Console.WriteLine("Please Enter The Body Of Question: ");
                Body = Console.ReadLine();
            } while (string.IsNullOrEmpty(Body));



            //Enter Marks
            int Mark;
            do
            {
                Console.WriteLine("Please Enter The Marks Of Question: ");
            } while (!int.TryParse(Console.ReadLine(), out Mark));
            this.Mark = Mark;

            //Choices
            Console.WriteLine("The choices Of Question: ");

            for (int i = 0; i < AnswerList.Length; i++)
            {
                AnswerList[i] = new Answers() { AnswerId = i + 1 };

                do
                {
                    Console.Write($"Please Enter The Choice Number {i + 1}: ");
                    AnswerList[i].AnswerText = Console.ReadLine();
                } while (string.IsNullOrEmpty(AnswerList[i].AnswerText));

            }

            //Enter The Right Answer
            int RightAnswerId;
            do
            {
                Console.WriteLine("Please Specify The Right Choice Of Question (1, 2 Or 3):  ");
            } while (!int.TryParse(Console.ReadLine(), out RightAnswerId) && RightAnswerId < 1 || RightAnswerId > 3);


            CorrectAnswer.AnswerId = RightAnswerId;
            CorrectAnswer.AnswerText = AnswerList[RightAnswerId - 1].AnswerText;
            Console.Clear();

        }
    }
}
