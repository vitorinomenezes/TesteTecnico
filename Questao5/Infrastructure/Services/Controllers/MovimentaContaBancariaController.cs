using MediatR;
using Microsoft.AspNetCore.Mvc;
using Questao5.Infrastructure.Database.QueryStore.Requests;

//using Questao5.Infrastructure.Database.QueryStore;
using Questao5.Infrastructure.Sqlite;

namespace Questao5.Infrastructure.Services.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovimentaContaBancariaController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly DatabaseConfig _appContext;

        public MovimentaContaBancariaController(DatabaseConfig AppContext, IMediator mediator)
        {
            _appContext = AppContext;
            _mediator = mediator;            
        }


        [HttpGet(Name = "GetAllCountsQuery")]
        public async Task<IActionResult> Get()
        {
            var result = await _mediator.Send(new GetTodasContassQueryHandler(_appContext).Handle());
            return Ok(null);
        }

        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        //private readonly ILogger<MovimentaContaBancariaController> _logger;

        //public MovimentaContaBancariaController(ILogger<MovimentaContaBancariaController> logger)
        //{
        //    _logger = logger;
        //}

        //[HttpGet(Name = "GetWeatherForecast")]
        //public IEnumerable<MovimentaContaBancaria> Get()
        //{
        //    return Enumerable.Range(1, 5).Select(index => new MovimentaContaBancaria
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = Random.Shared.Next(-20, 55),
        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}
    }

    //public class MovimentaContaBancariaController : ControllerBase
    //{
    //    private readonly IMediator _mediator;
    //    public MovimentaContaBancariaController(IDatabaseBootstrap AppContext, IMediator mediator)
    //    {
    //        _mediator = mediator;
    //    }

    //    [HttpGet]
    //    public async Task<IActionResult> GetAllCountsQuery()
    //    {
    //        //var result = await _mediator.Send(new GetAllCountsQuery());
    //        return Ok(null);
    //    }



    //    [HttpGet(Name = "MovimentarContaBancaria")]

    //    public IEnumerable<MovimentaContaBancaria> Get()
    //    {
    //        //return _mediator.Send()

    //        return null;
    //    }
    //}
}