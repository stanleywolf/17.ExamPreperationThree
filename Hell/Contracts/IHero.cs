using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IHero
{
    long Agility { get; set; }
    long Damage { get; set; }
    long HitPoints { get; set; }
    long Intelligence { get; set; }
    ICollection<IItem> Items { get; }
    string Name { get; }
    long PrimaryStats { get; }
    long SecondaryStats { get; }
    long Strength { get; set; }

    void AddRecipe(RecipeItem recipe);

    void AddCommonItem(IItem item);

    int CompareTo(AbstractHero other);
}