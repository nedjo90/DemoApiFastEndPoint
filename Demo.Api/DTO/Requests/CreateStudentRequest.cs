using Demo.Api.Model;

namespace Demo.Api.DTO.Requests;

public class CreateStudentRequest
{
    public string Name { get; set; }

    public Promotion Promotion { get; set; }
    
    
}