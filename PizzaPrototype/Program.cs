// See https://aka.ms/new-console-template for more information
using PizzaPrototype;

Pizza p = PizzaRegistry.GetPizzaByNameAndSize("Margherita", PizzaSize.Large);
p.Cheeses.Add("Parmesan");

Pizza p2 = PizzaRegistry.GetPizzaByNameAndSize("Margherita", PizzaSize.Large);

Pizza p3 = PizzaRegistry.GetPizzaByNameAndSizeReference("Margherita", PizzaSize.Large);
p3.Cheeses.Add("Parmesan");

Pizza p4 = PizzaRegistry.GetPizzaByNameAndSizeReference("Margherita", PizzaSize.Large);

Console.WriteLine(p.ToString());
Console.WriteLine(p2.ToString());
Console.WriteLine(p3.ToString());
Console.WriteLine(p4.ToString());