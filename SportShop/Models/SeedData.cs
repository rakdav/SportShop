using Microsoft.EntityFrameworkCore;

namespace SportShop.Models
{
    public static class SeedData
    {
        public static void Change(IApplicationBuilder app)
        {
            StoreDbContext context=app.ApplicationServices.
                CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();
            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate(); 
            }
            if(!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product { Name ="Мяч", Description="Круглый",
                                    Price=34,Category="Мячи"},
                    new Product
                    {
                        Name = "Шайба",
                        Description = "Плоская",
                        Price = 3,
                        Category = "Шайбы"
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
