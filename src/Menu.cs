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

    public void RemoveDish(Dish dish)
    {
        
        if (dish == null)
        {
            
            Console.WriteLine($"No se encontró el platillo '{dish.Name}' en el menú.");
        }
        else
        {        
            dishes.Remove(dish);
            Console.WriteLine($"Platillo '{dish.Name}' eliminado del menú.");
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