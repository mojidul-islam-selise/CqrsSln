using CqrsSln.DTOs;
using CqrsSln.Repositories;
using MediatR;

namespace CqrsSln.Commands
{
    public class AddStudentCommandHandler: IRequestHandler<AddStudentCommand, StudentDto>
    {
        private readonly IStudentRepository _studentRepository;

        public AddStudentCommandHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<StudentDto> Handle(AddStudentCommand request, CancellationToken cancellationToken)
        {
            return await _studentRepository.AddStudent(request.student);
        }
    }
}
