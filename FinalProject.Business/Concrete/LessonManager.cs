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
    public class LessonManager : ILessonService
    {
        ILessonDal _lessnoDal;

        public LessonManager(ILessonDal lessonDal)
        {
            _lessnoDal = lessonDal;
        }

        public void Add(Lesson lesson)
        {
            _lessnoDal.Add(lesson);
        }

        public void Delete(Lesson lesson)
        {
            _lessnoDal.Delete(lesson);
        }

        public List<Lesson> GetAll()
        {
            return _lessnoDal.GetAll();
        }

        public List<Lesson> GetLessonById(int id)
        {
            return _lessnoDal.GetAll(les => les.ID == id);
        }

        public void Update(Lesson lesson)
        {
            _lessnoDal.Update(lesson);
        }
    }
}
