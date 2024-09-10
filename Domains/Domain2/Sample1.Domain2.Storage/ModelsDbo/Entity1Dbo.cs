using Sample1.Common.Storage.Models;

namespace Sample1.Domain2.Storage.ModelsDbo
{
    public class Entity1Dbo : DboBase<int>
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}