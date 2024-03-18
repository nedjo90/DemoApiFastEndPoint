namespace Demo.Api.Model;

public class Student
{
    public int Id { get; set; }

    public string Name { get; set; }

    public Promotion Promotion { get; set; }

    public static Student GetStudentById(int id)
    {
        return new Student {Id = id, Name = "Ekrem", Promotion = new Promotion{Name = "maternel"}};
    }

    public static int CreateStudent(string name, Promotion promotion)
    {
        Console.WriteLine($"Name: {name}\n" +
                          $"Promotion: {promotion.Name}");
        return 1;
    }

    public static bool DeleteStudenById(int id)
    {
        Console.WriteLine($"Deleting student with id {id}");
        
        return true;
    }
}