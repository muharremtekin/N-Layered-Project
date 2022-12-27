using FinalProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Business.Abstract
{
    public interface ITeacherService
    {
        List<Teacher> GetAll();
        List<Teacher> GetTeacherByBranch(int branchId);
        List<Teacher> GetTeacherByTeacherName(string teacherName);
    }
}
