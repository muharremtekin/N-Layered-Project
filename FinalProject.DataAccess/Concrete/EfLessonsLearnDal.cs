using FinalProject.DataAccess.Abstract;
using FinalProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DataAccess.Concrete
{
    public class EfLessonsLearnDal : EfEntityRepositoryBase<LessonsLearn, FinalProjectContext>, ILessonLearnDal
    {
    }
}
