//using AutoMapper.QueryableExtensions;
//using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using STDCoreApp.Application.Interfaces;
using STDCoreApp.Application.ViewModels.System;
//using STDCoreApp.Data.IRepositories;

namespace STDCoreApp.Application.Implementation
{
    public class FunctionService //: IFunctionService
    {
       // private IFunctionRepository _functionRepository;

        //public FunctionService(IFunctionRepository functionRepository)
        //{
        //    _functionRepository = functionRepository;
        //}

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        //public Task<List<FunctionViewModel>> GetAll()
        //{
        //    return _functionRepository.FindAll().ProjectTo<FunctionViewModel>().ToListAsync();
        //}

        public List<FunctionViewModel> GetAllByPermission(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}