using session40_50.Interfaces;
using Microsoft.EntityFrameworkCore;
using session40_50.Models;
using session40_50.Data;


namespace session40_50.Repositories {
    public class ProductRepository: IProductRepository {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context) {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync() {
            // EF Core sẽ tự động chuyển sang SQL và connect tới database
            return await _context.Products.ToListAsync();
        }
    }
}