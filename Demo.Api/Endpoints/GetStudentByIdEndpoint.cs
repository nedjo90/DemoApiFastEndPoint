using Demo.Api.DTO.Requests;
using Demo.Api.Model;
using FastEndpoints;

namespace Demo.Api.Endpoints;

public class GetStudentByIdEndpoint : Endpoint<GetStudentByIdRequest>
{
    public override void Configure()
    {
        Get("/students/{id}");
        AllowAnonymous();
    }

    public override async Task HandleAsync(GetStudentByIdRequest req, CancellationToken ct)
    {
        var student = Student.GetStudentById(req.Id);

        await SendAsync(student, cancellation: ct);
    }
}