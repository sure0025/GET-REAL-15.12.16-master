using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Getting_Real;
using System.Collections.Generic;

namespace Getting_Real_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddSupplierToDatabase()
        {
            DatabaseAccess databaseAccess = new DatabaseAccess();
            databaseAccess.ClearSupplierAndZipTables();

            Supplier newSupplier = new Supplier()
            {
                SupplierName = "Steve",
                SupplierCompany = "Samsung",
                Email = "samsung@gmail.com",
                PhoneNumber = "123456789",
                Address = "Seebladsgade 1",
                City = "Odense",
                Country = "Denmark",
                Zip = 65478
            };

            if (databaseAccess.DoesZipExist(newSupplier.Zip) == false)
            {
                databaseAccess.AddNewZipNumberToTable(newSupplier.Zip);
            }

            databaseAccess.AddNewSupplierToTable(newSupplier);
            List<Supplier> listOfSuppliers = databaseAccess.GetListOfSuppliers();
            Assert.IsTrue(listOfSuppliers.Count == 1);

            bool doesSupplierExist = false;

            foreach (Supplier supplier in listOfSuppliers)
            {
                if (
                    supplier.SupplierName == newSupplier.SupplierName 
                    && supplier.SupplierCompany == newSupplier.SupplierCompany
                    && supplier.Email == newSupplier.Email
                    && supplier.PhoneNumber == newSupplier.PhoneNumber
                    && supplier.Address == newSupplier.Address
                    && supplier.City == newSupplier.City
                    && supplier.Country == newSupplier.Country
                    && supplier.Zip == newSupplier.Zip)
                {
                    doesSupplierExist = true;
                }
            }
            Assert.IsTrue(doesSupplierExist);
        }


        [TestMethod]
        public void AddCategoryToDatabase()
        {
            DatabaseAccess databaseAccess = new DatabaseAccess();
            Category newCategory = new Category()
            {
                CategoryName = "TestCategory"
            };

            databaseAccess.ClearProductTable();
            databaseAccess.ClearCategoryTable();
            databaseAccess.AddNewCategoryToTable(newCategory);
            List<Category> listOfCategories = databaseAccess.GetListOfCategories();

            bool doesCategoryExist = false;

            foreach (Category category in listOfCategories)
            {
                if (category.CategoryName == newCategory.CategoryName)
                {
                    doesCategoryExist = true;
                }
            }
            Assert.IsTrue(doesCategoryExist);
        }

        [TestMethod]

        public void AddProductWithoutSupplierToDatabase()
        {
            DatabaseAccess databaseAccess = new DatabaseAccess();
            databaseAccess.ClearProductTable();
            databaseAccess.ClearCategoryTable();

            Category newCategory = new Category()
            {
                CategoryName = "TestCategory"
            };

            databaseAccess.AddNewCategoryToTable(newCategory);
            List<Category> listOfCategories = databaseAccess.GetListOfCategories();

            Category loadedCategory = listOfCategories[0];
          

            Product newProduct = new Product("productName", loadedCategory, 10, "productDescription", 25); 

            databaseAccess.AddNewProductToTable(newProduct);
            List<Product> listOfProducts;
            listOfProducts = databaseAccess.GetListOfProducts();

            bool doesProductExist = false;

            foreach (Product product in listOfProducts)
            {
                if
                    (
                    newProduct.ProductName == product.ProductName
                    && newProduct.category.CategoryID == product.category.CategoryID
                    && newProduct.ProductAmount == product.ProductAmount
                    && newProduct.ProductDescription == product.ProductDescription
                    && newProduct.ProductPrice == product.ProductPrice
              
                    )
                {
                    doesProductExist = true;
                }
            }
            Assert.IsTrue(doesProductExist);
        }
    }
}
