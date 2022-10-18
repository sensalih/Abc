using Abc.Northwind.Entities.Concrete;
using System.Collections.Generic;

namespace Abc.Northwind.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
