namespace PersonTask;

class Progam
{
    static void Main(string[] args)
    {
        var personList = new List<Person>();

        for (int i = 1; i <= 6; i++)
        {
            var person = new Person();

            Console.WriteLine($"Enter data for person {i}:");
            person.Input();

            personList.Add(person);
            Console.WriteLine();
        }

        foreach (Person person in personList)
        {
            person.Print();
        }
        Console.WriteLine();
        const int veryYoungAge = 16;

        foreach (Person person in personList.Where(p => p.GetAge() < veryYoungAge))
        {
            person.ChangeName("Very young");
        }

        Console.WriteLine();

        foreach (Person person in personList)
        {
            person.Print();
        }

        Console.WriteLine();

        var groups = personList.GroupBy(p => p.Name)
                               .Where(g => g.Count() > 1);

        foreach (var group in groups)
        {
            Console.WriteLine($"Data for {group.Key} persons group");

            foreach (Person person in group)
            {
                person.Print();
            }
        }
    }
}