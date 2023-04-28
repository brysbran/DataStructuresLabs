using System;
using System.Collections.Generic;


namespace LabOneC
{
    public class Backpack
    {
        private List<Item> contents;

        public Backpack()
        {
            contents = new List<Item>();
        }

        public void Add(Item item)
        {
            contents.Add(item);
        }

        public String ListWeapons()
        {
            String weapons = "";
            weapons += "\nWeapons--------------------------------------------------\n";
            foreach (Item i in contents)
            {
                if(i is Weapon)
                        {
                          weapons += i.ToString();
                          weapons += "\n---------------------------------------------------------\n";
                }
            }
            return weapons;
        }

        public String ListClues()
        {
            String clues = "";
            clues += "\nClues----------------------------------------------------\n";
            foreach(Item i in contents)
            {
                if(i is Clue)
                {
                    clues += i.ToString();
                    clues += "\n---------------------------------------------------------\n";
                }
            }
            return clues;
        }

        public String ListConsumables()
        {
            String consumables = "";
            consumables += "\nConsumables----------------------------------------------\n";
            foreach(Item i in contents)
            {
                if(i is Consumable)
                {
                    consumables += i.ToString();
                    consumables += "\n---------------------------------------------------------\n";
                }
            }
            return consumables;
        }


    }
}
