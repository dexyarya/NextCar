using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextCar
{
    class EngineController
    {
         private Engine engine;

        public EngineController()
        {
            this.engine = new Engine(12);
        }

        public Boolean engineIsOn()
        {
            return this.engine.isOn();
        }

        public void turnOn()
        {
            this.engine.turnOn();
        }
        public void turnOf()
        {
            this.engine.turnOff();
        }
    }
}
