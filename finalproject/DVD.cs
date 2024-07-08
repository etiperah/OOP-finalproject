using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalproject
{
    [Serializable]
    public class DVD: LibraryItem
    {
        public string _director;
        public int _durationInMin;

        public DVD(string title, string publisher, int publicationYear, int borrowerID, bool isBorrowed,
        string director, int durationInMin) : base(title, publisher, publicationYear, borrowerID, isBorrowed)
        {
            _director = director;
            _durationInMin = durationInMin;
        }
        public override string addedToGrid()
        {
            return "a new DVD added to the library";
        }
    }

    
}
