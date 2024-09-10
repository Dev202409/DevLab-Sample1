using Sample1.Common.Storage.Models;

namespace Sample1.Domain1.Storage.ModelsDbo
{
    public class Entity2Dbo : DboBase<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}