﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class RecipeCommand : Command
{
    public RecipeCommand(List<string> args, IManager manager) : base(args, manager)
    {
    }

    public override string Execute()
    {
        string heroName = this.Args[1];
        IHero hero = (this.Manager as HeroManager).heroes[heroName];

        return base.Manager.AddRecipeToHero(this.Args, hero);
    }
}
   
