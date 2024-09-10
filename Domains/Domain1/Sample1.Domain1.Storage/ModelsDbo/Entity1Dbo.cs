using Sample1.Common.Storage.Models;

namespace Sample1.Domain1.Storage.ModelsDbo
{
    public class Entity1Dbo : DboBase<int>
    {
        public string Label { get; set; }
        public bool IsActive { get; set; }
        public bool EFTest { get; set; }
    }
}