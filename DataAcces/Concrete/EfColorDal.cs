﻿using Core.DataAccess.EntityFramework;
using DataAcces.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Concrete
{
    public class EfColorDal : EfEntityRepositoryBase<Color,RentCarsContext>,IColorDal
    {
                   
    }
}
