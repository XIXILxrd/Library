using Library.Authors;
using Library.Collection;
using Library.Factories;
using Library.Halls;
using Library.Types_of_genre;
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
            Hall dostoevskyHall = new Hall(new DostoevskyLiteratureFactory());

            LinkList<Literature> literatures = dostoevskyHall.ShowAvailability();

            literatures.Display();

            Console.WriteLine("----------------------------------------");

            literatures = literatures.Sort();

            literatures.Display();

        }
    }
}
