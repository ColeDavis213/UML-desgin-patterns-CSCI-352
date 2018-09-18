using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFactory factory = null;
            CarAssembler assembler = new CarAssembler();

            string carType;

            Console.WriteLine("Enter a car type: ");

            carType = Console.ReadLine();   

            if (carType == "toyota" || carType == "Toyota")
            {
                factory = new ToyotaFactory("Corolla", 120);
            }
            else
            {
                factory = new SuzukiFactory("Civic", 160);
            }

            assembler.AssembleCar(factory);
            Console.ReadKey();
        }
    }
}
