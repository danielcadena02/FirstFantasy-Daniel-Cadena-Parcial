using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Equipment
{
    public class Axe : Weapon

    {
        public string ShowInformation()
        {
            return "soy hermoso";
        }
        public override string Atacar()
        {
            int a = new Random().Next(0, 9);
            string b = "";
            return b + a;

        }

    }
}
