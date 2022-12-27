using FinalProject.DataAccess.Abstract;
using FinalProject.Entities.Concrete;

namespace FinalProject.DataAccess.Concrete
{
    public class EfStudentDal : EfEntityRepositoryBase<Student, FinalProjectContext>, IStudentDal
    {
    }
}
