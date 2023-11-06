using System.Collections;

namespace InheritanceDemo;

// NonNegativeList sub-class extends ArrayList class.
// The class' implementation exludes negative numbers.
public class NonNegativeList : ArrayList
{
    // Default constructor without parameters
    public NonNegativeList() { }

    // Parameterized constructor
    public NonNegativeList(params int[] numbers)
    {
       // Invoking the instance's AddRange method to filter and add to the collection  
       this.AddRange(numbers);
    }

    // Add a non-negative number to the list.
    public void Add(int number)
    {
        // If non-negative, then add
        if (number >= 0)
        {
            // Invoke base class to add non-negative number
            base.Add(number);
        }
    }

    public void AddRange(ICollection<int> collection)
    {
        var nonNegativeNumbers = collection.Where(n => n >= 0).ToArray();
        // The base keyword accesses the AddRange method of the base class to add to the collection
        base.AddRange(nonNegativeNumbers);
    }
}