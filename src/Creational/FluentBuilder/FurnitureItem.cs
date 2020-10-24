namespace FluentBuilder
{
    public class FurnitureItem
    {
        public FurnitureItem(string name, decimal price, double width, double height, double weight)
        {
            this.Name = name;
            this.Price = price;
            this.Width = width;
            this.Height = height;
            this.Weight = weight;
        }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public double Width { get; set; }

        public double Height { get; set; }

        public double Weight { get; set; }
    }
}