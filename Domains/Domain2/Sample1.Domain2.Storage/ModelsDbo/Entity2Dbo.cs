using Sample1.Common.Storage.Models;

namespace Sample1.Domain2.Storage.ModelsDbo
{
    public class Entity2Dbo : DboBase<int>
    {
        public string Title { get; set; }
        public int Year { get; set; }
    }
}