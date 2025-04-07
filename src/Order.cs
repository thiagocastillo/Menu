namespace Ucu.Poo.Restaurant;
using System.Collections;

public class Order
{
    private ArrayList order = new ArrayList();
    private Table table;

    public bool Take_Away { get; set; }

    public ArrayList Ticket
    {
        get { return order; }
    }

    public Table Table
    {
        get { return table; }
        set { table = value; }
    }

    public void Clear()
    {
        order.Clear();
    }

    public void AddToOrder(Dish dish)
    {
        order.Add(dish);
    }

    public void AssignToTable(Table table)
    {
        this.table = table;
    }

    public bool HasOrders()
    {
        return this.order.Count > 0;
    }

    public double GetTotal()
    {
        double total = 0;
        foreach (Dish dish in order)
        {
            total += dish.Price;
        }
        return total;
    }

    public Order(bool takeAway)
    {
        this.Take_Away = takeAway;
    }
}