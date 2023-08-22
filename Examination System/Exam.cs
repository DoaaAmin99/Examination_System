using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    //6. Design a Base class Exam describe the common attributes
    //    concerning the exam:
    //      a.Time of exam
    //      b.Number of Questions
    //      c.Show Exam Functionality that its implementations will be
    //      different for each exam based on its type.

    abstract class Exam
    {
        #region Properties
        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public Question[] ListOfQuestions { get; set; }
        #endregion

        #region Constructor 
        public Exam(int _Time, int _NumberOfQuestions)
        {
            Time = _Time;
            NumberOfQuestions = _NumberOfQuestions;

        }
        #endregion

        
        #region Methods
        public abstract void ShowExam();
        public abstract void CreateListOfQuestions(); 
        #endregion

    }
}
