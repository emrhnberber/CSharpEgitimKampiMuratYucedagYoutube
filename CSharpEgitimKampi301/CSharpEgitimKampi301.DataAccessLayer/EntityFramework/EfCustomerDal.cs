﻿using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Repositores;
using CSharpEgitimKampi301.EntitiyLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.EntityFramework
{
    public class EfCustomerDal: GenericRepository<Customer>, ICustomerDal
    {
    }
}
