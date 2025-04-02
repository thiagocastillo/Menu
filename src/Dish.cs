namespace Ucu.Poo.Restaurant;

/// <summary>
/// Representa un platillo individual en el menú del restaurante.
/// </summary>
public class Dish
{
    public string Name;
    public double Price;
    public bool IsVegetarian;

    public Dish()
    {
        Name = "Napolitana";
        Price = 499.99;
        IsVegetarian = false;
    }
}