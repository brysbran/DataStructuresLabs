using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOneC
{
    public class Consumable:Item
    {
        private int healthEffect;
        private int dosesRemaining;

        public Consumable(String name, String description, double weight, double value):base(name, description, weight, value)
        {
       
        }
    }
}
