using System.Collections;

namespace Ucu.Poo.Restaurant;

/// <summary>
/// Representa un mozo en el restaurante, encargado de atender mesas.
/// </summary>
public class Waiter
{
    private ArrayList assignedTables; //= new ArrayList();

    private string nameWaiter;
    private Table table;
    private Dish dish;
    
    public Waiter(string nameWaiter)
    {
        this.nameWaiter = nameWaiter;
        assignedTables = new ArrayList();
    }
    
    public string NameWaiter
    {
        get { return nameWaiter; }
        set { nameWaiter = value; }
    }
    
    public ArrayList AssignedTables
    {
        get { return assignedTables; }
        set { assignedTables = value; }
    }
    
    public void AssignTable(Table table)
    {
        if (!assignedTables.Contains(table))
        {
            assignedTables.Add(table);
        }
    }
    
    public void TakeOrder(Table table, Dish dish)
    {
        if (assignedTables.Contains(table))
        {
            table.AddToOrder(dish);
            Console.WriteLine("Mesas asignadas al mozo con exito.");
        }
        else
        {
            throw new Exception("El mozo no tiene asignada la mesa.");
        }
    }
}