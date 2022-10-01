namespace Tz_HTT.Services
{
    public class ProductServices //: IProductServices
    {
        private ApplicationContext _db;
        public ProductServices(ApplicationContext db)
        {
            _db = db;
        }
        //public async Task<Product> GetProductAsync()
        //{
        //    //try
        //    //{
        //    //    //var result = _db.Products.Include(p => p.Category);
        //    //    //return result.Entity;
        //    //}
        //    //catch (Exception)
        //    //{
        //    //    throw;
        //    //}
        //}
    }
}
