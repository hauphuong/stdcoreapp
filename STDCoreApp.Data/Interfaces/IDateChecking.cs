using System;
using System.Collections.Generic;
using System.Text;

namespace STDCoreApp.Data.Interfaces
{
    public interface IDateChecking
    {
        DateTime DateCreated { set; get; }
        DateTime DateModified { set; get; }
    }
}
