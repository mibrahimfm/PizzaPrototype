namespace PizzaPrototype
{
    internal class PizzaRegistry
    {
        public static List<Pizza> PizzaPrototypes = new()
        {
            new("Margherita", "Traditional crust", "Wheat dough", new() { "Mozzarella" }, "Tomato sauce", new() { "Tomato", "Basil" }, 8),
            new("Margherita", "Traditional crust", "Wheat dough", new() { "Mozzarella" }, "Tomato sauce", new() { "Tomato", "Basil" }, 6),
            new("Pepperonni", "Stuffed cheese crust", "Wheat dough", new() { "Mozzarella", "Parmesan" }, "Tomato sauce", new() { "Tomato", "Pepperonni", "Oregano" }, 8),
            new("Pepperonni", "Stuffed cheese crust", "Wheat dough", new() { "Mozzarella", "Parmesan" }, "Tomato sauce", new() { "Tomato", "Pepperonni", "Oregano" }, 6)
        };

        public static void AddPizzaPrototype(Pizza pizza)
        {
            PizzaPrototypes.Add(pizza);
        }

        public static Pizza GetPizzaByNameAndSize(string name, PizzaSize size)
        {
            return (Pizza) PizzaPrototypes.First(p => p.Name.Equals(name) && p.Slices == (int)size).Clone();
        }

        public static Pizza GetPizzaByNameAndSizeReference(string name, PizzaSize size)
        {
            return PizzaPrototypes.First(p => p.Name.Equals(name) && p.Slices == (int)size).ShallowCopy();
        }
    }
}
