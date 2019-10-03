using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov_Alice_Pettersson_Jacks
{
    class Program
    {
        static void Main(string[] args)
        {


            Customers print2 = new Customers(); //Här skapas det så att man kan ankalla metoder från de 2 olika klasserna

            Books print = new Books();

            print.GetName();// Här under ankallas ett par metoder från de två tidigare skapade klasser

            print.Book();

            print.PrintInfo();

            Console.WriteLine("Så här mycket tror du att den kostar:");

            print.Evaluate();

            print2.GetName();

            print2.Money();
            print2.PrintStats();


            Console.ReadLine();

        }
    }
}
