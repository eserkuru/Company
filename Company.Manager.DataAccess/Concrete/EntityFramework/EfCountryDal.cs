using Company.Core.DataAccess.EntityFramework;
using Company.Core.Entities.Address;
using Company.Manager.DataAccess.Abstract;
using Company.Manager.DataAccess.Concrete.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Company.Manager.DataAccess.Concrete.EntityFramework
{
    public class EfCountryDal<T> : EfEntityReporsitoryBase<Country, T>, ICountryDal where T : DbContext, new()
    {
    }
}
