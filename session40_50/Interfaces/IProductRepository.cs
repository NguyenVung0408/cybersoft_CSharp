using session40_50.Models;

namespace session40_50.Interfaces {
    public interface IProductRepository {
        Task<IEnumerable<Product>> GetAllProductsAsync();
    }
}