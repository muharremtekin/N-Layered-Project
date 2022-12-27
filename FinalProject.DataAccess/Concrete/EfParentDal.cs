using FinalProject.DataAccess.Abstract;
using FinalProject.Entities.Concrete;

namespace FinalProject.DataAccess.Concrete
{
    public class EfParentDal : EfEntityRepositoryBase<Parent, FinalProjectContext>, IParentDal
    {
    }
}
