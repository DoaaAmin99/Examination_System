using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    class TFQuestion : Question
    {
        public override string Header { get { return "True | False Question "; } }

        public TFQuestion()
        {
            AnswerList = new Answers[2];
            AnswerList[0] = new Answers(1,"True");
            AnswerList[1] = new Answers(2, "False");
        }

        public override void AddQuestion()
        {
            Console.WriteLine(Header);

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

            //Enter The Right Answer
            int RightAnswerId;
            do
            {
                Console.WriteLine("Please Enter The Right Answer Of Question (1 for True and 2 for false):  ");
            } while (!int.TryParse(Console.ReadLine(), out RightAnswerId) && RightAnswerId < 1 || RightAnswerId > 2);
            

            CorrectAnswer.AnswerId = RightAnswerId;
            CorrectAnswer.AnswerText = AnswerList[RightAnswerId-1].AnswerText;
            Console.Clear();

        }
    }
}
