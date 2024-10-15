using CqrsSln.DTOs;
using MediatR;

namespace CqrsSln.Queries
{
    public record GetStudentsQuery(): IRequest<List<StudentDto>>;
}
