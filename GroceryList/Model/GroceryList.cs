using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroceryList
{
    public class GroceryList
    {
        public string Name { get; set; }
        public List<Item> groceryList { get; set; }

        public List<Item> GetGroceryList() //dal
        {
            return null;
        }

        public void addItem(Item newItem)
        {
           groceryList.Add(newItem);

        }

        public void addItem(string name, int quantity)
        {
            Item newItem = new Item();
            newItem.Name = name;
            newItem.Quantity = quantity;

            groceryList.Add(newItem); 
             
        }

        public void removeItem(Item removedItem)
        {
            groceryList.Remove(removedItem); 
        }

        public void removeItem(string name, int quanity)
        {
            groceryList.Remove(new Item { Name = name, Quantity = quanity }); 
        }
    }
}