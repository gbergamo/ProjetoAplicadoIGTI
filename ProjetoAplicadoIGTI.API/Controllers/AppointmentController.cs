using Microsoft.AspNetCore.Mvc;
using ProjetoAplicadoIGTI.API.ViewModels;

namespace ProjetoAplicadoIGTI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class AppointmentController : Controller
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
        public IActionResult Insert([FromBody] AppointmentViewModel appointmentViewModel)
        {
            return Ok();
        }

        [HttpPut]
        [Route("Update")]
        public IActionResult Update([FromBody] AppointmentViewModel appointmentViewModel)
        {
            return Ok();
        }

        [HttpPatch]
        [Route("UpdateScheduleTime")]
        public IActionResult UpdateScheduleTime([FromBody] AppointmentViewModel appointmentViewModel)
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
