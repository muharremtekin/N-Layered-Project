using FinalProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Entities.Concrete
{
    public class Branch : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
