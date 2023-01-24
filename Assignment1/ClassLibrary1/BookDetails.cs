namespace ClassLibrary1
{

    /// <remarks>
    /// Represents details of books such as book id, title, price and booktype.
    /// </remarks>
    public struct BookDetails
    {
        public int bookId;
        public string title;
        public int price;
        public BookType type;

        // get and set accessors for every field in the class
        public int BookId
        {
            get { return this.bookId; }
            set { this.bookId = value; }
        }

        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }

        public int Price
        {
            get { return this.price; }
            set{ this.price = value; }
        }

        public BookType Type
        {
            get { return this.type; }
            set{ this.type = value; }
        }
    }


    /// <remarks>
    /// Represents the type of book.
    /// </remarks>
    public enum BookType
    {
        Magazine = 1, 
        Novel,
        ReferenceBook, 
        Miscellaneous
    }
    
}