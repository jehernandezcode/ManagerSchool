using System.Linq.Expressions;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using SchoolManagement.Application.Exceptions;
using SchoolManagement.Application.Teacher.Dtos;
using SchoolManagement.Application.Teacher.Interfaces;
using SchoolManagement.Domain.Interfaces;

namespace SchoolManagement.Application.Teacher.Services
{
    public class ServiceTeacher : IServiceTeacher
    {

        private readonly ITeacherRepository _repository;
        private readonly IMapper _mapper;
        public ServiceTeacher(ITeacherRepository repository, IMapper mapper)
        {
            _repository = repository; 
            _mapper = mapper;   
        }

        public async Task Add(CreateTeacherDto teacher)
        {
            var newTeacher = new Domain.Teachers.Teacher { Id = Guid.NewGuid(), FirstName = teacher.FirstName, LastName = teacher.LastName};
            await _repository.AddAsync(newTeacher);
        }

        public async Task DeleteTeacher(Guid id)
        {
            var teacher = await _repository.GetByIdAsync(id);

            if (teacher == null) { throw new NotFoundException("teacher not found"); }

            await _repository.DeleteAsync(teacher);
        }

        public async Task<TeacherDto?> GetByIdAsync(Guid id)
        {
            var teacher = await _repository.GetByIdAsync(id);

            if (teacher == null)
            {
                throw new NotFoundException("teacher not found");
            }

            return _mapper.Map<TeacherDto>(teacher);
        }

        public async Task<IEnumerable<TeacherDto>> GetTeachersAsync(FilterTeacherDto? filters)
        {
            Expression<Func<Domain.Teachers.Teacher, bool>>? filter = null;

            if (filters != null)
            {
                filter = teacher =>
                (string.IsNullOrEmpty(filters.FirstName) || teacher.FirstName.ToLower() == filters.FirstName.ToLower()) &&
                (string.IsNullOrEmpty(filters.lastName) || teacher.LastName.ToLower() == filters.lastName.ToLower());
            }

            var teacher = await _repository.GetAllAsync(filter);

            return _mapper.Map<IEnumerable<TeacherDto>>(teacher);
        }

        public async Task UpdateTeacher(Guid id, UpdateTeacherDto updateTeacherDto)
        {

            var patchDocument = new JsonPatchDocument<Domain.Teachers.Teacher>();

            if(updateTeacherDto.FirstName != null)
            {
                patchDocument.Replace(data => data.FirstName, updateTeacherDto.FirstName);
            }

            if (updateTeacherDto.LastName != null)
            {
                patchDocument.Replace(data => data.LastName, updateTeacherDto.LastName);
            }

            var existingTeacher = await _repository.GetByIdAsync(id);

            if (existingTeacher == null)
            {
                throw new NotFoundException("teacher not found");
            }
            patchDocument.ApplyTo(existingTeacher);

            await _repository.UpdateAsync(existingTeacher);
        }
    }
}
