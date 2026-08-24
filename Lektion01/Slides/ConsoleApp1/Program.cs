namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
       Student student = new();

       student.Name = "Arthur Michorowski";
       student.Age = (34);
       Console.WriteLine($"Navn {student.Name}  ");
    }
}