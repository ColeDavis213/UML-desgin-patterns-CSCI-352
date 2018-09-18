using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    class ToyotaFactory : CarFactory
    {
        public ToyotaFactory(string model, int speed)
        {
            this.model = model;
            this.speed = speed;
        }

        public override Car GetCar()
        {
            return new Toyota(model, speed);
        }

        private string model;
        private int speed;
    }
}
