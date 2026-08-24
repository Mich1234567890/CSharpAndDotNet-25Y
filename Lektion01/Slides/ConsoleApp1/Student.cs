namespace ConsoleApp1;

public class Student
{
    private string name;

    public string Name { get; set; } = string.Empty;

    public int Age
    {
        get;
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}