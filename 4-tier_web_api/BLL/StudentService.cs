using BEL;
using BLL.MapperConfig;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class StudentService
    {
        public static void AddStudent(StudentModel model) {
            var data = AutoMapper.Mapper.Map<StudentModel, Student>(model);
            StudentRepo.AddStudent(data);
        }
        public static StudentModel GetStudent(int id) {
            var data = StudentRepo.GetStudent(id);
            var st = AutoMapper.Mapper.Map<Student, StudentModel>(data);
            return st;
        }
        public static List<StudentModel> GetAllStudents() {
            var data = StudentRepo.GetAllStudents();
            var st = AutoMapper.Mapper.Map<List<Student>, List<StudentModel>>(data);
            return st;
        }

        public static List<string> GetStudentNames()
        {
            var data = StudentRepo.GetStudentNames();
            return data;
        }
    }
}
