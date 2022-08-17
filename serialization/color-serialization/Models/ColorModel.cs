public class ColorModel
{
    public List<ColorsModel> Colors { get; set; }
    public class ColorsModel
    {
        public Guid Id { get; set; }
        public string Color { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public Code Code { get; set; }
    }
    public class Code
    {
        public List<int> Rgba { get; set; }
        public string Hex { get; set; }
    }

}