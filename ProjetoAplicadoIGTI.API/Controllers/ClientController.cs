using Microsoft.AspNetCore.Mvc;
using ProjetoAplicadoIGTI.API.ViewModels;

namespace ProjetoAplicadoIGTI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class ClientController : Controller
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
        public IActionResult Insert([FromBody] ClientViewModel clientViewModel)
        {
            return Ok();
        }

        [HttpPut]
        [Route("Update")]
        public IActionResult Update([FromBody] ClientViewModel clientViewModel)
        {
            return Ok();
        }

        [HttpPatch]
        [Route("UpdatePhoto")]
        public IActionResult UpdateScheduleTime([FromBody] ClientViewModel clientViewModel)
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
