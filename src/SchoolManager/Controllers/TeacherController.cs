using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Application.Teacher.Dtos;
using SchoolManagement.Application.Teacher.Interfaces;
using SchoolManager.Commons;

namespace SchoolManager.Controllers
{
    [Tags("TeacherController")]
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly IServiceTeacher _serviceTeacher;

        public TeacherController(IServiceTeacher serviceTeacher)
        {
            _serviceTeacher = serviceTeacher;
        }
        [Authorize]
        [HttpPost()]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType((typeof(ApiResponse)), StatusCodes.Status400BadRequest)]
        [ProducesResponseType((typeof(ApiResponse)), StatusCodes.Status401Unauthorized)]

        public async Task<IActionResult> CreateTeacher([FromBody] CreateTeacherDto teacher)
        {
            await _serviceTeacher.Add(teacher);
            return Created();
        }
        [Authorize]
        [HttpGet()]
        [ProducesResponseType(typeof(IEnumerable<TeacherDto>), StatusCodes.Status200OK)]
        [ProducesResponseType((typeof(ApiResponse)), StatusCodes.Status400BadRequest)]
        [ProducesResponseType((typeof(ApiResponse)), StatusCodes.Status401Unauthorized)]

        public async Task<IActionResult> GetTeachers([FromQuery] FilterTeacherDto? filters)
        {
            var result = await _serviceTeacher.GetTeachersAsync(filters);
            return Ok(result);
        }
        [Authorize]
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(TeacherDto), StatusCodes.Status200OK)]
        [ProducesResponseType((typeof(ApiResponse)), StatusCodes.Status400BadRequest)]
        [ProducesResponseType((typeof(ApiResponse)), StatusCodes.Status401Unauthorized)]

        public async Task<IActionResult> GetTeacherById([FromRoute] Guid id)
        {
            var result = await _serviceTeacher.GetByIdAsync(id);
            return Ok(result);
        }
        [Authorize]
        [HttpPatch("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType((typeof(ApiResponse)), StatusCodes.Status400BadRequest)]
        [ProducesResponseType((typeof(ApiResponse)), StatusCodes.Status401Unauthorized)]

        public async Task<IActionResult> UpdateTeacher([FromRoute] Guid id, [FromBody] UpdateTeacherDto teacher)
        {
            await _serviceTeacher.UpdateTeacher(id, teacher);
            return Ok();
        }
        [Authorize]
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType((typeof(ApiResponse)), StatusCodes.Status400BadRequest)]
        [ProducesResponseType((typeof(ApiResponse)), StatusCodes.Status401Unauthorized)]

        public async Task<IActionResult> DeleteTeacher([FromRoute] Guid id)
        {
            await _serviceTeacher.DeleteTeacher(id);
            return Ok();
        }
    }
}
