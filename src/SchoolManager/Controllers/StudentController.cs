﻿using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Application.Student.Dtos;
using SchoolManagement.Application.Student.Interfaces;
using SchoolManager.Commons;

namespace SchoolManager.Controllers
{
    [Tags("StudentController")]
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
       private readonly IServiceStudent _serviceStudent;

        public StudentController(IServiceStudent serviceStudent)
        {
            _serviceStudent = serviceStudent;
        }
        [Authorize]
        [HttpPost()]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType((typeof(ApiResponse)), StatusCodes.Status400BadRequest)]
        [ProducesResponseType((typeof(ApiResponse)), StatusCodes.Status401Unauthorized)]

        public async Task<IActionResult> CreateStudent([FromBody] CreateStudentDto student)
        {
            await _serviceStudent.Add(student);
            return Created();
        }
        [Authorize]
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(StudentDto), StatusCodes.Status200OK)]
        [ProducesResponseType((typeof(ApiResponse)), StatusCodes.Status400BadRequest)]
        [ProducesResponseType((typeof(ApiResponse)), StatusCodes.Status401Unauthorized)]

        public async Task<IActionResult> GetStudentById([FromRoute] string id)
        {
            var result = await _serviceStudent.GetByIdAsync(id);
            return Ok(result);
        }
        [Authorize]
        [HttpGet()]
        [ProducesResponseType(typeof(IEnumerable<StudentDto>), StatusCodes.Status200OK)]
        [ProducesResponseType((typeof(ApiResponse)), StatusCodes.Status400BadRequest)]
        [ProducesResponseType((typeof(ApiResponse)), StatusCodes.Status401Unauthorized)]

        public async Task<IActionResult> GetStudents([FromQuery] FilterStudentDto? filters)
        {
            var result = await _serviceStudent.GetStudentsAsync(filters);
            return Ok(result);
        }
        [Authorize]
        [HttpPatch("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType((typeof(ApiResponse)), StatusCodes.Status400BadRequest)]
        [ProducesResponseType((typeof(ApiResponse)), StatusCodes.Status401Unauthorized)]

        public async Task<IActionResult> UpdateStudent([FromRoute] string id, [FromBody] UpdateStudentDto student)
        {
            await _serviceStudent.UpdateStudent(id, student);
            return Ok();
        }
        [Authorize]
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType((typeof(ApiResponse)), StatusCodes.Status400BadRequest)]
        [ProducesResponseType((typeof(ApiResponse)), StatusCodes.Status401Unauthorized)]

        public async Task<IActionResult> DeleteStudent([FromRoute] string id)
        {
            await _serviceStudent.DeleteStudent(id);
            return Ok();
        }
    }
}
