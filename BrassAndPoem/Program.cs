
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.
List<Product> products = new List<Product>()
{
    new Product()
    {
        Name = "Trumpet",
        Price = 89.99M,
        ProductTypeId = 1,
    },
    new Product()
    {
        Name = "Trombone",
        Price = 75.99M,
        ProductTypeId = 1,
    },
    new Product()
    {
        Name = "Tuba",
        Price = 154.99M,
        ProductTypeId = 1,
    },
    new Product()
    {
        Name = "The Waste Land by T.S. Eliot",
        Price = 39.99M,
        ProductTypeId = 2,
    },
    new Product()
    {
        Name = "Song of Myself by Walt Whitman",
        Price = 49.99M,
        ProductTypeId = 2,
    },
    new Product()
    {
        Name = "Milk and Honey by Rupi Kaur",
        Price = 55.99M,
        ProductTypeId = 2,
    },
};

//create a "productTypes" variable here with a List of ProductTypes, and add "Brass" and "Poem" types to the List. 
List<ProductType> productTypes = new List<ProductType>()
{
    new ProductType()
    {
        Title = "Brass",
        Id = 1,
    },
    new ProductType()
    {
        Title = "Poem",
        Id = 2,
    },
};

//put your greeting
string greeting = "Welcome to Brass, Poem and Things!";
Console.WriteLine(greeting);

//implement your loop here
Console.WriteLine($@"Choose an option:
    1. Option 1
    2. Option 2
    3. Option 3
    4. Option 4
    5. Exit");

int choice = int.Parse(Console.ReadLine());
while (choice != 5)
{
    Console.WriteLine("Exiting the program..");
}

void DisplayMenu()
{
    throw new NotImplementedException();
}

void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

// don't move or change this!
public partial class Program { }