using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    public class Animal
    {
        public Animal()
        {
            this.AnimalName = "The animal";
            this.Habitat = "The World";
        }
        public Animal(string strName, string strHabitat)
        {

            this.AnimalName = strName;
            this.Habitat = strHabitat;
        }
        private string m_AnimalName;
        public string AnimalName
        {
            get
            {
                return m_AnimalName;
            }
            set
            {
                m_AnimalName = value;
            }
        }
        public virtual string Eat()
        {
            return this.AnimalName + " eats.";
        }
        public virtual string Move()
        {
            return this.AnimalName + " moves.";
        }/*
        public string Habitat
        {
            get
            {

            }
            set
            {

            }
        }*/
        public string Habitat { get; set; }
    }
}
