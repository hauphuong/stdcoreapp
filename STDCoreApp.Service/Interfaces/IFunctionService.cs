using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using STDCoreApp.Application.ViewModels.System;

namespace STDCoreApp.Application.Interfaces
{
    public interface IFunctionService : IDisposable
    {
        Task<List<FunctionViewModel>> GetAll();

        List<FunctionViewModel> GetAllByPermission(Guid userId);
    }
}