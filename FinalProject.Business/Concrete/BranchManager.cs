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
    public class BranchManager : IBranchService
    {
        IBranchDal _branchDal;

        public BranchManager(IBranchDal branchDal)
        {
            _branchDal = branchDal;
        }

        public void Add(Branch branch)
        {
            _branchDal.Add(branch);
        }

        public void Delete(Branch branch)
        {
            throw new NotImplementedException();
        }

        public List<Branch> GetAll()
        {
            return _branchDal.GetAll();
        }

        public List<Branch> GetParentByName(string branchName)
        {
            return _branchDal.GetAll(b => b.Name == branchName);
        }

        public void Update(Branch branch)
        {
            throw new NotImplementedException();
        }
    }
}
