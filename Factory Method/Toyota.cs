using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    class Toyota : Car
    {
        private readonly string company;
        private string model;
        private int speed;

        public Toyota(string model, int speed)
        {
            company = "Toyota";
            this.model = model;
            this.speed = speed;
        }

        public override string Company
        {
            get { return company; }
        }
        public override string Model
        {
            get { return model; }
            set { model = value; }
        }
        public override int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
    }
}
