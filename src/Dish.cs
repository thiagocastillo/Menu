namespace Ucu.Poo.Restaurant;

/// <summary>
/// Representa un platillo individual en el menú del restaurante.
/// </summary>
public class Dish
{
    public string Name;
    public double Price;
    public bool IsVegetarian;

    public Dish(string name, double price, bool isVegetarian)
    {
        this.Name = name;
        this.Price = price;
        this.IsVegetarian = isVegetarian;
    }
}