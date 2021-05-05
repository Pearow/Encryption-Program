using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Encryption_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
            Console.WriteLine("Kod yürütme tamamlandı");
            Console.ReadKey();
            
        }

        static void Run()
        {
            Encryption a = new Encryption("aa", "Dangerous DONOTUSE");
            Console.WriteLine(a.Encrypt());
            Console.WriteLine(a.Decrypt());
        }
    }
}
