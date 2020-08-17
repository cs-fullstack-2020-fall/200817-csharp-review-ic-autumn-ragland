using System;
using System.Collections.Generic;
using System.Linq;
class Server : RestaurantEmployee
{
    Dictionary<int, TableProps> tablesServing = new Dictionary<int, TableProps>();
    public Server(string name, int shiftsPerWeek) : base(name, shiftsPerWeek)
    {
        // inhereted from base class
    }
    public new void OutputProps()
    {
        Console.WriteLine($"Employee Name : {this.name}\nEmployee Shifts Per Week : {this.shiftsPerWeek}\nTables Serving : {this.tablesServing.Count}");
    }
    public void OutputTables()
    {
        Console.WriteLine($"Tables Serving");
        foreach(KeyValuePair<int, TableProps> table in tablesServing)
        {
            Console.WriteLine($"Table Number : {table.Key}\nNumber of Guests : {table.Value.numberOfGuests}\nHas Children :{table.Value.hasChildren}");
        }
    }
    public void UpdateTables()
    {
        Console.Write("If you want to add tables enter ADD if you want to delete tables enter DELETE : ");
        string userChoice = Console.ReadLine();
        if(userChoice == "ADD")
        {
            Console.Write("Enter a table identification number : ");
            int tableID = Int16.Parse(Console.ReadLine());
            Console.Write("Enter the table number of guest : ");
            int tableGuests = Int16.Parse(Console.ReadLine());
            Console.Write("Does the table have children? : ");
            string userChoiceChildren = Console.ReadLine();
            bool tableChildren = false;
            if(userChoiceChildren == "YES")
            {
                tableChildren = true;
            }
            TableProps tableStruct;
            tableStruct.numberOfGuests = tableGuests;
            tableStruct.hasChildren = tableChildren;
            this.tablesServing.Add(tableID, tableStruct);
        } else if (userChoice == "DELETE")
        {
            Console.Write("Enter the table identification number of the table you want to delete : ");
            int tableDeleteID = Int32.Parse(Console.ReadLine());
            this.tablesServing.Remove(tableDeleteID);
        } else 
        {
            Console.WriteLine("You did not enter ADD or DELETE");
        }
    }

    struct TableProps
    {
        public int numberOfGuests;
        public bool hasChildren;
    }

}