using System;

namespace STDCoreApp.Data.Interfaces
{
    public interface IDateChecking
    {
        DateTime DateCreated { set; get; }
        DateTime DateModified { set; get; }
    }
}