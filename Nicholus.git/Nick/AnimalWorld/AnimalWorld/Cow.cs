using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AnimalWorld.AnimalTypes;

namespace AnimalWorld
{
    public class Cow : FarmAnimal, ICare
    {
        private TypeOfCow m_CowType;

        public TypeOfCow CowType
        {
            get
            {
                return m_CowType;
            }

            set
            {
                m_CowType = value;
            }
        }

        public string Deworm()
        {
            return this.Farmer + " dips " + this.AnimalName;
        }

        public string Groom()
        {
            return this.Farmer + " slaughter " + this.AnimalName;
        }
    }
}