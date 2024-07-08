using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalproject
{
    public class LibraryManager
    {
        private static BindingList<LibraryItem> Items;
        public LibraryManager()
        {
            Items = FileUtiles.LoadLibraryItemFromFile();
        }
        public static void SaveLibraryItems(object sender, FormClosedEventArgs e)
        {
            FileUtiles.SaveLibraryItemToFile(Items);
        }
        static void LoadLibraryItem()
        {
            Items = FileUtiles.LoadLibraryItemFromFile();
        }
        public static BindingList<LibraryItem> GetItems()
        {
            return Items;
        }
        public static void AddItem(LibraryItem item)
        {
            Items.Add(item);
        }
        public static void RemoveItem(LibraryItem item)
        {
            Items.Remove(item);
        }
        public static BindingList<T> GetSpecificItem<T>() where T : LibraryItem
        {
            BindingList<T> specificItem = new BindingList<T>();
            if (Items != null)
            {
                foreach (LibraryItem item in Items)
                {
                    if (item is T)
                        specificItem.Add(item as T);
                }
            }
            return specificItem;
        }
        public static bool SearchByTitle(string title)
        {
            foreach(LibraryItem item in Items)
            {
                if (item._title == title)
                    return true;
            }
            return false;
        }
        public static LibraryItem GetItemByTitle(string title)
        {
            return Items.FirstOrDefault(item => item._title == title);
        }
      
    
        public static void SortByPublicationYear()
        {
            var sortedItems = new BindingList<LibraryItem>(Items.OrderBy(item => item._publicationYear).ToList());
            Items = sortedItems;
        }

       

    }
}
