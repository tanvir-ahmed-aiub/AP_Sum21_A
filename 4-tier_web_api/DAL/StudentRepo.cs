using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StudentRepo
    {
        static StudentMSEntities context;
        static StudentRepo() {
            context = new StudentMSEntities();
        }
        public static void AddStudent(Student model) {
            context.Students.Add(model);
            context.SaveChanges();
        }
        public static List<Student> GetAllStudents() {
            var data = context.Students.ToList();
            return data;
        }
        public static Student GetStudent(int id) {
            var data = context.Students.FirstOrDefault(e => e.Id == id);
            return data;
        }

        public static List<string>  GetStudentNames()
        {
            var data = context.Students.Select(e => e.Name).ToList();
            return data;
        }
    }
}
