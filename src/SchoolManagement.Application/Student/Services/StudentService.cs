using System.Linq.Expressions;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using SchoolManagement.Application.Exceptions;
using SchoolManagement.Application.Student.Dtos;
using SchoolManagement.Application.Student.Interfaces;
using SchoolManagement.Domain.Interfaces;

namespace SchoolManagement.Application.Student.Services
{
    public class StudentService : IServiceStudent
    {
        private readonly IStudentRepository  _studentRepository;
        private readonly IMapper _mapper;

        public StudentService(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        public async Task Add(CreateStudentDto student)
        {
            var newStudent = new Domain.Students.Student { Id = Guid.NewGuid(), Identification= student.Identification, FirsName= student.FirsName, LastName=student.LastName };
            await _studentRepository.AddAsync(newStudent);
        }

        public async Task DeleteStudent(string id)
        {
            var student = await _studentRepository.GetStudentByIdentifiAsync(id);

            if (student != null)
            {
                throw new NotFoundException("student not found");
            }

            await _studentRepository.DeleteAsync(student);
        }

        public async Task<StudentDto?> GetByIdAsync(string id)
        {
            var student = await _studentRepository.GetStudentByIdentifiAsync(id);

            if (student == null)
            {
                throw new NotFoundException("student not found");
            }

            return _mapper.Map<StudentDto>(student);
        }

        public async Task<IEnumerable<StudentDto>> GetStudentsAsync(FilterStudentDto filters)
        {
            Expression<Func<Domain.Students.Student, bool>>? filter = null;

            if (filters != null)
            {
                filter = student =>
                (string.IsNullOrEmpty(filters.FirsName) || student.FirsName.ToLower() == filters.FirsName.ToLower()) &&
                (string.IsNullOrEmpty(filters.LastName) || student.LastName.ToLower() == filters.LastName.ToLower()) &&
                (string.IsNullOrEmpty(filters.Identification) || student.Identification.ToLower() == filters.Identification.ToLower());
            }

            var students = await _studentRepository.GetAllAsync(filter);

            return _mapper.Map<IEnumerable<StudentDto>>(students);
        }

        public async Task UpdateStudent(string id, UpdateStudentDto updateStudentDto)
        {

            var patchDocument = new JsonPatchDocument<Domain.Students.Student>();

            if (updateStudentDto.Identification != null)
            {
                patchDocument.Replace(data => data.Identification, updateStudentDto.Identification);
            }

            if (updateStudentDto.FirsName != null)
            {
                patchDocument.Replace(data => data.FirsName, updateStudentDto.FirsName);
            }

            if (updateStudentDto.LastName != null)
            {
                patchDocument.Replace(data => data.LastName, updateStudentDto.LastName);
            }

            var student = await _studentRepository.GetStudentByIdentifiAsync(id) ?? throw new NotFoundException("student not found");

            patchDocument.ApplyTo(student);

            await _studentRepository.UpdateAsync(student);
        }
    }
}
