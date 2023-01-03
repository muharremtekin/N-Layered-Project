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
    public class LessonLearnManager : ILessonLearnService
    {
        ILessonLearnDal _lessonLearnDal;

        public LessonLearnManager(ILessonLearnDal lessonLearnDal)
        {
            _lessonLearnDal = lessonLearnDal;
        }

        public void Add(LessonsLearn lessonsLearn)
        {
            _lessonLearnDal.Add(lessonsLearn);
        }

        public void Delete(LessonsLearn lessonsLearn)
        {
            _lessonLearnDal.Delete(lessonsLearn);
        }

        public List<LessonsLearn> GetAll()
        {
            return _lessonLearnDal.GetAll();
        }

        public List<LessonsLearn> GetLessonByStudentId(int studentId)
        {
            return _lessonLearnDal.GetAll(les => les.StudentID == studentId);
        }

        public void Update(LessonsLearn lessonsLearn)
        {
            _lessonLearnDal.Update(lessonsLearn);
        }
    }
}
