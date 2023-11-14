using EFCoreTask.Models;
using EFCoreTask.Services;

namespace EFCoreTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentService studentService = new StudentService();

            Student student = new Student()
            {
                Name = "Rashad",
                Surname = "Rufullayev",
                AvgPoint = 98
            };

            Student student2 = new Student()
            {
                Name = "Alpay",
                Surname = "Abdullayev",
                AvgPoint = 97
            };

            Student student3 = new Student()
            {
                Name = "Ehmed",
                Surname = "Osmanov",
                AvgPoint = 96
            };


            studentService.CreateStudent(student);
            studentService.CreateStudent(student2);
            studentService.CreateStudent(student3);


            //List<Student> students = studentService.GetAll();
            //foreach (Student studentss in students)
            //{
            //    Console.WriteLine($"{studentss.Name} {studentss.Surname} {studentss.AvgPoint}");
            //}


            //Student existed = studentService.GetStudentId(2);


            //studentService.DeleteStudent(3);







        }
    }
}