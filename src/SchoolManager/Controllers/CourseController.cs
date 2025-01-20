using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Application.Course.Interfaces;
using SchoolManagement.Application.Teacher.Dtos;
using SchoolManager.Commons;

namespace SchoolManager.Controllers
{
    [Tags("CourseController")]
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly IServiceCourse _serviceCourse;

        public CourseController(IServiceCourse serviceCourse)
        {
            _serviceCourse = serviceCourse;
        }
        [HttpPost()]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType((typeof(ApiResponse)), StatusCodes.Status400BadRequest)]
        [ProducesResponseType((typeof(ApiResponse)), StatusCodes.Status401Unauthorized)]

        public async Task<IActionResult> CreateCourse([FromBody] CreateCourseDto course)
        {
            await _serviceCourse.Add(course);
            return Created();
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(IEnumerable<CourseDto>), StatusCodes.Status200OK)]
        [ProducesResponseType((typeof(ApiResponse)), StatusCodes.Status400BadRequest)]
        [ProducesResponseType((typeof(ApiResponse)),StatusCodes.Status401Unauthorized)]

        public async Task<IActionResult> GetCourseById([FromRoute] Guid id)
        {
            var result = await _serviceCourse.GetByIdAsync(id);
            return Ok(result);
        }

        [HttpGet()]
        [ProducesResponseType(typeof(IEnumerable<CourseDto>), StatusCodes.Status200OK)]
        [ProducesResponseType((typeof(ApiResponse)), StatusCodes.Status400BadRequest)]
        [ProducesResponseType((typeof(ApiResponse)), StatusCodes.Status401Unauthorized)]

        public async Task<IActionResult> GetCourses([FromQuery] FilterCourseDto? filters)
        {
            var result = await _serviceCourse.GetCoursesAsync(filters);
            return Ok(result);
        }

        [HttpPatch("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType((typeof(ApiResponse)), StatusCodes.Status400BadRequest)]
        [ProducesResponseType((typeof(ApiResponse)), StatusCodes.Status401Unauthorized)]

        public async Task<IActionResult> UpdateCourse([FromRoute] Guid id, [FromBody] UpdateCourseDto course)
        {
            await _serviceCourse.UpdateCourse(id, course);
            return Ok();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType((typeof(ApiResponse)), StatusCodes.Status400BadRequest)]
        [ProducesResponseType((typeof(ApiResponse)), StatusCodes.Status401Unauthorized)]

        public async Task<IActionResult> DeleteCourse([FromRoute] Guid id)
        {
            await _serviceCourse.DeleteCourse(id);
            return Ok();
        }
    }
}
