using Demo.Api.DTO.Requests;
using Demo.Api.DTO.Responses;
using Demo.Api.Model;
using FastEndpoints;

namespace Demo.Api.Endpoints;

public class CreateStudentEndpoint : Endpoint<CreateStudentRequest, CreateStudentResponse>
{
    public override void Configure()
    {
        Post("/students");
        AllowAnonymous();
    }

    public override async  Task HandleAsync(CreateStudentRequest req, CancellationToken ct)
    {
        var idResult = Student.CreateStudent(req.Name, req.Promotion);
        await SendAsync(new CreateStudentResponse {Id = idResult}, cancellation: ct);
    }
}