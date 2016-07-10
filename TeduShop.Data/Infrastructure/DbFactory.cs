namespace TeduShop.Data.Infrastructure
{
    //Khởi tạo đối tượng thay vì new trực tiếp
    public class DbFactory : Disposable, IDbFactory
    {
        private TeduShopDbContext dbContext;

        public TeduShopDbContext Init()
        {
            return dbContext ?? (dbContext = new TeduShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}