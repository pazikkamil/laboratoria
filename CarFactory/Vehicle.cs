using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory
{
    abstract class Vehicle : IDrive
    {
        public abstract void Drive();
    }
}
