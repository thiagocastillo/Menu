using System.Collections.Generic;

namespace Ucu.Poo.Restaurant;

/// <summary>
/// Represents a table in the restaurant.
/// </summary>
public class Table
{
    private int number;
    private bool isOccupied;
    private List<Order> orders;

    public int Number
    {
        get { return number; }
        set { number = value; }
    }

    public bool IsOccupied
    {
        get { return isOccupied; }
        set { isOccupied = value; }
    }

    public List<Order> Orders
    {
        get { return orders; }
    }

    public void Occupy()
    {
        isOccupied = true;
    }

    public void Free()
    {
        isOccupied = false;
        orders.Clear();
    }

    public void AddOrder(Order order)
    {
        orders.Add(order);
    }

    public Table(int number)
    {
        this.number = number;
        this.orders = new List<Order>();
    }
}