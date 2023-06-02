using WebStoreNet7.Data;
using WebStoreNet7.Domain.Entities;
using WebStoreNet7.Services.Interfaces;

namespace WebStoreNet7.Services
{
    public class InMemoryProductData : IProductData
    {
        public IEnumerable<Brand> GetBrands() => TestData.Brands;

        public IEnumerable<Section> GetSections() => TestData.Sections;
    }
}
