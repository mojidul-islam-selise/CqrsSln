using CqrsSln.DTOs;
using MediatR;

namespace CqrsSln.Queries
{
    public record GetStudentByIdQuery(int id): IRequest<StudentDto>;
}
