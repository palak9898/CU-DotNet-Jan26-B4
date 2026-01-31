// See https://aka.ms/new-console-template for more information
using System;

class Day15_2
{
    public static void Main(string[] args)
    {
        Order order1 = new Order(12960, "Palak");
        order1.AddItem(500);
        order1.AddItem(300);
        order1.ApplyDiscount(10);
        order1.GetOrderSummary();

        Order order2 = new Order(12390, "Yash");
        order2.AddItem(1000);
        order2.GetOrderSummary();
    }
}

class Order
{
    // INSTANCE FIELDS 
    private int orderId;
    private string customerName;
    private int totalAmount;
    private DateOnly orderDate;
    private string orderStatus;
    private bool isDiscountApplied;

    //INSTANCE PROPERTIES
    public int OrderId
    {
        get
        {
            return orderId;
        }
    }

    public string CustomerName
    {
        get { return customerName; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                customerName = value;
            }
        }
    }

    public int TotalAmount => totalAmount; // read-only

    //CONSTRUCTORS
    public Order()
    {
        orderDate = DateOnly.FromDateTime(DateTime.Now);
        orderStatus = "NEW";
        totalAmount = 0;
        isDiscountApplied = false;
    }

    public Order(int orderId, string customerName) : this()
    {
        this.orderId = orderId;
        this.CustomerName = customerName;
    }

    // INSTANCE METHODS
    public void AddItem(int price)
    {
        if (price > 0)
        {
            totalAmount += price;
        }
    }

    public void ApplyDiscount(int percentage)
    {
        if (!isDiscountApplied && percentage >= 1 && percentage <= 30)
        {
            totalAmount -= (percentage * totalAmount) / 100;
            isDiscountApplied = true;
        }
    }

    public void GetOrderSummary()
    {
        Console.WriteLine(
            $"Order Id: {OrderId}\n" +
            $"Customer: {CustomerName}\n" +
            $"Total Amount: {TotalAmount}\n" +
            $"Status: {orderStatus}"
        );
    }
}
