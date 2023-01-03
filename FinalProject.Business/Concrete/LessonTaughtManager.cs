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
    public class LessonTaughtManager : ILessonTaughtService
    {
        ILessonTaughtDal _lessonTaughtDal;

        public LessonTaughtManager(ILessonTaughtDal lessonTaughtDal)
        {
            _lessonTaughtDal = lessonTaughtDal;
        }

        public void Add(LessonsTaught lessonsTaught)
        {
            _lessonTaughtDal.Add(lessonsTaught);
        }

        public void Delete(LessonsTaught lessonsTaught)
        {
            _lessonTaughtDal.Delete(lessonsTaught);
        }

        public List<LessonsTaught> GetAll()
        {
            return _lessonTaughtDal.GetAll();
        }

        public List<LessonsTaught> GetLessonByTeacherId(int teacherId)
        {
            return _lessonTaughtDal.GetAll(les => les.TeacherID == teacherId);
        }

        public void Update(LessonsTaught lessonsTaught)
        {
            _lessonTaughtDal.Update(lessonsTaught);
        }
    }
}
