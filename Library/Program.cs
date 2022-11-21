using Library.Authors;
using Library.Collection;
using Library.Factories;
using Library.Halls;
using Library.Types_of_genre;
using Library.Logger;

namespace Library
{
    public class Program
    {
        static void Main(string[] agrs)
        {
            Logging<Literature> logging = new Logging<Literature>();
            PrintLog print = new PrintLog();

            logging.Display += print.ToConsole;

            LinkList<Literature> list = new LinkList<Literature>();

            Book ss = new Book(title: "1",
                                    author: new Dostoevsky("1", "1"),
                                    genre: new Novel("ss"),
                                    publisher: "SPB",
                                    copiesAmount: 130,
                                    pagesAmount: 500);
            Book ww = new Book(title: "2",
                                    author: new Dostoevsky("1", "1"),
                                    genre: new Novel("ss"),
                                    publisher: "SPB",
                                    copiesAmount: 130,
                                    pagesAmount: 500);

            list.Add(ss);
            list.Add(ww);

            list.Contains(ss);

            list.Display();

        }
    }
}
