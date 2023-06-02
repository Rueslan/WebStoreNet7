using WebStoreNet7.Domain.Entities.Base;
using WebStoreNet7.Domain.Entities.Base.Interfaces;

namespace WebStoreNet7.Domain.Entities
{
    internal class Section : NamedEntity, IOrderedEntity
    {
        public int Order { get; set; }
        public int? ParentId { get; set; }
    }
}
