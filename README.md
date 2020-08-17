# 200817 C# Review Practice

## Set Up
- Create a new .NET console app called Practice
- Change the default output message in the Program Main method to "20 08 17 Practice"

## Assignment
- Define a base class `RestaurantEmployee`
- Define a class `Server` and a class `Cook` that extend the `RestaurantEmployee` class

- Restaurant Employee Properties
    - name
    - shifts per week
- Restaurant Employee Methods
    - Output an employee's name and shifts per week
    - Update an employee's shifts per week 
- Server Properties
    - name
    - shifts per week
    - tables serving : dictionary of tables with a table identification number key and a table's number of guest and whether or not a table has children as a strut for the value
- Server Methods 
    - Output a server's name, shifts per week, and number of tables serving
    - Output all tables a serving is serving
    - Update the tables a serving is serving : delete and add tables
- Cook Properties
    - name
    - shifts per week
    - known recipes : list of recipe structs with properties name, time to make, and whether or not it requires meat
- Cook Methods
    - Output a cook's name, shifts per week, and number of know recipes
    - Add a recipe 
    - Output all known recipes
    - Output all known recipes that take less than 15 minutes to prepare from a list of recipes using LINQ
    - Output the details of a specific recipe found by name

- Define two `Cook` objects and two `Server` objects in the Program main method
- Use each method
