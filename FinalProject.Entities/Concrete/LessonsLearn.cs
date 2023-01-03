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
        public int ID { get; set; }
        public int LessonID { get; set; }
        public int StudentID { get; set; }
        public int exam1 { get; set; }
        public int exam2 { get; set; }
        public int avg { get; set; }
    }
}
