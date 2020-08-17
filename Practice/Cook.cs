using System;
using System.Collections.Generic;
using System.Linq;
class Cook : RestaurantEmployee
{
    protected List<Recipe> knownRecipes = new List<Recipe>(); 
    public Cook(string name, int shiftsPerWeek) : base(name, shiftsPerWeek)
    {
        // inhereted from base
    }    
    public new void OutputProps()
    {
        Console.WriteLine($"Employee Name : {this.name}\nEmployee Shifts Per Week : {this.shiftsPerWeek}\nKnown Recipes : {this.knownRecipes.Count}");
    }
    public void AddRecipe()
    {
            Console.Write("Recipe Name : ");
            string recipeName = Console.ReadLine();

            Console.Write("Recipe Prep Time : ");
            int recipePrepTime = Int16.Parse(Console.ReadLine());

            Console.Write("Recipe Has Meat : ");
            string userMeatChoice = Console.ReadLine();
            bool recipeMeat = false;
            if(userMeatChoice == "YES")
            {
                recipeMeat = true;
            }

            Recipe newRecipe;
            newRecipe.name = recipeName;
            newRecipe.prepTime = recipePrepTime;
            newRecipe.requiresMeat = recipeMeat;

            this.knownRecipes.Add(newRecipe);
    }
    public void OutputRecipes()
    {
        foreach(Recipe recipe in this.knownRecipes)
        {
            Console.WriteLine($"Name : {recipe.name}\nPrep Time : {recipe.prepTime} minutes\nRequires Meat : {recipe.requiresMeat}");
        }
    }
    public void FilterRecipes()
    {
        List<Recipe> filtered = this.knownRecipes.Where(recipe => recipe.prepTime < 15).ToList();
        foreach(Recipe recipe in filtered)
        {
            Console.WriteLine($"Name : {recipe.name}\nPrep Time : {recipe.prepTime} minutes\nRequires Meat : {recipe.requiresMeat}");
        }
    }
    public void RecipeDetail()
    {
        Console.Write("Enter the recipe to find : ");
        string userRecipe = Console.ReadLine();
        List<Recipe> filtered = this.knownRecipes.Where(recipe => recipe.name == userRecipe).ToList();
        Console.WriteLine($"Name : {filtered[0].name}\nPrep Time : {filtered[0].prepTime} minutes\nRequires Meat : {filtered[0].requiresMeat}");
    }
}
struct Recipe
{
    public string name;
    public int prepTime;
    public bool requiresMeat; 
}