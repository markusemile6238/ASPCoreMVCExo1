using static System.Runtime.InteropServices.JavaScript.JSType;

namespace VillaAgency.Models.Properties
{
    public class Propertie
    {
        public Guid ID { get; set; }
        public required PropertieType Type { get; set; }
        public required double Price { get; set;}
        public required string Adresse { get; set; } = string.Empty;
        public required int Bedrooms { get; set; }
        public required int Bathrooms { get; set; }
        public required int Area {  get; set; }
        public required int Floor {  get; set; }
        public required int Parking {  get; set; }
        public required string Description { get; set; } = string.Empty;
        public required string ImageUrl { get; set; }

    }
}
