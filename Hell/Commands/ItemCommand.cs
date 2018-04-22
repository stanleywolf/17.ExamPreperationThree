using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ItemCommand : Command
{
    public ItemCommand(List<string> args, IManager manager) : base(args, manager)
    {
    }

    public override string Execute()
    {
        string heroName = this.Args[1];
        List<string> itemArgs = new List<string>(this.Args);
        IHero hero = (this.Manager as HeroManager).heroes[heroName];

        return base.Manager.AddItemToHero(itemArgs, hero);
    }
}

