using AutoMapper;
using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.MapperConfig
{
    public class AutoMapperSettings : Profile
    {
        public AutoMapperSettings() {
            CreateMap<DepartmentModel, Department>().ForMember(e=>e.Students, d=>d.Ignore());
            CreateMap<Department, DepartmentDetail>();
            CreateMap<StudentModel, Student>().ForMember(e=>e.Department, sm=>sm.Ignore());
           
        }
    }
}
