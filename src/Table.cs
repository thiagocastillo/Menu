namespace Ucu.Poo.Restaurant;

using System.Collections;

/// <summary>
/// Representa una mesa en el restaurante.
/// </summary>
public class Table
{
    private int number;
    private bool isOccupied;
    private ArrayList order = new ArrayList();

    public int Number
    {
        get { return number; }
        set { number = value; }
    }
    public ArrayList Order
    {
        get { return order; }
    }
    public bool IsOccupied
    {
        get { return isOccupied; }
        set { isOccupied = value; }
    }
    public void Occupy()
    {
        isOccupied = true;
    }
    public void Free()
    {
        isOccupied = false;
        order.Clear();
    }

    public void AddToOrder(Dish dish)
    {
        order.Add(dish);
    }
    public bool HasOrders()
    {
        return this.order.Count > 0;
    }
    public Table(int number)
    {
        this.Number = number;
        
    }
}