using System.Text.Json;

List<ColorModel> colorModels = new List<ColorModel>();
var serializeOptions = new JsonSerializerOptions
{
    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
};

void ReadColorOnJson()
{
    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "color.json");
    var reader = new StreamReader(filePath);
    var content = reader.ReadToEnd();

    colorModels = JsonSerializer.Deserialize<List<ColorModel>>(content, serializeOptions);
    reader.Close();

    colorModels.ForEach((colorModel) =>
    {
        colorModel.Colors.ForEach((color) =>
        {
            color.Id = Guid.NewGuid();
            System.Console.WriteLine($"Color: {color.Color}");
            System.Console.WriteLine($"Category: {color.Category}");
            System.Console.WriteLine($"Type: {color.Type}");
            System.Console.WriteLine($"Rgba: [");
            color.Code.Rgba.ForEach((rgba) => { System.Console.WriteLine($"{rgba}"); });
            System.Console.WriteLine($"]");
            System.Console.WriteLine($"Hex: {color.Code.Hex}");
            System.Console.WriteLine($"------------------------------");
        });

    });

}

async void WriteColorOnJsonFile()
{
    var fileStream = File.Create(@"new-color.json");
    var streamWriter = new StreamWriter(fileStream, System.Text.Encoding.UTF8);
    var jsonData = JsonSerializer.Serialize(colorModels, serializeOptions);
    await streamWriter.WriteAsync(jsonData);
    await streamWriter.FlushAsync();
    streamWriter.Close();
}

ReadColorOnJson();
WriteColorOnJsonFile();