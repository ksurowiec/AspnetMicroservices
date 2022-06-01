using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Infrastructure
{
    public interface ICatalogContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
