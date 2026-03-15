using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary3;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Strings Obj = new Strings();

            Strings Obj2 = new Strings(new string[]{ "Hello", "World!", "I", "am", "a", "programmer" });

            Strings Obj3 = new Strings(Obj2);

            Obj2.Name = "Test name";
            
            Console.WriteLine(Obj2.Name);

            Console.WriteLine($"Obj(1)  amount of strings {Obj.Count}");

            Console.WriteLine($"Obj 2 amount of strings {Obj2.Count}");

            Console.WriteLine($"Obj 3 amount of strings {Obj3.Count}");

            for(int i = 0; i < Obj.Count; ++i )
            {
                Console.WriteLine(Obj[i]);
            }

            for (int i = 0; i < Obj2.Count; ++i)
            {
                Console.WriteLine(Obj2[i]);
            }

            for (int i = 0; i < Obj3.Count; ++i)
            {
                Console.WriteLine(Obj3[i]);
            }
        }
    }    
}
