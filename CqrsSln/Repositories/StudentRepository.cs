using AutoMapper;
using CqrsSln.DTOs;
using CqrsSln.Models;
using Microsoft.EntityFrameworkCore;

namespace CqrsSln.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;
        public StudentRepository(
            ApplicationDbContext dbContext,
            IMapper mapper
            )
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<StudentDto> AddStudent(StudentDto student)
        {
            var entity = _mapper.Map<Student>(student);
            await _dbContext.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            student.Id = entity.Id;
            return student;
        }

        public Task<StudentDto> DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<StudentDto> GetStudentById(int id)
        {
            var entity = await _dbContext.Students.FirstOrDefaultAsync(x => x.Id == id);
            var dto = _mapper.Map<StudentDto>(entity);
            return dto;
        }

        public Task<List<StudentDto>> GetStudents()
        {
            throw new NotImplementedException();
        }

        public Task<StudentDto> UpdateStudent(int id, StudentDto student)
        {
            throw new NotImplementedException();
        }
    }
}
