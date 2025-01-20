

using AutoMapper;
using Moq;
using SchoolManagement.Application.Exceptions;
using SchoolManagement.Application.Student.Dtos;
using SchoolManagement.Application.Student.Services;
using SchoolManagement.Domain.Interfaces;
using SchoolManagement.Domain.Students;

namespace test.Application.Services
{
    public class UnitTestStudent
    {
        private readonly Mock<IStudentRepository> _mockStudentRepository;
        private readonly Mock<IMapper> _mockMapper;
        private readonly StudentService _studentService;

        public UnitTestStudent()
        {
            _mockStudentRepository = new Mock<IStudentRepository>();
            _mockMapper = new Mock<IMapper>();
            _studentService = new StudentService(_mockStudentRepository.Object, _mockMapper.Object);
        }

        [Fact]
        public async Task Add_ShouldCallAddAsync_WithCorrectStudent()
        {
            var createStudentDto = new CreateStudentDto
            {
                Identification = "123456789",
                FirsName = "Juan",
                LastName = "Lazo"
            };

            await _studentService.Add(createStudentDto);

            _mockStudentRepository.Verify(repo => repo.AddAsync(It.Is<Student>(s =>
                s.Identification == createStudentDto.Identification &&
                s.FirsName == createStudentDto.FirsName &&
                s.LastName == createStudentDto.LastName)), Times.Once);
        }

        [Fact]
        public async Task GetByIdAsync_ShouldThrowNotFoundException_WhenStudentNotFound()
        {
            var studentId = "123456789";
            _mockStudentRepository
                .Setup(repo => repo.GetStudentByIdentifiAsync(studentId))
                .ReturnsAsync((Student)null);

            var exception = await Assert.ThrowsAsync<NotFoundException>(() => _studentService.GetByIdAsync(studentId));
            Assert.Equal("student not found", exception.Message);
        }

        [Fact]
        public async Task GetByIdAsync_ShouldReturnStudentDto_WhenStudentFound()
        {
            var studentId = "123456789";
            var student = new Student
            {
                Id = Guid.NewGuid(),
                Identification = studentId,
                FirsName = "Juan",
                LastName = "Lazo"
            };
            var studentDto = new StudentDto
            {
                Identification = studentId,
                FirsName = "Juan",
                LastName = "Lazo"
            };

            _mockStudentRepository
                .Setup(repo => repo.GetStudentByIdentifiAsync(studentId))
                .ReturnsAsync(student);
            _mockMapper
                .Setup(m => m.Map<StudentDto>(student))
                .Returns(studentDto);

            var result = await _studentService.GetByIdAsync(studentId);

            Assert.Equal(studentDto, result);
        }

        [Fact]
        public async Task DeleteStudent_ShouldThrowNotFoundException_WhenStudentNotFound()
        {
            var studentId = "123456789";
            _mockStudentRepository
                .Setup(repo => repo.GetStudentByIdentifiAsync(studentId))
                .ReturnsAsync((Student)null);

            var exception = await Assert.ThrowsAsync<NotFoundException>(() => _studentService.DeleteStudent(studentId));
            Assert.Equal("student not found", exception.Message);
        }

        [Fact]
        public async Task DeleteStudent_ShouldCallDeleteAsync_WhenStudentFound()
        {
            var studentId = "123456789";
            var student = new Student
            {
                Id = Guid.NewGuid(),
                Identification = studentId,
                FirsName = "Juan",
                LastName = "Lazo"
            };

            _mockStudentRepository
                .Setup(repo => repo.GetStudentByIdentifiAsync(studentId))
                .ReturnsAsync(student);

            await _studentService.DeleteStudent(studentId);

            _mockStudentRepository.Verify(repo => repo.DeleteAsync(student), Times.Once);
        }

        [Fact]
        public async Task UpdateStudent_ShouldThrowNotFoundException_WhenStudentNotFound()
        {
            var studentId = "123456789";
            var updateDto = new UpdateStudentDto
            {
                FirsName = "Juan Updated",
                LastName = "Lazo Updated"
            };

            _mockStudentRepository
                .Setup(repo => repo.GetStudentByIdentifiAsync(studentId))
                .ReturnsAsync((Student)null);

            var exception = await Assert.ThrowsAsync<NotFoundException>(() => _studentService.UpdateStudent(studentId, updateDto));
            Assert.Equal("student not found", exception.Message);
        }

        [Fact]
        public async Task UpdateStudent_ShouldApplyPatch_WhenStudentFound()
        {
            var studentId = "123456789";
            var student = new Student
            {
                Id = Guid.NewGuid(),
                Identification = studentId,
                FirsName = "Juan",
                LastName = "Lazo"
            };
            var updateDto = new UpdateStudentDto
            {
                FirsName = "Juan Updated",
                LastName = "Lazo Updated"
            };

            _mockStudentRepository
                .Setup(repo => repo.GetStudentByIdentifiAsync(studentId))
                .ReturnsAsync(student);

            await _studentService.UpdateStudent(studentId, updateDto);

            _mockStudentRepository.Verify(repo => repo.UpdateAsync(student), Times.Once);
            Assert.Equal("Juan Updated", student.FirsName);
            Assert.Equal("Lazo Updated", student.LastName);
        }
    }
}
