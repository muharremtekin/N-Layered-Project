using FinalProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Entities.Concrete
{
    public class LessonsTaught : IEntity
    {
        public int ID { get; set; }
        public int LessonID { get; set; }
        public int TeacherID { get; set; }
        public string LessonName { get; set; }
        public string TeacherName { get; set; }
    }
}
