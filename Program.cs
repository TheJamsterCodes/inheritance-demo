using InheritanceDemo;

var numbers = new NonNegativeList(-10, 2, 3, 10);

numbers.Add(-2);
numbers.Add(1);
numbers.AddRange(new []{ -4, -10, 19});

foreach (int number in numbers)
{
    Console.WriteLine(number);
}

var sweEmployee = new SoftwareEngineer("John", "Doe");
string empId = sweEmployee.ToString();
Console.WriteLine(empId);
Console.WriteLine(sweEmployee.EmployeeId);