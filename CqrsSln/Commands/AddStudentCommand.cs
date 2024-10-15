using CqrsSln.DTOs;
using MediatR;

namespace CqrsSln.Commands
{
    public record AddStudentCommand(StudentDto student): IRequest<StudentDto>;
}
