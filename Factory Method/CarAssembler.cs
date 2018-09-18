using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    class CarAssembler
    {
        public void AssembleCar(CarFactory factory)
        {
            Car car = factory.GetCar();

            Console.WriteLine("Company: {0} \n Model: {1} \n Speed: {2}", car.Company, car.Model, car.Speed);
        }
    }
}
