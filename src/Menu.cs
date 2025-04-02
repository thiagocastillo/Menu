namespace Ucu.Poo.Restaurant;

using System.Collections;

/// <summary>
/// Representa el conjunto de platillos <see cref="Dish"/> disponibles en el
/// restaurante.
/// </summary>
public class Menu
{
    private ArrayList dishes = new ArrayList();

    public void AddDish(Dish dish)
    {
      
        dishes.Add(dish);

        Console.WriteLine($"Platillo '{dish.Name}' agregado al menú.");
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
        foreach (Dish dish in dishes)
        {
            if (dish.Name.Contains(name, StringComparison.OrdinalIgnoreCase))
            {
                return dish;
            }
        }
        return null;
    }
}