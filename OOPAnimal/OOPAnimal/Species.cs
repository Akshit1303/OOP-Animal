using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAnimal
{
    enum EyeColor
    {
        Yellow, RedBrown, Blue
    }
    class Species : Genus
    {
        public string binomialName;
        public int numberOfLegs;
        public  List<EyeColor> eyecolors;
        public Species()
        {
            Name = "No Name";
        }
       public Species(string _name)
        {
            
            if (_name is null)
            {
                Name = "No Name";
            }
            else if(_name.Length < 1)
            {
                Name = "No Name";
            }
            else 
            {
                Name = _name;
            }
            Console.WriteLine("Creating: " + _name + " at " + DateTime.Now.ToString("yyyy-MM-dd"));


        }
        public Species(string _name, string _binomialName) : this(_name)
        {
            if (_binomialName is null)
            {
                binomialName = "No Name";
            }
            else if (_binomialName.Length < 1)
            {
                binomialName = "No Name";
            }
            else
            {
                binomialName = _binomialName;
            }
            
        }
        public Species( string _name, int _numberOfLegs) : this(_name)
        {
            numberOfLegs = _numberOfLegs;
            

        }
    }
}
