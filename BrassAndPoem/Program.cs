
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
int choice = 0;

// Loop ensures the code inside the loop executes at least once before a user had a chance to enter a chou=ice
do
{
    Console.WriteLine("\nSelect an option:");
    DisplayMenu();
    try
    {
        choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                DisplayAllProducts(products, productTypes);
                break;
            case 2:
                DeleteProduct(products, productTypes);
                break;
            case 3:
                AddProduct(products, productTypes);
                break;
            case 4:
                break;
            default:
                Console.WriteLine("\nYou have exited the app...");
                break;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
        continue; // Skip to the next iteration if input is invalid
    }
} while (choice != 5);


void DisplayMenu()
{
    Console.WriteLine("1. Display all products");
    Console.WriteLine("2. Delete a product");
    Console.WriteLine("3. Add a new product");
    Console.WriteLine("4. Update product properties");
    Console.WriteLine("5. Exit");
}

void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    int index = 1;
    foreach(Product product in products)
    {
        ProductType productType = productTypes.FirstOrDefault(p => p.Id == product.ProductTypeId);
        Console.WriteLine($@"{index++}. {productType.Title}: {product.Name} - ${product.Price}");
    }
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    Console.WriteLine("\nSelect a product (by number) that you would like to delete:\n");
    DisplayAllProducts(products, productTypes);

    int index = int.Parse(Console.ReadLine());

    Product removedProduct = products[index - 1];

    products.RemoveAt(index - 1);

    Console.WriteLine($"{removedProduct.Name} has been removed");
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    bool validInput = false;
    int selectedProductType = 0;

    while (!validInput)
    {
        // Display the ProductTypes and prompt the user to choose a type for the new product.
        Console.WriteLine("What Product do you want to create? Select from the available Product types below:\n");

        string productTypeTitle = productTypes.Select(p => p.Title).ToString();
        foreach(ProductType productType in productTypes)
        {
            Console.WriteLine($"{productType.Id}. {productType.Title}");
        }

        try
        {
            selectedProductType = int.Parse(Console.ReadLine());
            validInput = true;
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a number from the options below");
        }
    }

    // Prompt the user to enter the name and price of the new product (in this order).
    Console.WriteLine("\nEnter the name of New Product");
    string newProductName = Console.ReadLine();

    Console.WriteLine("\nEnter the price of New Product");
    decimal newProductPrice = decimal.Parse(Console.ReadLine());

    // Create a new instance of the Product class using the provided information.

    Product newProduct = new Product()
    {
        Name = newProductName,
        Price = newProductPrice,
        ProductTypeId = selectedProductType,
    };

    // Add the newly created product to the list of products.
    products.Add(newProduct);

    Console.WriteLine("New Product has been added!\n");

    DisplayAllProducts(products, productTypes);
}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

// don't move or change this!
public partial class Program { }