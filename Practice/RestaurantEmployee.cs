using System;
class RestaurantEmployee
{
    protected string name;
    protected int shiftsPerWeek;
    public RestaurantEmployee(string name, int shiftsPerWeek)
    {
        this.name = name;
        this.shiftsPerWeek = shiftsPerWeek;
    }
    public void OutputProps()
    {
        Console.WriteLine($"Employee Name : {this.name}\nEmployee Shifts Per Week : {this.shiftsPerWeek}");
    }
    public void UpdateShifts()
    {
        Console.Write($"The employee's current shifts per week is {this.shiftsPerWeek}. What would you like to update the value to?");

        this.shiftsPerWeek = Int32.Parse(Console.ReadLine());

        Console.WriteLine($"Updated : {this.shiftsPerWeek}");
    }
}