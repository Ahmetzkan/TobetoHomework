CustomerManager customerManager = new CustomerManager();
customerManager.Add();
customerManager.Update();

ProductManager productManager = new ProductManager();
productManager.Add();
productManager.Update();



class CustomerManager
{
    public void Add()
    {
        Console.WriteLine("Customer Added!");
    }

    public void Update()
    {
        Console.WriteLine("Customer Updated!");
    }
}


class ProductManager
{
    public void Add()
    {
        Console.WriteLine("Customer Added!");
    }

    public void Update()
    {
        Console.WriteLine("Customer Updated!");
    }
}