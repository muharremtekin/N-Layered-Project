using FinalProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Business.Abstract
{
    public interface ILessonLearnService
    {
        List<LessonsLearn> GetAll();
        List<LessonsLearn> GetLessonByStudentId(int id);
        void Add(LessonsLearn lessonsLearn);
        void Delete(LessonsLearn lessonsLearn);
        void Update(LessonsLearn lessonsLearn);
    }
}
