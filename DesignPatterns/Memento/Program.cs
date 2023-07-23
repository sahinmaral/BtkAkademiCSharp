namespace Memento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book()
            {
                ISBNNo = "12345",
                Title = "Sefiller",
                Author = "Victor Hugo"
            };

            book.ShowBook();

            CareTaker history = new CareTaker();
            history.Memento = book.CreateUndo();

            book.ISBNNo = "54321";
            book.Title = "Sefillerr";

            book.ShowBook();

            book.RestoreFromUndo(history.Memento);
            book.ShowBook();

            Console.ReadLine();
        }
    }

    class Book
    {
        private string _title;
        private string _author;
        private string _iSBNNo;
        private DateTime _lastEdited;

        public string Title { get => _title; set 
            { 
                _title = value;
                SetLastEdited(); 
            } 
        }
        public string Author { get => _author; set 
            { 
                _author = value;
                SetLastEdited(); 
            } 
        }
        public string ISBNNo { get => _iSBNNo; set 
            { 
                _iSBNNo = value;
                SetLastEdited(); 
            } 
        }

        private void SetLastEdited()
        {
            _lastEdited = DateTime.UtcNow;
        }

        public Memento CreateUndo()
        {
            return new Memento(title : _title,author : _author, iSBNNo : _iSBNNo, lastEdited : _lastEdited);
        }

        public void RestoreFromUndo(Memento memento)
        {
            _title = memento.Title;
            _iSBNNo = memento.ISBNNo;
            _author = memento.Author;
            _lastEdited = memento.LastEdited ;
        }

        public void ShowBook()
        {
            Console.WriteLine("{0},{1},{2} edited : {3}", _iSBNNo,_title,_author,_lastEdited);
        }
    }

    class Memento
    {
        public Memento(string title, string author, string iSBNNo, DateTime lastEdited)
        {
            Title = title;
            Author = author;
            ISBNNo = iSBNNo;
            LastEdited = lastEdited;
        }

        public string Title { get; set; }
        public string Author {get;set;}
        public string ISBNNo {get;set;}
        public DateTime LastEdited {get;set;}
    }

    class CareTaker
    {
        public Memento Memento { get; set; }
    }
}