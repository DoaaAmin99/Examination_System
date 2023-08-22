using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    //Define Question Base Class
    ///1. Design a Class to represent the Question Object, Question is
    ///    consisting of:
    ///     a.Header of the question
    ///     b.Body of the question
    ///     c.Mark
    abstract class Question
    {
        #region Properties
        public abstract string Header { get; }
        public string Body { get; set; }
        public int Mark { get; set; }

        //5. Question is associated with an Array of answers and its right answer(Answers[] AnswerList) .
        public Answers[] AnswerList { get; set; }
        public Answers CorrectAnswer { get; set; }
        public Answers UserAnswer { get; set; }
        #endregion

        #region Constructor
        public Question()
        {
            CorrectAnswer = new Answers();
            UserAnswer = new Answers();
        }
        #endregion

        #region Methods
        public abstract void AddQuestion();

        public override string ToString()
        {
            return $"{Header} \t Mark({Mark})\n" +
                $" \n{Body}\n";
        }
        #endregion



    }
}
