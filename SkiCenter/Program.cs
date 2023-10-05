using System;

namespace SkiCenter
{
    internal class Program
    {
 
        public static void Main(string[] args)
        {
            Person person = new Customer();

            try
            {
                Console.Write("Ange Id:");
                person.Id = int.Parse(Console.ReadLine());

                Console.WriteLine("Ange namn:");
                person.Name = Console.ReadLine();

                Console.Write("Ange e-post:");
                person.Email = Console.ReadLine();

                Console.Write("Ange telefonnummer:");
                person.PhoneNumber = Console.ReadLine();

                Console.Write($"Registrerad: {person.Name}, {person.Email}, {person.PhoneNumber}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Ett fel uppstod: {e.Message}");
            }
        }

    }
}