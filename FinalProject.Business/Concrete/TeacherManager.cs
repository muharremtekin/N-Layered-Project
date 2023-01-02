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
    public class TeacherManager : ITeacherService
    {
        ITeacherDal _teacherDal;

        public TeacherManager(ITeacherDal teacherDal)
        {
            _teacherDal = teacherDal;
        }

        public void Add(Teacher teacher)
        {
            _teacherDal.Add(teacher);
        }

        public bool CheckStudent(string mail)
        {
            var _ = _teacherDal.Get(s => s.Mail == mail);
            if (_.Mail == mail)
                return true;
            else
                return false;
        }

        public void Delete(Teacher teacher)
        {
            _teacherDal.Delete(teacher);
        }

        public List<Teacher> GetAll()
        {
            return _teacherDal.GetAll();
        }

        public List<Teacher> GetTeacherByBranch(int branchId)
        {

            return _teacherDal.GetAll(t => t.BranchID == branchId);
        }

        public List<Teacher> GetTeacherById(int teachertId)
        {
            return _teacherDal.GetAll(t => t.ID == teachertId);
        }

        public List<Teacher> GetTeacherByMail(string mail)
        {
            return _teacherDal.GetAll(t => t.Mail == mail);
        }

        public List<Teacher> GetTeacherByTeacherName(string teacherName)
        {
            return _teacherDal.GetAll(t => t.Name.ToLower().Contains(teacherName.ToLower()));
        }

        public List<Teacher> LoginTeacher(string mail, string password)
        {
            return _teacherDal.GetAll(s => s.Mail == mail && s.Password == password);
        }

        public void Update(Teacher teacher)
        {
            _teacherDal.Update(teacher);
        }
    }
}
