using Company.Core.DataAccess.EntityFramework;
using Company.Core.Entities.Address;
using Company.Manager.DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Manager.DataAccess.Concrete.EntityFramework
{
    public class EfCityDal<T> : EfEntityReporsitoryBase<City, T>, ICityDal where T : DbContext, new()
    {
    }
}
