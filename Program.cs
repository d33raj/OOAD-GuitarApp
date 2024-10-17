using OOADGuitarApp.Enums;

namespace OOADGuitarApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            InitializeInventory(inventory);


            //GuitarSpec whatErinLikes = new GuitarSpec(Builder.FENDER, "Stratocaster", Types.ELECTRIC, Wood.ALDER, Wood.ALDER);
            GuitarSpec whatErinLikes = new GuitarSpec(Builder.MARTIN, "D-18", Types.ELECTRIC, Wood.MAHOGANY, Wood.ADIRONDACK);

            List<Guitar> matchingGuitars = inventory.Search(whatErinLikes);
            if (matchingGuitars.Count > 0)
            {
                Console.WriteLine("Erin, you might like these guitars:");
                foreach (Guitar guitar in matchingGuitars)
                {
                    GuitarSpec spec = guitar.Spec;
                    Console.WriteLine($"We have a {spec.Builder} {spec.Model} {spec.Type} guitar:\n" +
                                      $"   {spec.BackWood} back and sides,\n" +
                                      $"   {spec.TopWood} top.\n" +
                                      $"You can have it for only ${guitar.Price}!\n--------------------------------------");
                }
            }
            else
            {
                Console.WriteLine("Sorry, Erin, we have nothing for you.");
            }
        }

        private static void InitializeInventory(Inventory inventory)
        {
            inventory.AddGuitar("11277", 3999.95, Builder.COLLINGS, "CJ", Types.ACOUSTIC, Wood.INDIAN_ROSEWOOD, Wood.SITKA);
            inventory.AddGuitar("V95693", 1499.95, Builder.FENDER, "Stratocaster", Types.ELECTRIC, Wood.ALDER, Wood.ALDER);
            inventory.AddGuitar("V9512", 1549.95, Builder.FENDER, "Stratocaster", Types.ELECTRIC, Wood.ALDER, Wood.ALDER);
            inventory.AddGuitar("122784", 5495.95, Builder.MARTIN, "D-18", Types.ACOUSTIC, Wood.MAHOGANY, Wood.ADIRONDACK);
            inventory.AddGuitar("76531", 6295.95, Builder.MARTIN, "OM-28", Types.ACOUSTIC, Wood.BRAZILIAN_ROSEWOOD, Wood.ADIRONDACK);
            inventory.AddGuitar("70108276", 2295.95, Builder.GIBSON, "Les Paul", Types.ELECTRIC, Wood.MAHOGANY, Wood.MAPLE);
            inventory.AddGuitar("82765501", 1890.95, Builder.GIBSON, "SG '61 Reissue", Types.ELECTRIC, Wood.MAHOGANY, Wood.MAHOGANY);
        }
    }
}
