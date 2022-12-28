using FinalProject.Business.Abstract;
using FinalProject.DataAccess.Abstract;
using FinalProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Business.Concrete
{
    public class ParentManager : IParentService
    {
        IParentDal _parentDal;

        public ParentManager(IParentDal parentDal)
        {
            _parentDal = parentDal;
        }

        public void Add(Parent parent)
        {
            _parentDal.Add(parent);
        }

        public void Delete(Parent parent)
        {
            throw new NotImplementedException();
        }

        public List<Parent> GetAll()
        {
            return _parentDal.GetAll();
        }

        public List<Parent> GetParentByName(string parentName)
        {
            return _parentDal.GetAll(p => p.Name == parentName);
        }

        public void Update(Parent parent)
        {
            throw new NotImplementedException();
        }
    }
}
