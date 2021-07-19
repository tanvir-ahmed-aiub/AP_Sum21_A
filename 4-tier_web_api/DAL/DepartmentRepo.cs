using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DepartmentRepo
    {
        static StudentMSEntities context;
        static DepartmentRepo() {
            context = new StudentMSEntities();
        }
        public static List<string> GetDepartmentNames() {
            var data = context.Departments.Select(e => e.Name).ToList();
            return data;
        }
        public static List<Department> GetDepartments() {
            return context.Departments.ToList();
        }
        public static void AddDepartment(Department d) {
            context.Departments.Add(d);
            context.SaveChanges();
        }

        public static Department GetDepartmentDetail(int id)
        {
            return context.Departments.FirstOrDefault(e => e.Id == id);
        }
    }
}
