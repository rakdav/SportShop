namespace SportShop.Models
{
    public class EFStroryRepository:IStoreRepository
    {
        private StoreDbContext context;

        public EFStroryRepository(StoreDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Product> Products =>context.Products;
    }
}
