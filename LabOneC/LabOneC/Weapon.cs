using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOneC
{
    public class Weapon:Clue
    {
        private int damage;
        private DamageType damageType;
        public Weapon(String name, String description, double weight, double value):base(name, description, weight, value)
        {  
        }
    }
}
