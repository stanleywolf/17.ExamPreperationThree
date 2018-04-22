using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IManager
{
    string AddHero(List<string> arguments);

    string AddItemToHero(List<string> arguments, IHero hero);

    string AddRecipeToHero(List<string> arguments, IHero hero);

    string Inspect(List<string> arguments);

    string Quit();
}