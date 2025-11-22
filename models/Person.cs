namespace SoftwareEmployeeManagement.models
{
    public class Person
    {
       public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }

        public Person(string firstName, string lastName, byte age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public virtual void ShowInformation()
        {
            Console.WriteLine($"Person name: {FirstName} {LastName}\nAge: {Age}");
        }
    }
}