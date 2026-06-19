using System;

// Базовий клас
class Product
{
    protected string name;
    protected double price;

    // Статичне поле для підрахунку продуктів
    public static int ProductCount = 0;

    public Product(string name, double price)
    {
        this.name = name;
        this.price = price;
        ProductCount++;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Назва: {name}");
        Console.WriteLine($"Ціна: {price} грн");
        Console.WriteLine($"Кількість створених продуктів: {ProductCount}");
    }
}

// Електронний товар
class ElectronicProduct : Product
{
    private int warrantyPeriod;

    public ElectronicProduct(string name, double price, int warrantyPeriod)
        : base(name, price)
    {
        this.warrantyPeriod = warrantyPeriod;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("=== Електронний товар ===");
        Console.WriteLine($"Назва: {name}");
        Console.WriteLine($"Ціна: {price} грн");
        Console.WriteLine($"Гарантія: {warrantyPeriod} міс.");
        Console.WriteLine($"Кількість створених продуктів: {ProductCount}");
        Console.WriteLine();
    }
}

// Одяг
class ClothingProduct : Product
{
    private string size;

    public ClothingProduct(string name, double price, string size)
        : base(name, price)
    {
        this.size = size;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("=== Одяг ===");
        Console.WriteLine($"Назва: {name}");
        Console.WriteLine($"Ціна: {price} грн");
        Console.WriteLine($"Розмір: {size}");
        Console.WriteLine($"Кількість створених продуктів: {ProductCount}");
        Console.WriteLine();
    }
}

// Головна програма
class Program
{
    static void Main()
    {
        ElectronicProduct laptop = new ElectronicProduct(
            "Ноутбук", 35000, 24);

        ClothingProduct tshirt = new ClothingProduct(
            "Футболка", 800, "L");

        ElectronicProduct phone = new ElectronicProduct(
            "Смартфон", 25000, 12);

        laptop.DisplayInfo();
        tshirt.DisplayInfo();
        phone.DisplayInfo();

        Console.WriteLine($"Загальна кількість продуктів: {Product.ProductCount}");
    }
}
