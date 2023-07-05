namespace PersonTask
{
    public class Person
    {
        private string _name;
        private DateTime _dateOfBirth;

        public string Name => _name;
        public DateTime DateOfBirth => _dateOfBirth;

        public Person()
        {

        }

        public Person(string name, DateTime dateOfBirth)
        {
            _name = name;
            _dateOfBirth = dateOfBirth;
        }

        public int GetAge()
        {
            return DateTime.Now.Year - DateOfBirth.Year;
        }

        public void Input()
        {
            Console.Write("Enter name: ");
            _name = Console.ReadLine();
            bool parsed;
            do
            {
                Console.Write("Enter the date of birth: ");
                var input = Console.ReadLine();

                parsed = DateTime.TryParse(input, out _dateOfBirth);
                if (!parsed)
                {
                    Console.WriteLine("Can't parse entered date");
                }
            } while (!parsed);
        }

        public void Print()
        {
            Console.WriteLine(ToString());
        }

        public void ChangeName(string newName)
        {
            _name = newName;
        }

        public override string ToString()
        {
            return $"Name: {Name}; Age: {GetAge()}";
        }

        public static bool operator ==(Person a, Person b)
        {
            return a.Name == b.Name;
        }

        public static bool operator !=(Person a, Person b)
        {
            return a.Name != b.Name;
        }
    }
}
