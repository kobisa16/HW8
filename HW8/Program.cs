using System.Net.Security;
using static System.Formats.Asn1.AsnWriter;

namespace HW8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store s = new Store();
            Console.WriteLine(s);

            s.AddItem(new Item(6, "milkey", 6, "Milky is popular in Israel"));
            s.AddItem(new Item(5, "cottage", 7, "Basic dairy product"));
            Console.WriteLine(s);
            s.DeleteKnightFromDb(9);
            Console.WriteLine(s);

        }
    }
}
