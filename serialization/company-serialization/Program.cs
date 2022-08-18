

using System.Text.Json;

CompanyModel companyModels = new CompanyModel();

var serializeOptions = new JsonSerializerOptions
{
    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
};

void ReadCompanyJson()
{
    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "company.json");
    var reader = new StreamReader(filePath);
    var content = reader.ReadToEnd();

    var company = JsonSerializer.Deserialize<CompanyModel>(content, serializeOptions);
    reader.Close();


    System.Console.WriteLine($"{company.Id}");
    System.Console.WriteLine($"{company.Name}");
    company.Cofounders.ForEach((coFounder) =>
    {
        System.Console.WriteLine($"CoFounder Id: {coFounder.Id}");
        System.Console.WriteLine($"CoFounder Name: {coFounder.Name}");
    });
    company.Employees.ForEach((employee) =>
    {
        System.Console.WriteLine($"Employee Id: {employee.Id}");
        System.Console.WriteLine($"Employee Full Name: {employee.FullName}");
        System.Console.WriteLine($"Employee Anual Salary: {employee.AnualSalary}");
        System.Console.WriteLine($"Employee Position Id: {employee.Position.Id}");
        System.Console.WriteLine($"Employee Position Name: {employee.Position.Description}");

        employee.Benefits.ForEach((benefit) =>
        {
            System.Console.WriteLine($"Benefit Id: {benefit.Id}");
            System.Console.WriteLine($"Benefit Additional {benefit.Additional}");
            System.Console.WriteLine($"Benefit Description: {benefit.Description}");

        });
    });
}

ReadCompanyJson();