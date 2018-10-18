using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextCar
{
    class Engine
    {
        private int voltage;
        private Boolean stateOn = false;

        public Engine(int voltage)
        {
            this.voltage = voltage;
        }

        public void turnOn()
        {
            this.stateOn = true;
        }

        public void turnOff()
        {
            this.stateOn = false;
        }


        public Boolean isOn()
        {
            return this.stateOn;
        }
    }
}
