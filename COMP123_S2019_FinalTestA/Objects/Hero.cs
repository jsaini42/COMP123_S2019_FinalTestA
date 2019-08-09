using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * STUDENT NAME: JASPINDER SINGH SAINI
 * STUDENT ID: 301044893
 * DESCRIPTION: This is the Hero Container Class.
 */

namespace COMP123_S2019_FinalTestA.Objects
{
    class Hero
    {
        //Identity
        public string HeroName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Physical abilities
        public string Fighting { get; set; }
        public string Strength { get; set; }
        public string Agility { get; set; }
        public string Endurance { get; set; }     
        
        // Mental Abilities
        public string Reason { get; set; }
        public string Intuition { get; set; }
        public string Psyche { get; set; }
        public string Popularity { get; set; }

        // Power Abilities
        List<Power> Powers;


        //constructor
        Hero()
        {
            // Instantiate an empty Power List
            Powers = new List<Power>();
        }
        
    }
}
