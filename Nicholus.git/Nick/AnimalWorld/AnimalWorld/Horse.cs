using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AnimalWorld.AnimalTypes;

namespace AnimalWorld
{
    public class Horse : FarmAnimal, ICare
    {
        private TypeOfHorse m_HorseType;

        public TypeOfHorse HorseType
        {
            get
            {
                return m_HorseType;
            }

            set
            {
                m_HorseType = value;
            }
        }

        public string Deworm()
        {
            return this.Farmer + " dozes " + this.AnimalName;
        }

        public string Groom()
        {
            return this.Farmer + " brushes " + this.AnimalName;
        }
    }
}