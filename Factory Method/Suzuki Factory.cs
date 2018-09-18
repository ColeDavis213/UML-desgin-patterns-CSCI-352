using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    class SuzukiFactory : CarFactory
    {
        public SuzukiFactory(string model, int speed)
        {
            test = model;
            test2 = speed;
        }

        public override Car GetCar()
        {
            return new Suzuki(test, test2);
        }

        private string test;
        private int test2;
    }
}
