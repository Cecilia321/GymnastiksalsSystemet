using System.Data;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GymnastiksalsSystemet
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Bookings".PadLeft(65));

                Console.WriteLine("\n" + "Her ses en liste over de forskellige grupper og personer i gruppen:" + "\n");
                GruppeCatalog g1 = new GruppeCatalog();
                g1.CreateGruppe("Ulvene", 13-15, 17, 1);
                Console.WriteLine(g1.PrintGruppe());
                PersonList p1 = new PersonList();
                p1.AddPerson(1, "Emma", 13);
                p1.AddPerson(2, "Anna", 13);
                p1.AddPerson(3, "Emil", 13);
                p1.AddPerson(4, "Ole ", 13);
                p1.AddPerson(5, "Karla", 13);
                Console.WriteLine(p1.PrintList());

                Booking b1 = new Booking(2, 1, new DateTime(2024/7/1), new DateTime)
                Console.ReadKey();

                Console.WriteLine("Her ses listen overbadetider: ");
            
        }
    }
}
