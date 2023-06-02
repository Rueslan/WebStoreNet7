namespace WebStoreNet7.Domain.Entities.Base.Interfaces
{
    public interface IOrderedEntity: IEntity
    {
        int Order { get; }
    }
}
