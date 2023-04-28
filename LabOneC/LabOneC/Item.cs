using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOneC
{
   public class Item
        {
            protected String name;
            protected String description;
            protected double weight;
            protected double value;

            public Item(String name, String description, double weight, double value)
            {
                this.name = name;
                this.description = description;
                this.weight = weight;
                this.value = value;
            }

            public String ToString()
            {
                return "Item name: " + name + "\nDescription: " + description + "\nWeight: " + weight + " pounds" + "\nValue: "
                        + value + " gold pieces";
            }
        }

    }

