using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace finalproject
{
    public static class FileUtiles
    {
        public static void SaveLibraryItemToFile(BindingList<LibraryItem> Items)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileInfo fi = new FileInfo("Items.bin");
            using (var binaryFile = fi.Create())
            {
                binaryFormatter.Serialize(binaryFile, Items);
                binaryFile.Flush();
            }
        }

        public static BindingList<LibraryItem> LoadLibraryItemFromFile()
        {
            BindingList<LibraryItem> Items;
            try
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileInfo fi = new System.IO.FileInfo("Items.bin");
                using (var binaryFile = fi.OpenRead())
                {
                    Items = (BindingList<LibraryItem>)binaryFormatter.Deserialize(binaryFile);
                }
            }
            catch(Exception ex)
                {
                Items = new BindingList<LibraryItem>();
            }
            return Items;
        }
    }

}

