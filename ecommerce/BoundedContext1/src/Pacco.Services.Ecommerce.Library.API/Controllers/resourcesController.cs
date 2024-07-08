using Convey.WebApi.CQRS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pacco.Services.Ecommerce.Application.Commands;
using Pacco.Services.Ecommerce.Library.API;
using Swashbuckle.AspNetCore.Annotations;
using Convey.CQRS.Commands;
using Microsoft.AspNetCore.Authorization;

namespace Pacco.Services.Ecommerce.Library.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class resourcesController : ControllerBase
    {
        private readonly ICommandDispatcher _dispatcher;

        public resourcesController(ICommandDispatcher dispatcher)
        {
            _dispatcher = dispatcher;
            //_logger = logger;
        }
        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = "gbvgd"
            })
            .ToArray();
        }
        //[Authorize]
        [HttpPost]
        public async Task<ActionResult> Post(AddResource addResource)
        {
            await _dispatcher.SendAsync(addResource);
            return NoContent();
        }

    }
}