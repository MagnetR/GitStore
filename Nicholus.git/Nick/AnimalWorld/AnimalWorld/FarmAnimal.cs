using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalWorld
{
    public class FarmAnimal : Animal
    {
        private string m_Farmer;

        public string Farmer
        {
            get
            {
                return m_Farmer;
            }

            set
            {
                m_Farmer = value;
            }
        }

        public override string Eat()
        {
            return this.AnimalName + " grazes in the meadow";
        }

        public override string Move()
        {
            return this.AnimalName + " walks across the farm";
        }
    }
}