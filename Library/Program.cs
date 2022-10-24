using Library.Collection;
using Library.Factories;
using Library.Halls;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        static void Main(string[] agrs)
        {
            Hall pushkinTales = new Hall(new PushkinLiteratureFactory());

            Hall dostoevskyNovels = new Hall(new DostoevskyLiteratureFactory());

            Console.WriteLine(dostoevskyNovels.ShowAvailability());
        }
    }
}
