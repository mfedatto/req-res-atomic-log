using MFedatto.ReqRes.LogMonolitico.Api.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MFedatto.ReqRes.LogMonolitico.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : ControllerBase
    {
        [HttpGet]
        public ActionResult<Pessoa[]> Index()
        {
            Pessoa[] result = new Pessoa[]
            {
                new Pessoa("Christie Rose"),
                new Pessoa("Monty Freeman"),
                new Pessoa("Jaskaran Mcphee"),
                new Pessoa("Malaika Lawson"),
                new Pessoa("Kathy Anthony"),
                new Pessoa("Lilia Pena"),
                new Pessoa("Rhiann Bryant"),
                new Pessoa("Thalia Pineda"),
                new Pessoa("Kaydee Quintero"),
                new Pessoa("Mahek Mcneill"),
            };

            return Ok(result);
        }
    }
}
