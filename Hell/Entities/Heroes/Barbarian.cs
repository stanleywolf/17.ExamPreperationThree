using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Barbarian:AbstractHero
{
    public Barbarian(string name)
    {
        this.Name = name;
        this.Strength = 90;
        this.Agility = 25;
        this.Intelligence = 10;
        this.HitPoints = 350;
        this.Damage = 150;
    }
}
