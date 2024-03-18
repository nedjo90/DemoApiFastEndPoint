using Demo.Api.Model;
using FastEndpoints;

namespace Demo.Api.Endpoints;

public class GetAllStudentsEndpoint : EndpointWithoutRequest
{
    public override void Configure()
    {
        Get("/students");
        AllowAnonymous(); //Ici dans la réalité on vérifie le rôle de l'utilisateur
    }

    public override async Task HandleAsync(CancellationToken ct)
    {
        List<Student> students = new List<Student>
        {
            new Student {Id= 1, Name = "Cédric", Promotion = new Promotion {Name = "PROF"}},
            new Student {Id= 1, Name = "Louis", Promotion = new Promotion {Name = "FRONT"}},
            new Student {Id= 1, Name = "Necati", Promotion = new Promotion {Name = "CDA"}}
        };

        await SendAsync(students, cancellation: ct);
    }
}