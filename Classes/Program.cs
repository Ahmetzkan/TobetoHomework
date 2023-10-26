using Classes;

CustomerManager customerManager = new CustomerManager();
customerManager.Add();
customerManager.Update();

ProductManager productManager = new ProductManager();
productManager.Add();
productManager.Update();

Customer customer = new Customer();
customer.City = "Ankara";
customer.Id = 1;
customer.FirstName = "Ahmet";
customer.City = "Özkan";

Customer customer2 = new Customer
{
    City = "İstanbul", Id = 2, FirstName = "Engin", LastName = "Demiroğ"
};

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