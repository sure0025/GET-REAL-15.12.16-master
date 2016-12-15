using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getting_Real
{
    public class Store
    {

        public void AddCategoryToDatabase()
        {
            DatabaseAccess databaseAccess = new DatabaseAccess();
            Category newCategory = new Category()
            {
                CategoryName = "TestCategory"
            };

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
            
        }


    }

    

}

