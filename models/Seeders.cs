using System.Collections.Generic;

namespace SoftwareEmployeeManagement.models
{
    // Seeders: provides in-repo seeded data for development/visualization
    public static class Seeders
    {
        public static Company SeedCompany()
        {
            Company company = new Company("Software company", "123 Main St, Anytown");
            // Seed employees
            company.EmployeesList.Add(new Employee("Alice", "Johnson", "ID-1001", 30, "Developer", 65000));
            company.EmployeesList.Add(new Employee("Bob", "Smith", "ID-1002", 45, "Manager", 85000));
            company.EmployeesList.Add(new Employee("Carol", "Davis", "ID-1003", 28, "QA Engineer", 52000));

            // Seed clients
            company.ClientsList.Add(new Clients("Daniel", "Garcia", "daniel.garcia@example.com", 38, "+1-555-0101"));
            company.ClientsList.Add(new Clients("Emma", "Wilson", "emma.wilson@example.org", 26, "+1-555-0202"));
            company.ClientsList.Add(new Clients("Frank", "Brown", "frank.brown@example.net", 52, "+1-555-0303"));

            return company;
        }
    }
}
