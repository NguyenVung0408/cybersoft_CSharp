using session40_50.Models.DTOs;

namespace session40_50.Interfaces {
    public interface IProductService {
        Task<IEnumerable<ProductResponseDTO>> GetAllProductsAsync();
    }
}