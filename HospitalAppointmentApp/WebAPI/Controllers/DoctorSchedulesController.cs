using Application.Features.DoctorSchedules.Commands.Create;
using Application.Features.DoctorSchedules.Commands.Delete;
using Application.Features.DoctorSchedules.Commands.Update;
using Application.Features.DoctorSchedules.Queries.GetById;
using Application.Features.DoctorSchedules.Queries.GetList;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorSchedulesController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateDoctorScheduleCommand command)
        {
            CreateDoctorScheduleResponse response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            GetByIdDoctorScheduleQuery query = new() { Id = id };
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] GetListDoctorScheduleQuery query)
        {
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateDoctorScheduleCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            DeleteDoctorScheduleCommand command = new() { Id = id };
            await _mediator.Send(command);
            return Ok("Deleted!");
        }
    }
}
