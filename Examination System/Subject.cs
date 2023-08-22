using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Examination_System
{
    //    The Subject is a class that contains the following members:
    //      a.Subject Id.
    //      b.Subject Name.
    //      c.Exam of the subject.
    //      d.We need to implement functionality to create the exam of
    //      the subject. 
    class Subject
    {
        #region Properties
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam SubjectExam { get; set; }
        #endregion

        #region Constructor
        public Subject(int _SubjectId, string _SubjectName)
        {
            SubjectId = _SubjectId;
            SubjectName = _SubjectName;
        }
        #endregion

        #region Methods
        public void CreateExam() 
        {
            int ExamType, ExamTime, NumOfQuestions;
            do
            {
                Console.Write("Please Enter The Type Of Exam You Want To Create (1 for Practical and 2 for Final): ");
            } while (!int.TryParse(Console.ReadLine(), out ExamType) || ExamType < 1 || ExamType > 2);

            do
            {
                Console.Write("Please Enter The Time Of Exam in minutes (From 60 Min To 180 Min): ");
            } while (!int.TryParse(Console.ReadLine(), out ExamTime) || ExamTime < 60 || ExamTime > 180);

            do
            {
                Console.Write("Please Enter The Number Of Questions: ");
            } while (!int.TryParse(Console.ReadLine(), out NumOfQuestions));

            if (ExamType == 1)
                SubjectExam = new PracticalExam(ExamTime , NumOfQuestions);
            else
                SubjectExam = new FinalExam(ExamTime, NumOfQuestions);

            Console.Clear();

            SubjectExam.CreateListOfQuestions();
        }
        #endregion
    }
}
