using Sample1.Common.Storage.Interfaces;

namespace Sample1.Common.Storage.Models
{
    public class DboBase<T> : ISample1DbObject
    {
        public T Id { get; set; }
    }
}