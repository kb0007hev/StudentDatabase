// PSEUDOCODE PROBLEM 

//Create 3 arrays and fill them with student information—one with name, one with hometown, one with favorite food

//Prompt the user to ask about a particular student by number. 

//Convert the input to an integer. 

//Use the integer as the index for the arrays. Print the student’s name. (Bard You Forgot to Print Here) 

//Ask the user which category to display: Hometown or Favorite food. Then display the relevant information.

//Ask the user if they would like to learn about another student.


//Build Specifications:
//Validate user number: Use an if statement to check if the number is out of range, i.e. either less than 1 or greater than the length of the arrays. If so, display a friendly message and let the user try again.

//Validate category: Ask the user what information category to display: "Hometown" or "Favorite Food". Use an if statement to check that they entered either category name correctly. If they entered an incorrect category, display a friendly message and re-ask the question. (See hints below!)
//Array Length: Use the first array’s Length property in your code instead of hardcoding it.

//________________________________________________________________________________________________________________________________________________

using System;

class Program
{
    static string[] studentNames = { "Alice", "Bob", "Charlie" };
    static string[] studentHometowns = { "New York", "Los Angeles", "Chicago" };
    static string[] studentFavoriteFoods = { "Pizza", "Sushi", "Burger" };

    static void Main()
    {
        while (true)
        {
            int studentNumber = GetValidStudentNumber();
            string category = GetValidCategory();

            DisplayStudentInformation(studentNumber, category);

            Console.WriteLine("Would you like to learn about another student? (Y/N)");
            string input = Console.ReadLine().ToUpper();
            if (input != "Y")
            {
                break;
            }
        }
    }

    static int GetValidStudentNumber()
    {
        int studentNumber = 0;
        bool isValidInput = false;

        while (!isValidInput)
        {
            Console.WriteLine("Enter student number (1 - 3):");
            string input = Console.ReadLine();

            if (int.TryParse(input, out studentNumber) && studentNumber >= 1 && studentNumber <= studentNames.Length)
            {
                isValidInput = true;
            }
            else
            {
                Console.WriteLine("Please enter a valid student number.");
            }
        }

        return studentNumber - 1;
    }

    static string GetValidCategory()
    {
        string category;

        while (true)
        {
            Console.WriteLine("Which category to display? (Hometown/Favorite Food):");
            category = Console.ReadLine().Trim().ToLower();

            if (category == "hometown" || category == "favorite food")
            {
                break;
            }
            else
            {
                Console.WriteLine("Please enter a valid category.");
            }
        }

        return category;
    }

    static void DisplayStudentInformation(int studentNumber, string category)
    {
        Console.WriteLine($"Student: {studentNames[studentNumber]}");

        if (category == "hometown")
        {
            Console.WriteLine($"Hometown: {studentHometowns[studentNumber]}");
        }
        else if (category == "favorite food")
        {
            Console.WriteLine($"Favorite Food: {studentFavoriteFoods[studentNumber]}");
        }
    }
}