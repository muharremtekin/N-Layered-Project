using FinalProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Business.Abstract
{
    public interface IStudentService
    {
        List<Student> GetAll();
        List<Student> GetStudentById(int studentId);
        List<Student> GetTeacherByTeacherName(string studentName);
        void Add(Student student);
        void Delete(Student student);
        void Update(Student student);

    }
}
