using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov_Alice_Pettersson_Jacks
{
    class Customers
    {

       
        private int money;
        public string name;
        Random generator = new Random();

 
        public void Money() //Slumpar fram kundens pengar
        {

           money = generator.Next(0, 100);

        }
        public void PrintStats()//Skriver ut kundens stats
        {

            Console.WriteLine("This is your customers name: " +name);
            Console.WriteLine("This is "+ name +"s money: " + money);
            


        }
        public void GetName()//Spelaren får skriva in namnet på sin kund
        {


            Console.WriteLine("Skriv in namnet på din kund");

            string input = Console.ReadLine();

            name = input;


        }


    }
}
