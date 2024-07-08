using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalproject
{
    [Serializable]
    public class Biography:Book
    {
        public string _subject { get; set; }

        public Biography (string title, string publisher, int publicationYear, int borrowerID, bool isBorrowed,
            string author, string genre, int numOfPages, string subject) : base(title, publisher,
                publicationYear, borrowerID, isBorrowed, author, genre, numOfPages)
        {
            _subject = subject;
        }
        public override string addedToGrid()
        {
            return "a new Biography book added to the library";
        }


    }

    
}
