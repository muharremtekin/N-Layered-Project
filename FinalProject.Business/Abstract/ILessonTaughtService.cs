using FinalProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Business.Abstract
{
    public interface ILessonTaughtService
    {
        List<LessonsTaught> GetAll();
        List<LessonsTaught> GetLessonByTeacherId(int teacherId);
        void Add(LessonsTaught lessonsTaught);
        void Delete(LessonsTaught lessonsTaught);
        void Update(LessonsTaught lessonsTaught);
    }
}
