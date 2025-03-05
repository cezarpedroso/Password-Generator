using System;
using System.Text;

class PasswordGenerator
{
    static void Main()
    {
     // Characters for password
        string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()=+;:[]{}.,><";
     // Ask user for input
        Console.Write("Enter the length of the password: ");
 
        int Length = Convert.ToInt32(Console.ReadLine());
     // Generate password
        string password = GeneratePassword(Length, characters);
     // Output password
        Console.WriteLine($"Generated Password: {password}");
    }

    static string GeneratePassword(int length, string characters)
    {
        Random random = new Random();
        StringBuilder password = new StringBuilder();

     // Loop to generte the password according to user input
        for (int i = 0; i < length; i++)
        {
            int index = random.Next(characters.Length);
            password.Append(characters[index]);
        }

        return password.ToString();
    }
}
