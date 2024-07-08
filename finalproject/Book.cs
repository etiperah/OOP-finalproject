using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalproject
{
    [Serializable]
    public abstract class Book: LibraryItem 
    {
        public string _author { get; set; }
        public string _genre { get; set; }
        public int _numOfPages { get; set; }

        public Book(string title, string publisher, int publicationYear, int _borrowerID, bool _isBorrowed,
            string author, string genre, int numOfPages)
            : base(title, publisher, publicationYear, _borrowerID, _isBorrowed)
        {
            _author = author;
            _genre = genre;
            _numOfPages = numOfPages;
        }
    }
}
