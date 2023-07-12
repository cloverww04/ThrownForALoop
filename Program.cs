List<Product> products = new()
{
    new Product() {
        Name = "Football",
        Price = 15.00m,
        Sold = false,
        StockDate = new DateTime(2023, 7, 11),
        ManufactureYear = 2019,
        Condition = 4.2
    },
    new Product() {
        Name = "Hockey Stick",
        Price = 12.50m,
        Sold = false,
        StockDate = new DateTime(2023, 7, 11),
        ManufactureYear = 2019,
        Condition = 1.2
    },
    new Product() {
        Name = "Baseball Bat",
        Price = 18.63m,
        Sold = false,
        StockDate = new DateTime(2023, 7, 11),
        ManufactureYear = 2019,
        Condition = 6.7
    },
    new Product() {
        Name = "7 Iron",
        Price = 180.99m,
        Sold = true,
        StockDate = new DateTime(2023, 7, 11),
        ManufactureYear = 2019,
        Condition = 9.8
    },
    new Product() {
        Name = "Basketball",
        Price = 5.15m,
        Sold = false,
        StockDate = new DateTime(2023, 7, 11),
        ManufactureYear = 2019,
        Condition = 5.6
    }
};

string greeting = @"Welcome to Thrown For a Loop
Your one-stop shop for used sporting equipment";

decimal totalValue = 0.0m;
foreach(Product product in products) {
    if(!product.Sold){
        totalValue += product.Price;
    }
}

Console.WriteLine(greeting);
Console.WriteLine($"Total inventory value: ${totalValue}");
Console.WriteLine("Products:");

for (int i = 0; i < products.Count; i++) {
    Console.WriteLine($"{i + 1}. {products[i].Name}");
}
Console.WriteLine("Please enter a product number: ");

int response = int.Parse(Console.ReadLine()!.Trim());

while (response > products.Count || response < 1){
    Console.WriteLine("You didn't choose anything, try again!");
    response = int.Parse(Console.ReadLine()!.Trim());
}

Product chosenProduct = products[response - 1];
DateTime now = DateTime.Now;
TimeSpan timeInStock = now - chosenProduct.StockDate;
Console.WriteLine(@$"You chose: 
{chosenProduct.Name}, which costs ${chosenProduct.Price}.
It is {now.Year - chosenProduct.ManufactureYear} years old. 
It {(chosenProduct.Sold ? "is not available." : $"has been in stock for {timeInStock.Days} days.")}
Condition: {chosenProduct.Condition}");

