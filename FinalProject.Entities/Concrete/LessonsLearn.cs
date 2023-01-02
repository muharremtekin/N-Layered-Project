using FinalProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Entities.Concrete
{
    public class LessonsLearn : IEntity
    {
        public int LessonID { get; set; }
        public int StudentID { get; set; }
    }
}
