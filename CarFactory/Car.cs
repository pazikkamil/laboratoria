using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory
{
    class Car : Vehicle
    {
        private readonly string model;
        private readonly string brand;
        public string Brand{get => brand; }

        Car(string marka, string model)
        {
            this.brand = marka;
            this.model = model;
        }

        static double mpg2lpkm(double mpg)
        {
            // TODO: to define
            return 0;
        }

        public override void Drive()
        {
            // TODO: how to drive ?
            ;
        }
    }
}
            