using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleExeption
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Zippy", 20);
            myCar.CrankTunes(true);
            try
            {
                for (int i = 0; i < 10; i++)
                    myCar.Accelerate(10);
            }
            catch(Exception e)
            {
                Console.WriteLine("ERROR:");
                Console.WriteLine($"Method: {e.TargetSite}");

                Console.WriteLine($"Class defining member: {e.TargetSite.DeclaringType}");
                Console.WriteLine($"Member type: {e.TargetSite.MemberType}");
                Console.WriteLine($"Stack: {e.StackTrace}");
                Console.WriteLine($"Help link: {e.HelpLink}");
                //Console.WriteLine($"Time: {e.Data}");
                Console.WriteLine("Custom Data:");
                foreach (DictionaryEntry item in e.Data)
                {
                    Console.WriteLine($"{item.Key} : {item.Value}");
                }

                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Source: {e.Source}");
            }
            Console.WriteLine("\nOut of exeption logic.");
            Console.WriteLine();
        }
    }
}
