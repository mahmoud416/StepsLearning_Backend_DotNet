using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    #region Exam
    public class Exam
    {
        public event Action StartExam;

        public void OnStartExam()
        {
            Console.WriteLine("Exam has started...");
            StartExam?.Invoke();
        }
    }
    #endregion

    #region Teacher
    public class Teacher
    {
        public void OnExamStarted()
        {
            Console.WriteLine("Teacher notified: Exam started");
        }
    }
    #endregion

    #region Student
    public class Student
    {
        public void OnExamStarted()
        {
            Console.WriteLine("Student notified: Exam started");
        }
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {

            Exam exam = new Exam();
            Student student = new Student();
            Teacher teacher = new Teacher();

            exam.StartExam += student.OnExamStarted;
            exam.StartExam += teacher.OnExamStarted;

            exam.OnStartExam();
        }
    }
}
