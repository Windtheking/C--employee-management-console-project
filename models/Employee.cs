using System.Data.Common;

namespace SoftwareEmployeeManagement.models
{
    public class Employee : Person
    {
        public Guid Id { get; set; }
        public string IdentificationNumber { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }

        public Employee(string firstName, string lastName, string identificationNumber, byte age, string position, double salary) : base(firstName, lastName, age)
        {
            Id = Guid.NewGuid();
            IdentificationNumber = identificationNumber;
            Position = position;
            Salary = salary;
        }

        private double CalculateBonus(double x)
        {
            double Bonus = x * 0.10;
            return Bonus + x;
        }

        public override void ShowInformation()
        {
            Console.WriteLine($"Employee ID: {Id}\nName: {FirstName} {LastName}\nAge: {Age}\nIdentification Number: {IdentificationNumber}\nPosition: {Position}\nSalary: {Salary}\nSalary with Bonus: {CalculateBonus(Salary)}");

        }
    }          
};


