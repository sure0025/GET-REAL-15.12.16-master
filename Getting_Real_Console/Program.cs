using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Getting_Real;

namespace Getting_Real_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program gettingReal = new Program();
            //gettingReal.DisplayConsoleOptions();
            //Console.ReadKey();


            Store store = new Store();
            store.AddCategoryToDatabase();
            Console.ReadKey();


        }

        public void Run()
        {

            


        }



        //public void DisplayConsoleOptions()
        //{
        //    // Home Screen

        //    Console.Clear();
        //    Console.SetCursorPosition(0, 0);
        //    Console.WriteLine("1. Add new product");
        //    Console.WriteLine("2. Add supplier");
        //    Console.WriteLine("3. Show all products");
        //    Console.WriteLine("4. Show all suppliers");
        //    Console.WriteLine("5. Find product");
        //    Console.WriteLine("6. Register sales");
        //    Console.WriteLine("7. Show summary");
        //    Console.WriteLine("8 Delete Product by ID");
        //    char input = Console.ReadKey().KeyChar;

        //    switch (input)
        //    {
        //        case '1':
        //            AddProductOption();
        //            break;

        //        case '2':
        //            AddSupplierOption();
        //            break;

        //        case '3':
        //            Console.Clear();
        //            Console.SetCursorPosition(0, 0);
        //            Console.WriteLine("Not implemented");
        //            break;

        //        case '4':
        //            Console.Clear();
        //            Console.SetCursorPosition(0, 0);
        //            Console.WriteLine("Not implemented");
        //            break;

        //        case '5':
        //            Console.Clear();
        //            Console.SetCursorPosition(0, 0);
        //            Console.WriteLine("Not implemented");
        //            break;

        //        case '6':
        //            Console.Clear();
        //            Console.SetCursorPosition(0, 0);
        //            Console.WriteLine("Not implemented");
        //            break;

        //        case '7':
        //            Console.Clear();
        //            Console.SetCursorPosition(0, 0);
        //            Console.WriteLine("Not implemented");
        //            break;

        //        case '8':
        //            DeleteProductOption();
        //            break;

        //        default:
        //            Console.Clear();
        //            Console.SetCursorPosition(0, 0);
        //            Console.WriteLine("Wrong input!");
        //            break;
        //    }
        //}

        //public void AddProductOption()
        //{
        //    DatabaseAccess databaseAccess = new DatabaseAccess();

        //    Console.Clear();
        //    Console.SetCursorPosition(0, 0);
        //    Console.WriteLine("-Enter product details-");

        //    Console.Write("ID: ");
        //    int productID = int.Parse(Console.ReadLine());

        //    Console.Write("Name: ");
        //    string productName = Console.ReadLine();

        //    Console.Write("Category ID: ");
        //    int categoryID = int.Parse(Console.ReadLine());

        //    Console.Write("Product type: ");
        //    string productType = Console.ReadLine();

        //    Console.Write("Amount: ");
        //    int productAmount = int.Parse(Console.ReadLine());

        //    Console.Write("Description: ");
        //    string productDescription = Console.ReadLine();

        //    Console.Write("Price: KR");
        //    decimal productPrice = decimal.Parse(Console.ReadLine());

        //    Console.Write("Supplier ID:");
        //    int supplierID = int.Parse(Console.ReadLine());

        //    Product NewProduct = new Product
        //    {
        //        ProductID = productID,
        //        ProductName = productName,
        //        CategoryID = categoryID,
        //        ProductType = productType,
        //        ProductAmount = productAmount,
        //        ProductDescription = productDescription,
        //        ProductPrice = productPrice,
        //        SupplierID = supplierID
        //    };

        //    databaseAccess.AddNewProduct(NewProduct);

        //    Console.Clear();
        //    Console.SetCursorPosition(0, 0);
        //    Console.WriteLine("Product \"{0}\" added successfully!", productName);
        //    Console.ReadKey();
        //}

        //public void AddSupplierOption()
        //{
        //    DatabaseAccess databaseAcess = new DatabaseAccess();

        //    Console.Clear();
        //    Console.SetCursorPosition(0, 0);
        //    Console.WriteLine("-Enter supplier details-");

        //    Console.Write("ID: ");
        //    int supplierID = int.Parse(Console.ReadLine());

        //    Console.Write("Supplier name: ");
        //    string supplierName = Console.ReadLine();

        //    Console.Write("Company name: ");
        //    string companyName = Console.ReadLine();

        //    Console.Write("E-Mail: ");
        //    string email = Console.ReadLine();

        //    Console.Write("Phone number: ");
        //    string phoneNumber = Console.ReadLine();

        //    Console.Write("Country: ");
        //    string country = Console.ReadLine();

        //    Console.Write("City: ");
        //    string city = Console.ReadLine();

        //    Console.Write("Adress: ");
        //    string adress = Console.ReadLine();

        //    Console.Write("Zip: ");
        //    int zip = int.Parse(Console.ReadLine());

        //    Console.Write("ZipID: ");
        //    int zipID = int.Parse(Console.ReadLine());

        //    Supplier NewSupplier = new Supplier()
        //    {
        //        SupplierID = supplierID,
        //        SupplierName = supplierName,
        //        SupplierCompany = companyName,
        //        Email = email,
        //        PhoneNumber = phoneNumber,
        //        Country = country,
        //        City = city,
        //        Address = adress,
        //        Zip = zip,
        //    };

        //    databaseAcess.AddNewSupplierToTable(NewSupplier);

        //    Console.Clear();
        //    Console.SetCursorPosition(0, 0);
        //    Console.WriteLine("Supplier \"{0}\" added successfully!", supplierName);
        //    Console.ReadKey();
        //}

        //public void DeleteProductOption()
        //{
        //    DatabaseAccess databaseAccess = new DatabaseAccess();

        //    Console.Clear();
        //    Console.WriteLine("Enter ID to find product and Delete it: ");
        //    int ID = int.Parse(Console.ReadLine());

        //    if (databaseAccess.DoesProductExist(ID) == true)

        //    {
        //        databaseAccess.DeleteProduct(ID);
        //    }

        //    Console.Clear();
        //    Console.WriteLine("You have successfully deleted the product from the database! ");
        //    Console.ReadKey();

        //}


    }
}
