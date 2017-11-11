using STDCoreApp.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace STDCoreApp.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}
