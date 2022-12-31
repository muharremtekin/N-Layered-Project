using FinalProject.Business.Abstract;
using FinalProject.DataAccess.Abstract;
using FinalProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Business.Concrete
{
    public class StudentManager : IStudentService
    {
        IStudentDal _studentDal;

        public StudentManager(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }

        public void Add(Student student)
        {
            _studentDal.Add(student);
        }

        public void Delete(Student student)
        {
            _studentDal.Delete(student);
        }

        public List<Student> GetAll()
        {
            return _studentDal.GetAll();
        }

        public List<Student> GetStudentById(int studentId)
        {
            return _studentDal.GetAll(s => s.ID == studentId);
        }

        public List<Student> GetTeacherByTeacherName(string studentName)
        {
            return _studentDal.GetAll(s => s.Name == studentName);
        }

        public List<Student> LoginStudent(string mail, string password)
        {
            return _studentDal.GetAll(s => s.Mail == mail && s.Password == password);
        }

        public void Update(Student student)
        {
            _studentDal.Update(student);
        }
    }
}
