using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalutiWebApi.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/saluti")]
    public class SalutiController : Controller
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult TestConnex()
        {
            string hostName = Environment.MachineName;
            return Ok(new InfoMsg(DateTime.Today, $"Saluti sono la tua prima web api in cloud dalla VM " + hostName));
        }

        [HttpGet("{Nome}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<InfoMsg> getSaluti2(string Nome)
        {
            string hostName = Environment.MachineName;
            return Ok(new InfoMsg(DateTime.Today, $"Saluti {Nome}, sono la tua web api aggiornata alla versione 1.1 in Azure App Services nella VM " + hostName + ", deploy con VS2019"));
        }

        [HttpGet("{Nome}/{version}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<InfoMsg> getSaluti3(string Nome, string version)
        {
            string hostName = Environment.MachineName;
            return Ok(new InfoMsg(DateTime.Today, $"Saluti {Nome}, sono la versione " + version + " in Azure App Services nella VM " + hostName + ", deploy con VS2019 su di uno slot di produzione"));
        }
    }
}
