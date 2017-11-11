namespace STDCoreApp.Data.Interfaces
{
    public interface IHasOwner<T>
    {
        T OwnerID { set; get; }
    }
}