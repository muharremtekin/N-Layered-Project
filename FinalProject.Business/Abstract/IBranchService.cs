using FinalProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Business.Abstract
{
    public interface IBranchService
    {
        List<Branch> GetAll();
        List<Branch> GetBranchByName(string branchName);
        void Add(Branch branch);
        void Delete(Branch branch);
        void Update(string branchName);
    }
}
