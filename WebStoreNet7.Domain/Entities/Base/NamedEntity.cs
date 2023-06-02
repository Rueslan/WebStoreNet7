using WebStoreNet7.Domain.Entities.Base.Interfaces;

namespace WebStoreNet7.Domain.Entities.Base
{
    public abstract class NamedEntity : Entity, INamedEntity
    {
        public string Name { get; set; }
    }
}
