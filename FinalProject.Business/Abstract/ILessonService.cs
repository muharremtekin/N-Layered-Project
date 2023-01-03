using FinalProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Business.Abstract
{
    public interface ILessonService
    {
        List<Lesson> GetAll();
        List<Lesson> GetLessonById(int id);
        void Add(Lesson lesson);
        void Delete(Lesson lesson);
        void Update(Lesson lesson);
    }
}
