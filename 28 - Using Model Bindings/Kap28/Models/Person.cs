namespace Kap28.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }

        public bool Administrator { get; set; } = false;

        public Address Address { get; set; } = new();
    }
}
