using FinalProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Business.Abstract
{
    public interface IParentService
    {
        List<Parent> GetAll();
        List<Parent> GetParentByName(string parentName);
        void Add(Parent parent);
        void Delete(Parent parent);
        void Update(Parent parent);
    }
}
