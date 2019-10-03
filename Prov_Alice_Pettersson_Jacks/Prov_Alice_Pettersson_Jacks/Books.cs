using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov_Alice_Pettersson_Jacks
{
    class Books
    {
        public int price;
        private string name;
        private int rarity;
       // private string category;
        private int actualValue;
      //  private bool cursed;
        Random generator = new Random();


        public void Book()// Slumpar fram bokens rarity och value
        {

            actualValue = generator.Next(0, 200);
            rarity = generator.Next(1, 10);

            
        }
        public void PrintInfo()//Skriver ut bokens rarity och value
        {

            Console.WriteLine("The vaule of the book was: "+actualValue);
            Console.WriteLine("The rarity of the book was: " + rarity);

        }
        public int Evaluate() //rarity och actual multipliceras och delas sedan på en siffra mellan 50 och 150.
        {

            price = rarity * actualValue;
            int randomProcent = generator.Next(50, 150);
            price = price / randomProcent;
            Console.WriteLine(price);

            return price;

        }
        public void GetName()//Spelaren får skriva in vad boken ska heta och namnet ändras till det
        {


            Console.WriteLine("Vad ska boken heta?");

            string input = Console.ReadLine();

            name = input;

            Console.WriteLine(name);


        }




        

/*GetCategory returnerar helt enkelt värdet av category, och GetName returnerar name.
IsCursed returnerar antingen true eller false. Det är 80% chans att den returnerar samma värde som är i variabeln cursed (dvs rätt svar),
det är 20% chans att den returnerar det motsatta värdet(dvs fel svar)*/


    }
}
