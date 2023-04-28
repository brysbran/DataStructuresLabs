using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOneC
{
    public class Clue:Item
    {
        private String personIncriminated;
        private Boolean accuracy;


        public Clue(String name, String description, double weight, double value):base(name, description, weight, value)
        {
        }
    }
}
