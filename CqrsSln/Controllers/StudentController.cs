using CqrsSln.Commands;
using CqrsSln.DTOs;
using CqrsSln.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CqrsSln.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StudentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<bool>> CreateStudent(StudentDto student)
        {
            try
            {
                var response = await _mediator.Send(new AddStudentCommand(student));
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<ActionResult<StudentDto>> GetStudentById(int studentID)
        {
            try
            {
                var response = await _mediator.Send(new GetStudentByIdQuery(studentID));
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
