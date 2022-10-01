using Microsoft.AspNetCore.Mvc;

namespace Tz_HTT.Controllers
{
    [ApiController]
    public class GetProductController : ControllerBase
    {
        private readonly ILogger<GetProductController> _logger;
        private ApplicationContext _db;
        public GetProductController(ApplicationContext db, ILogger<GetProductController> logger)
        {
            _db = db;
            _logger = logger;
        }
        [HttpGet]
        [Route("Product")]
        public async Task<IActionResult> GetProduct()
        {
            try
            {
                _logger.LogInformation("Запрос GetProduct получен");
                var result = _db.Products.Join(_db.Categories,
                                               p => p.Id,
                                               c => c.Id,
                                               (p, c) => new {Id = p.Id, Name = p.Name, Price = p.Price, Category = c.NameCategory });
                _logger.LogInformation("Запрос GetProduct выполнен");

                return Ok(result);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(ex.Message);
            }
        }
    }
}