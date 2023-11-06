namespace InheritanceDemo;

public class Employee
{
    public string EmployeeId { get; private set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public bool IsActive { get; set; }
    public int TenureLength { get; set; }

    // Default constructor
    public Employee() {}

    // Instance, parameterized constructor
    public Employee(string firstname, string lastname)
    {
        this.Firstname = firstname;
        this.Lastname = lastname;
        this.IsActive = true;            
    }  

    public override string ToString()
    {
        return $"{this.EmployeeId}: {this.Lastname}, {this.Firstname}";
    }

    protected void SetEmployeeId()
    {
        this.EmployeeId = $"{this.Lastname[..3]}{this.Firstname[..3]}-{Random.Shared.Next(1, 100)}";
    }      
}
