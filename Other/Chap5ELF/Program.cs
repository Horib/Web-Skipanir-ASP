
using System.Net;

namespace Chap5ELF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var family = new[]
            {
                new { Firstname = "Rasmus", Lastname = "Hansen", Age = 30, Address = (string?)"Æðuvík" },
                new { Firstname = "Rasmus", Lastname = "Hansen", Age = 30, Address = (string?)null },
            };

            foreach (var item in family)
            {
            Console.WriteLine($"{item.Firstname} {item.Lastname}");
            }


        }
    }
}