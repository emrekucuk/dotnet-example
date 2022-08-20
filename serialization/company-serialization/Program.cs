using System.Text.Json;

CompanyModel companyModel = new CompanyModel();

var serializeOptions = new JsonSerializerOptions
{
    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
};

void ReadCompanyJson()
{
    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "company.json");
    var reader = new StreamReader(filePath);
    var content = reader.ReadToEnd();

    companyModel = JsonSerializer.Deserialize<CompanyModel>(content, serializeOptions);
    reader.Close();


    System.Console.WriteLine($"{companyModel.Id}");
    System.Console.WriteLine($"{companyModel.Name}");
    companyModel.Cofounders.ForEach((coFounder) =>
    {
        System.Console.WriteLine($"CoFounder Id: {coFounder.Id}");
        System.Console.WriteLine($"CoFounder Name: {coFounder.Name}");
    });
    companyModel.Employees.ForEach((employee) =>
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

async void WriteCompanyOnJsonFile()
{
    var filePath = File.Create("new-company.json");
    var streamWriter = new StreamWriter(filePath, System.Text.Encoding.UTF8);
    var jsonData = JsonSerializer.Serialize(companyModel, serializeOptions);
    await streamWriter.WriteAsync(jsonData);
    await streamWriter.FlushAsync();
    streamWriter.Close();
}

ReadCompanyJson();

System.Console.WriteLine($"\n*******************************");
System.Console.WriteLine($"Read Finished and Write Started");
System.Console.WriteLine($"*******************************\n");

WriteCompanyOnJsonFile();
