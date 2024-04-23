using DelegateTask24._04.Models;
using System.Globalization;
using System.Reflection.PortableExecutable;
using System.Xml;

namespace DelegateTask24._04
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Person person = new Person("Emil","Akulaov",19);
           // Person person1 = new Person("Eli","eliyev",21);
           // Person person2 = new Person("sahin", "azerova", 13);
           // List<Person> students = new List<Person>();
           // students.Add(person);
           // students.Add(person1);
           // students.Add(person2);

           // students.FindAll(s => s.Name.ToLower() == "kamil").ForEach(s => Console.WriteLine(s.Name + " " + s.Surname + " " + s.Age));
           // students.FindAll(s => s.Surname.ToLower().Contains("ov") || s.Surname.ToLower().Contains("ova")).ForEach(s => Console.WriteLine(s.Surname));

           // students.FindAll(s=>s.Age>20).ForEach(s=>Console.WriteLine(s.Age));

            Exam exam = new Exam(180, "Qebul imtahni",DateTime.Now);
           Exam exam1  =new Exam(120, "Magistr imtahni", DateTime.Now);
           Exam exam2=new Exam(20,"quiz",DateTime.Now);
            List<Exam> tasks = new List<Exam>();
            tasks.Add(exam1);
            tasks.Add(exam2);
            tasks.Add(exam);
            exam.Start();
            tasks.FindAll(s=>s.ExamDuration>120).ForEach(s => Console.WriteLine(s.Subject));//2 saatdan uzun ceken imtahanlarin siyahisi
            tasks.FindAll(s => DateTime.Now >= DateTime.Now).ForEach(s=> Console.WriteLine(s.Subject));
            tasks.FindAll(s=>s.StartDate<=s.StartDate.AddDays(7)).ForEach(s=>Console.WriteLine(s.Subject));
           




        }
    }
}
