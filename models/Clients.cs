namespace SoftwareEmployeeManagement.models
{
    public class Clients : Person
    {
        public string Email { get; set; }
        public string Phone { get; set; }

        public Clients(string firstName, string lastName, string email, byte age, string phone) : base(firstName, lastName, age)
        {
            Email = email;
            Phone = phone;
        }

        public override void ShowInformation()
        {
            Console.WriteLine($"Client Name: {FirstName} {LastName}\nAge: {Age}\nEmail: {Email}\nPhone: {Phone}");
        }

    }
}