using Microsoft.AspNetCore.Mvc;
using ProjetoAplicadoIGTI.API.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAplicadoIGTI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class ProviderController : Controller
    {
        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            return Ok();
        }

        [HttpGet]
        [Route("GetById")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        [HttpPost]
        [Route("Insert")]
        public IActionResult Insert([FromBody] ProviderViewModel providerViewModel)
        {
            return Ok();
        }

        [HttpPut]
        [Route("Update")]
        public IActionResult Update([FromBody] ProviderViewModel providerViewModel)
        {
            return Ok();
        }

        [HttpPatch]
        [Route("UpdateDescription")]
        public IActionResult UpdateScheduleTime([FromBody] ProviderViewModel providerViewModel)
        {
            return Ok();
        }

        [HttpDelete]
        [Route("Delete")]
        public IActionResult Delete([FromRoute] int id)
        {
            return Ok();
        }
    }
}
