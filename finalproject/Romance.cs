using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalproject
{
    [Serializable]
    public class Romance : Book
    {
        public string _couple { get; set; }
        public bool _happyEnding { get; set; }

        public Romance(string title, string publisher, int publicationYear, int _borrowerID, bool _isBorrowed,
            string author, string genre, int numOfPages, string couple, bool happyEnding)
            : base( title,  publisher, publicationYear,  _borrowerID,  _isBorrowed,
             author,  genre,  numOfPages)
        {
            _couple = couple;
            _happyEnding = happyEnding;
        }
        public override string addedToGrid()
        {
            return "a new Romance book added to the library";
        }
    }

  
}
