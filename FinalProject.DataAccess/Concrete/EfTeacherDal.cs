using FinalProject.DataAccess.Abstract;
using FinalProject.Entities.Concrete;

namespace FinalProject.DataAccess.Concrete
{
    public class EfTeacherDal : EfEntityRepositoryBase<Teacher, FinalProjectContext>, ITeacherDal
    {
    }
}
