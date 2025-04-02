namespace Ucu.Poo.Restaurant;

using System.Collections;

/// <summary>
/// Representa el conjunto de platillos <see cref="Dish"/> disponibles en el
/// restaurante.
/// </summary>
public class Menu
{
    private ArrayList dishes = new ArrayList();

    public void AddDish(name)
    {
        Console.Write("Ingrese el nombre del platillo: ");
        string name = Console.ReadLine();

        Dish newDish = new Dish(name);
        dishes.Add(newDish);

        Console.WriteLine($"Platillo '{name}' agregado al menú.");
    }

    public void RemoveDish()
    {
        Console.Write("Ingrese el nombre del platillo a eliminar: ");
        string name = Console.ReadLine();

        Dish dishToRemove = GetDishByName(name);

        if (dishToRemove != null)
        {
            dishes.Remove(dishToRemove);
            Console.WriteLine($"Platillo '{name}' eliminado del menú.");
        }
        else
        {
            Console.WriteLine($"No se encontró el platillo '{name}' en el menú.");
        }
    }

    public Dish GetDishByName(string name)
    {
        foreach (var Dish in dishes)
        {
            if (dish.name.Contains(name, StringComparison.OrdinalIgnoreCase))
            {
                return dish;
            }
        }
        return null;
    }
}