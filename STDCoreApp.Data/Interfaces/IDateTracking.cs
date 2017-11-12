using System;

namespace STDCoreApp.Data.Interfaces
{
    public interface IDateTracking
    {
        DateTime DateCreated { set; get; }
        DateTime DateModified { set; get; }
    }
}