using System;
namespace CS_CollectionList
{
    public class Product : IComparable<Product>, IFormattable
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Origin { get; set; }

        public Product(int id, string name, double price, string origin)
        {
            ID = id;
            Name = name;
            Price = price;
            Origin = origin;
        }

        public int CompareTo(Product other)
        {
            double delta = this.Price - other.Price;

            if (delta > 0)
                return -1;
            else if (delta < 0)
                return 1;
            return 0;
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (format == null) format = "O";
            switch (format.ToUpper())
            {
                case "O":
                    return $"Origin: {Origin} - Name: {Name} - Price: {Price} - ID: {ID}";
                case "N":
                    return $"Origin: {Origin} - Name: {Name} - Price: {Price} - ID: {ID}";
                default:
                    throw new FormatException("Not support this format!");
            }
        }

        public override string ToString() => $"{Name} - {Price}";

        public string ToString(string format) => this.ToString(format, null);
    }
}