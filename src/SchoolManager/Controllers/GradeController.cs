using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Application.Grade.Dtos;
using SchoolManagement.Application.Grade.Interfaces;
using SchoolManager.Commons;

namespace SchoolManager.Controllers
{
    [Tags("GradeController")]
    [Route("api/[controller]")]
    [ApiController]
    public class GradeController : ControllerBase
    {

        private readonly IServiceGrade _serviceGrade;

        public GradeController(IServiceGrade serviceGrade)
        {
            _serviceGrade = serviceGrade;
        }

        [HttpPost()]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType((typeof(ApiResponse)), StatusCodes.Status400BadRequest)]
        [ProducesResponseType((typeof(ApiResponse)), StatusCodes.Status401Unauthorized)]

        public async Task<IActionResult> CreateGrade([FromBody] CreateGradeDto grade)
        {
            await _serviceGrade.Add(grade);
            return Created();
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(IEnumerable<GradeDto>), StatusCodes.Status200OK)]
        [ProducesResponseType((typeof(ApiResponse)), StatusCodes.Status400BadRequest)]
        [ProducesResponseType((typeof(ApiResponse)), StatusCodes.Status401Unauthorized)]

        public async Task<IActionResult> GetGradeById([FromRoute] Guid id)
        {
            var result = await _serviceGrade.GetByIdAsync(id);
            return Ok(result);
        }

        [HttpGet()]
        [ProducesResponseType(typeof(IEnumerable<GradeDto>), StatusCodes.Status200OK)]
        [ProducesResponseType((typeof(ApiResponse)), StatusCodes.Status400BadRequest)]
        [ProducesResponseType((typeof(ApiResponse)), StatusCodes.Status401Unauthorized)]

        public async Task<IActionResult> GetGrades([FromQuery] FilterGradeDto? filters)
        {
            var result = await _serviceGrade.GetGradesAsync(filters);
            return Ok(result);
        }

        [HttpPatch("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType((typeof(ApiResponse)), StatusCodes.Status400BadRequest)]
        [ProducesResponseType((typeof(ApiResponse)), StatusCodes.Status401Unauthorized)]

        public async Task<IActionResult> UpdateGrade([FromRoute] Guid id, [FromBody] UpdateGradeDto grade)
        {
            await _serviceGrade.UpdateGrade(id, grade);
            return Ok();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType((typeof(ApiResponse)), StatusCodes.Status400BadRequest)]
        [ProducesResponseType((typeof(ApiResponse)), StatusCodes.Status401Unauthorized)]

        public async Task<IActionResult> DeleteGrade([FromRoute] Guid id)
        {
            await _serviceGrade.DeleteGrade(id);
            return Ok();
        }

    }
}
