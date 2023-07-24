namespace WffnEmsMaui.Domain;

public class EmployeeCollection
{
    public void Add(Employee employee)
    {
        List.Add(employee);
    }

    public List<Employee> List { get; } = new ();

    public Employee Get(int i)
    {
        return List.ElementAt(i);
    }
}