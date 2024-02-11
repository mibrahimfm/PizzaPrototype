namespace PizzaPrototype
{
    internal class Pizza : ICloneable
    {
        public string Name { get; set; }
        public string Crust { get; set; }
        public string Dough { get; set; }
        public List<string> Cheeses { get; set; }
        public string Sauce { get; set; }
        public List<string> Toppings { get; set; }
        public int Slices { get; set; }

        public Pizza(string name, string crust, string dough, List<string> cheeses, string sauce, List<string> toppings, int slices)
        {
            Name = name;
            Crust = crust;
            Dough = dough;
            Cheeses = cheeses;
            Sauce = sauce;
            Toppings = toppings;
            Slices = slices;
        }

        public Pizza()
        {
            Name = "";
            Crust = "";
            Dough = "";
            Cheeses = new List<string>();
            Sauce = "";
            Toppings = new List<string>();
            Slices = 0;
        }

        //Clone with the ICloneable interface: logic goes to the clone method
        public object Clone()
        {
            return new Pizza(new string(Name), new string(Crust), new string(Dough), new (Cheeses), new string(Sauce), new (Toppings), Slices);
        }

        //Clone by hand: use the memberwiseClone method. Copy by reference.
        public Pizza ShallowCopy()
        {
            return (Pizza) MemberwiseClone();
        }

        //Clone by hand: implement logic to make sure it's a new object
        public Pizza DeepCopy()
        {
            return new Pizza(new string(Name), new string(Crust), new string(Dough), new(Cheeses), new string(Sauce), new(Toppings), Slices);
        }

        public override string ToString()
        {
            string result = $"{Name}, with {Slices} slices, a {Crust},";
            foreach (string cheese in Cheeses)
                result += " " + cheese;
            result += ", and topped by";
            foreach(string top in Toppings)
                result += " " + top;

            return result;
        }
    }
}
