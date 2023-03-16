using Product.Model;

namespace Product.Service
{

    public class CustomerService
    {
        private AppDbContext _context;

        public CustomerService(AppDbContext context)
        {
            _context = context;
        }

        public short AddCustomer(Product product)
        {
            product.ProductFirstName.ToUpper();
            _context.Products.Add(Products);
            _context.SaveChanges();
            return products.ProductId;
        }

        public List<Product> GetProduct()
        {
            return _context.Product.ToList();
        }



        public ProductService UpdateProduct(string id, Products product)
        {
            throw new NotImplementedException();
        }
        public ProductService DeleteProduct(string id)
        {
            throw new NotImplementedException();

        }
    }
}
