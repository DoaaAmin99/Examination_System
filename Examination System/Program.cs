using System.Diagnostics;

namespace Examination_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject Sub1 = new Subject(10, "C#");
            Sub1.CreateExam();
            Console.Clear();

            char start;
            do
            {
                Console.WriteLine("Do You Want To Start The Exam (y | n): ");
            } while (!char.TryParse(Console.ReadLine().ToLower(), out start) || (start != 'y' && start != 'n'));

            Console.Clear();

            if (start == 'y')
            {
                Stopwatch SW = new Stopwatch();
                SW.Start();
                Sub1.SubjectExam.ShowExam();
                Console.WriteLine($"The Elapsed Time = {SW.Elapsed}");
            }
            else
                Console.WriteLine("BYE BYE ...... :)");
        }
    }
}