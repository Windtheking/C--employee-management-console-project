using System.Collections.Generic;

namespace SoftwareEmployeeManagement.models
{
    public class Company
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public List<Employee> EmployeesList { get; set; } = new List<Employee>();
        public List<Clients> ClientsList { get; set; } = new List<Clients>();

        public Company(string name, string address)
        {
            Name = name;
            Address = address;
        }

        // Example helper to add an employee
        public void AddEmployee(Employee employee) => EmployeesList.Add(employee);
        public void AddClient(Clients client) => ClientsList.Add(client);
    }
}