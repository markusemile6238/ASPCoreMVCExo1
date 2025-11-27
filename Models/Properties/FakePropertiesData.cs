namespace VillaAgency.Models.Properties
{
    public class FakePropertiesData
    {
        public static List<Propertie> GetSampleProperties()
        {
            return new List<Propertie>
            {
                // Appartements
                new Propertie
                {
                    ID = Guid.NewGuid(),
                    Type = PropertieType.Apartment,
                    Price = 250000,
                    Adresse = "123 Rue de la République, 75001 Paris",
                    Bedrooms = 2,
                    Bathrooms = 1,
                    Area = 65,
                    Floor = 3,
                    Parking = 0,
                    Description = "Bel appartement lumineux en cœur de Paris, proche de tous les commerces.",
                    ImageUrl = "~/images/property-01.jpg"
                },
                new Propertie
                {
                    ID = Guid.NewGuid(),
                    Type = PropertieType.Apartment,
                    Price = 180000,
                    Adresse = "45 Avenue des Champs-Élysées, 75008 Paris",
                    Bedrooms = 1,
                    Bathrooms = 1,
                    Area = 45,
                    Floor = 5,
                    Parking = 0,
                    Description = "Studio refait à neuf avec vue dégagée, idéal pour investisseur.",
                    ImageUrl = "~/images/property-02.jpg"
                },

                // Villas/Maisons
                new Propertie
                {
                    ID = Guid.NewGuid(),
                    Type = PropertieType.Villa_House,
                    Price = 750000,
                    Adresse = "78 Chemin des Oliviers, 06130 Grasse",
                    Bedrooms = 4,
                    Bathrooms = 3,
                    Area = 180,
                    Floor = 1,
                    Parking = 2,
                    Description = "Magnifique villa provençale avec piscine et jardin arboré.",
                    ImageUrl = "~/images/property-03.jpg"
                },
                new Propertie
                {
                    ID = Guid.NewGuid(),
                    Type = PropertieType.Villa_House,
                    Price = 620000,
                    Adresse = "12 Impasse des Lavandes, 83400 Hyères",
                    Bedrooms = 3,
                    Bathrooms = 2,
                    Area = 150,
                    Floor = 1,
                    Parking = 1,
                    Description = "Charmante maison de village rénovée avec terrasse et vue sur mer.",
                    ImageUrl = "~/images/property-04.jpg"
                },

                // Penthouses
                new Propertie
                {
                    ID = Guid.NewGuid(),
                    Type = PropertieType.Penthouse,
                    Price = 1200000,
                    Adresse = "Tour Crystal, 25ème étage, 69001 Lyon",
                    Bedrooms = 3,
                    Bathrooms = 2,
                    Area = 120,
                    Floor = 25,
                    Parking = 2,
                    Description = "Exceptionnel penthouse avec terrasse panoramique à 360°, vue imprenable sur Lyon.",
                    ImageUrl = "~/images/property-05.jpg"
                },
                new Propertie
                {
                    ID = Guid.NewGuid(),
                    Type = PropertieType.Penthouse,
                    Price = 950000,
                    Adresse = "Résidence Le Panorama, 15ème étage, 13008 Marseille",
                    Bedrooms = 2,
                    Bathrooms = 2,
                    Area = 95,
                    Floor = 15,
                    Parking = 1,
                    Description = "Sublime penthouse avec grande terrasse et vue mer, standing haut de gamme.",
                    ImageUrl = "~/images/property-06.jpg"
                },

                // Villas de luxe (réutilisation d'images avec des rotations logiques)
                new Propertie
                {
                    ID = Guid.NewGuid(),
                    Type = PropertieType.Luxury_Villa,
                    Price = 2500000,
                    Adresse = "Domaine de Saint-Tropez, 83990 Saint-Tropez",
                    Bedrooms = 6,
                    Bathrooms = 5,
                    Area = 350,
                    Floor = 2,
                    Parking = 4,
                    Description = "Villa d'exception avec piscine à débordement, spa et vue mer. Prestige absolu.",
                    ImageUrl = "~/images/property-01.jpg"
                },
                new Propertie
                {
                    ID = Guid.NewGuid(),
                    Type = PropertieType.Luxury_Villa,
                    Price = 3200000,
                    Adresse = "Cap d'Antibes, Chemin de la Garoupe, 06160 Antibes",
                    Bedrooms = 5,
                    Bathrooms = 4,
                    Area = 400,
                    Floor = 2,
                    Parking = 3,
                    Description = "Villa contemporaine de grand standing avec accès privé à la mer et jardin paysager.",
                    ImageUrl = "~/images/property-02.jpg"
                },

                // Condos modernes
                new Propertie
                {
                    ID = Guid.NewGuid(),
                    Type = PropertieType.Modern_Condo,
                    Price = 420000,
                    Adresse = "Le Carré d'Or, 34000 Montpellier",
                    Bedrooms = 2,
                    Bathrooms = 2,
                    Area = 75,
                    Floor = 8,
                    Parking = 1,
                    Description = "Nouveau condo avec équipements haut de gamme, piscine et gym résidentiels.",
                    ImageUrl = "~/images/property-03.jpg"
                },
                new Propertie
                {
                    ID = Guid.NewGuid(),
                    Type = PropertieType.Modern_Condo,
                    Price = 380000,
                    Adresse = "Eco-Residence Green Life, 33000 Bordeaux",
                    Bedrooms = 3,
                    Bathrooms = 2,
                    Area = 85,
                    Floor = 12,
                    Parking = 1,
                    Description = "Condo écologique dernière génération avec terrasse et vue sur la ville.",
                    ImageUrl = "~/images/property-04.jpg"
                }
            };
        }
    }
}

