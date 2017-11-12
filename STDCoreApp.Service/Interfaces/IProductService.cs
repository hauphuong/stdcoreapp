using System;
using System.Collections.Generic;
using System.Text;
using STDCoreApp.Application.ViewModels.Product;
//using STDCoreApp.Utilities.Dtos;

namespace STDCoreApp.Application.Interfaces
{
    public interface IProductService : IDisposable
    {
        List<ProductViewModel> GetAll();

        //PagedResult<ProductViewModel> GetAllPaging(int? categoryId, string keyword, int page, int pageSize);
    }
}
