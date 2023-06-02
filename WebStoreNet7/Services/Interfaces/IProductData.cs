using WebStoreNet7.Domain.Entities;

namespace WebStoreNet7.Services.Interfaces
{
    public interface IProductData
    {
        IEnumerable<Section> GetSections();

        IEnumerable<Brand> GetBrands();
    }
}
