namespace Kap28.Models
{
    public class Family
    {

        public Person[] Persons { get; set; } = new Person[]
        {
            new Person{Age = 58, Id = 1, Name = "Ras1"},
            new Person{Age = 55, Id = 2, Name = "Ras2"},
            new Person{Age = 50, Id = 3, Name = "Ras3"},
            new Person{Age = 45, Id = 4, Name = "Ras4"},
            new Person{Age = 40, Id = 5, Name = "Ras5"},
            new Person{Age = 35, Id = 6, Name = "Ras6"},
            new Person{Age = 30, Id = 7, Name = "Ras7"}
        };
    }
}
