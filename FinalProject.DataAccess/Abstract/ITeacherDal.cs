﻿using FinalProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DataAccess.Abstract
{
    interface ITeacherDal : IEntityRepository<Teacher>
    {
    }
}