using STDCoreApp.Data.Enums;

namespace STDCoreApp.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}