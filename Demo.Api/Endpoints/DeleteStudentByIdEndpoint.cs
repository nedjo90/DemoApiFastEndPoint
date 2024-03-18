using Demo.Api.DTO.Requests;
using Demo.Api.DTO.Responses;
using Demo.Api.Model;
using FastEndpoints;

namespace Demo.Api.Endpoints;

public class DeleteStudentByIdEndpoint : Endpoint<DeleteStudentByIdRequest, DeleteStudentResponse>
{
    public override void Configure()
    {
        Delete("/student/{id}");
        AllowAnonymous();
    }

    public override async Task HandleAsync(DeleteStudentByIdRequest req, CancellationToken ct)
    {
        bool isDeleted = Student.DeleteStudenById(1);

        await SendAsync(new DeleteStudentResponse { IsDeleted = isDeleted }, cancellation: ct);
    }
}