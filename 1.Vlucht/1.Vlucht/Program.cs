using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Vlucht
{
    class Program
    {
       static void Main(string[] args)
       {

            Vlucht vlucht0 = new Vlucht(Vlucht.Bestemmingen.Duitsland, DateTime.Now, DateTime.Now.AddHours(5)); // 3
           Vlucht vlucht1 = new Vlucht(Vlucht.Bestemmingen.Duitsland, DateTime.Now, DateTime.Now.AddHours(5)); // 3
           Vlucht vlucht2 = new Vlucht(Vlucht.Bestemmingen.Duitsland, DateTime.Now, DateTime.Now.AddHours(5)); //3

            //Vlucht vlucht2 = new Vlucht(8);
            Console.WriteLine(vlucht0);
           // Console.WriteLine(vlucht1);
           // Console.WriteLine(vlucht2);
            //Console.WriteLine(vlucht2);
        }
    }
}
