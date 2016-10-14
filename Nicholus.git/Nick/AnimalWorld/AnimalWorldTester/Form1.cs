using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnimalWorld;
using AnimalWorld.AnimalTypes;

namespace AnimalWorldTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cboAnimals_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();

            switch (cboAnimals.SelectedIndex)
            {
                case 1://Any Animal
                    Animal anyAnimal1 = new Animal();
                    //anyAnimal1.AnimalName = "Any animal";

                    lstInfo.Items.Add("Animal name: " + anyAnimal1.AnimalName);
                    lstInfo.Items.Add("Habitat name: " + anyAnimal1.Habitat);
                    lstInfo.Items.Add("Eat: " + anyAnimal1.Eat());
                    lstInfo.Items.Add("Move: " + anyAnimal1.Move());

                    lstInfo.Items.Add("");

                    Animal anyAnimal2 = new Animal("Generic animal","Anywhere");
                    lstInfo.Items.Add("Animal name: " + anyAnimal2.AnimalName);
                    lstInfo.Items.Add("Habitat name: " + anyAnimal2.Habitat);
                    lstInfo.Items.Add("Eat: " + anyAnimal2.Eat());
                    lstInfo.Items.Add("Move: " + anyAnimal2.Move());

                    break;
                case 2://Wild Animal
                    WildAnimal anyWildAnimal = new WildAnimal();
                    anyWildAnimal.AnimalName = "Any Wild animal";
                    anyWildAnimal.IsPredator = true;

                    lstInfo.Items.Add("Animal name: " + anyWildAnimal.AnimalName);
                    lstInfo.Items.Add("Habitat name: " + anyWildAnimal.Habitat);
                    lstInfo.Items.Add("Is Predator? " + anyWildAnimal.IsPredator);
                    lstInfo.Items.Add("Eat: " + anyWildAnimal.Eat());
                    lstInfo.Items.Add("Move: " + anyWildAnimal.Move());
                    break;
                case 3://Farm Animal
                    FarmAnimal anyFarmAnimal = new FarmAnimal();
                    anyFarmAnimal.AnimalName = "Any Farm animal";
                    anyFarmAnimal.Farmer = "Nick";
                    anyFarmAnimal.Habitat = "The Farm";

                    lstInfo.Items.Add("Animal name: " + anyFarmAnimal.AnimalName);
                    lstInfo.Items.Add("Habitat name: " + anyFarmAnimal.Habitat);
                    lstInfo.Items.Add("Farmer Name: " + anyFarmAnimal.Farmer);
                    lstInfo.Items.Add("Eat: " + anyFarmAnimal.Eat());
                    lstInfo.Items.Add("Move: " + anyFarmAnimal.Move());
                    break;
                case 4://Horse
                    Horse silver = new Horse();
                    silver.AnimalName = "Silver";
                    silver.Farmer = "Nick";
                    silver.Habitat = "The Wild West";
                    silver.HorseType = TypeOfHorse.Cart;

                    lstInfo.Items.Add("Animal name: " + silver.AnimalName);
                    lstInfo.Items.Add("Habitat name: " + silver.Habitat);
                    lstInfo.Items.Add("Farmer Name: " + silver.Farmer);
                    lstInfo.Items.Add("Type : " + silver.HorseType);

                    lstInfo.Items.Add("Groom: " + silver.Groom());
                    lstInfo.Items.Add("Deworm: " + silver.Deworm());
                    break;
                case 5://Cow
                    Cow daisy = new Cow();
                    daisy.AnimalName = "Daisy";
                    daisy.Farmer = "Nick";
                    daisy.Habitat = "Dairy";
                    daisy.CowType = TypeOfCow.Beef;

                    lstInfo.Items.Add("Animal name: " + daisy.AnimalName);
                    lstInfo.Items.Add("Habitat name: " + daisy.Habitat);
                    lstInfo.Items.Add("Farmer Name: " + daisy.Farmer);
                    lstInfo.Items.Add("Type : " + daisy.CowType);
                    lstInfo.Items.Add("Eat: " + daisy.Eat());
                    lstInfo.Items.Add("Move: " + daisy.Move());

                    lstInfo.Items.Add("Groom: " + daisy.Groom());
                    lstInfo.Items.Add("Deworm: " + daisy.Deworm());
                    break;
                default://[Please select a type of animal...]
                    lstInfo.Items.Add("No Animal Selected...");
                    break;
            }
            /*[Please select a type of animal...]
            Any Animal
            Wild Animal
            Farm Animal
            Horse
            Cow*/

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboAnimals.SelectedIndex = 0;
        }
    }
}
