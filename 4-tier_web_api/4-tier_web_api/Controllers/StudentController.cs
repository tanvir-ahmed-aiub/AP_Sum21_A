using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _4_tier_web_api.Controllers
{
    public class StudentController : ApiController
    {
        [Route("api/Student/GetAll")]
        public List<StudentModel> GetAllStudents() {
            return StudentService.GetAllStudents();
        }
        [Route("api/Student/{id}")]
        public StudentModel GetStudent(int id) {
            return StudentService.GetStudent(id);
        }
        [Route("api/Student/Add")]
        public void AddStudent(StudentModel model) {
            StudentService.AddStudent(model);
        }
        [Route("api/Student/Names")]
        public List<string> GetStudentNames() {
            return StudentService.GetStudentNames();
        }
    }
}
