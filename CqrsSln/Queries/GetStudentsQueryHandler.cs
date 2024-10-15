using CqrsSln.DTOs;
using CqrsSln.Repositories;
using MediatR;

namespace CqrsSln.Queries
{
    public class GetStudentsQueryHandler : IRequestHandler<GetStudentsQuery, List<StudentDto>>
    {
        private readonly IStudentRepository _studentRepository;

        public GetStudentsQueryHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public async Task<List<StudentDto>> Handle(GetStudentsQuery request, CancellationToken cancellationToken)
        {
            return await _studentRepository.GetStudents();
        }
    }
}
