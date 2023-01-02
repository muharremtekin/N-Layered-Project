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
        List<Student> LoginStudent(string mail, string password);
        List<Student> GetAll();
        List<Student> GetStudentById(int studentId);
        List<Student> GetStudentByStudentName(string studentName);
        bool CheckStudent(string mail);
        Student Get(int id);
        void Add(Student student);
        void Delete(Student student);
        void Update(Student student);
        List<Student> GetStudentByParentId(int parentId);
    }
}
