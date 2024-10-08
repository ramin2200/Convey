using Convey.CQRS.Commands;
using Microsoft.AspNetCore.Mvc;
using Ramin.Services.Products.Application.Commands;

namespace Ramin.Services.Products.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ICommandDispatcher _dispatcher;

        public ProductsController(ICommandDispatcher dispatcher)
        {
            _dispatcher = dispatcher;
            //_logger = logger;
        }
        //[HttpGet]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = Random.Shared.Next(-20, 55),
        //        Summary = "gbvgd"
        //    })
        //    .ToArray();
        //}
        //[Authorize]
        [HttpPost]
        public async Task<ActionResult> Post(AddProductCommand addProductCmd)
        {
            await _dispatcher.SendAsync(addProductCmd);
            return NoContent();
        }

    }
}