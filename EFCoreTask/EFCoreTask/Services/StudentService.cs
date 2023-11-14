using EFCoreTask.DAL;
using EFCoreTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreTask.Services
{
    internal class StudentService
    {
        AppDbContext _context= new AppDbContext();

        public List<Student> GetAll()
        {
            List<Student> Students = _context.Students.ToList();
            return Students;
        }

        public void CreateStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public Student GetStudentId(int id)
        {
            return _context.Students.Find(id);
        }
        
        public void DeleteStudent(int id)
        {
            Student student = GetStudentId(id);
            if(student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
            }
        }
        
    }
}
