using System;
using System.Collections.Generic;
using System.Text;

namespace STDCoreApp.Data.Interfaces
{
    public interface IHasOwner<T>
    {
        T OwnerID { set; get; }
    }
}
