public class CompanyModel
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public List<CoFounder> Cofounders { get; set; }
    public List<Employee> Employees { get; set; }

    public class CoFounder
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }

    public class Employee
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public int AnualSalary { get; set; }
        public Position Position { get; set; }
        public List<Benefit> Benefits { get; set; }
    }

    public class Position
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
    }

    public class Benefit
    {
        public Guid Id { get; set; }
        public int Additional { get; set; }
        public string Description { get; set; }
    }
}