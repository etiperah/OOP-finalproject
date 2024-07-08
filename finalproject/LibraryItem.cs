using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalproject
{
    [Serializable]
    public abstract class LibraryItem
    {
        public string _title {get; set;}
        public string _publisher {get; set;}
        public int _publicationYear { get; set;}
        public int _borrowerID {get; set;}
        public bool _isBorrowed { get; set; }

        protected LibraryItem(string title, string publisher, int publicationYear, int _borrowerID, bool _isBorrowed)
        {
            _title = title;
            _publisher = publisher;
            _publicationYear = publicationYear;
            _borrowerID = 0;
            _isBorrowed = false;
        }

        public abstract string addedToGrid();
        
    }

}

