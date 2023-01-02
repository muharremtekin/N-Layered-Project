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

        public bool CheckStudent(string mail)
        {
            var _ = _studentDal.Get(s => s.Mail == mail);
            if (_.Mail == mail)
                return true;
            else
                return false;
        }

        public void Delete(Student student)
        {
            _studentDal.Delete(student);
        }

        public Student Get(int id)
        {
            return _studentDal.Get(s => s.ID == id);
        }

        public List<Student> GetAll()
        {
            return _studentDal.GetAll();
        }

        public List<Student> GetStudentById(int studentId)
        {
            return _studentDal.GetAll(s => s.ID == studentId);
        }

        public List<Student> GetStudentByParentId(int parentId)
        {
            return _studentDal.GetAll(s => s.Parent_ID == parentId);
        }

        public List<Student> GetStudentByStudentName(string studentName)
        {
            return _studentDal.GetAll(s => s.Name.ToLower().Contains(studentName.ToLower()));
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
