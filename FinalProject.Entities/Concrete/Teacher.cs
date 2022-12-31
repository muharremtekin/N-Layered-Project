using FinalProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Entities.Concrete
{
    public class Teacher : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Phone_Number { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public DateTime Date_Of_Birth { get; set; }
        public int BranchID { get; set; }
    }
}
