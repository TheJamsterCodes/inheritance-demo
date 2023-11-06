namespace InheritanceDemo;

public class SoftwareEngineer : Employee
{
    public string ManagerName { get; set; }
    public string Team { get; set; }

    public SoftwareEngineer(string firstname, string lastname)
    {
        this.Firstname = firstname;
        this.Lastname = lastname;
        this.IsActive = true;  
        this.SetEmployeeId();   
    }
}