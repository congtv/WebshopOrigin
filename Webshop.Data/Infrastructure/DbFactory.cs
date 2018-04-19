using Webshop.Data;

namespace WebShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private WebshopDbContext dbContext;

        public WebshopDbContext Init()
        {
            return dbContext ?? (dbContext = new WebshopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}