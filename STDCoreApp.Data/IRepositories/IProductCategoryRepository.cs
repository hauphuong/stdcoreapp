using System;
using System.Collections.Generic;
using System.Text;
using STDCoreApp.Data.Entities;
//using STDCoreApp.Infrastructure.Interfaces;

namespace STDCoreApp.Data.IRepositories
{
    public interface IProductCategoryRepository //: IRepository<ProductCategory, int>
    {
        List<ProductCategory> GetByAlias(string alias);
    }
}
