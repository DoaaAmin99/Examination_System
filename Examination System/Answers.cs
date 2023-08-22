using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    //4. We need to define a class for the answers(AnswerId, AnswerText).
    class Answers
    {
        #region Ptoperties
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }
        #endregion

        #region Constructors
        public Answers()
        {

        }
        public Answers(int _AnswerId, string _AnswerText)
        {
            AnswerId = _AnswerId;
            AnswerText = _AnswerText;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{AnswerId}. {AnswerText}";
        } 
        #endregion
    }
}
