using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class RecipeItem : Item,IRecipe
{
    public RecipeItem(string name, long strengthBonus, long agilityBonus, long intelligenceBonus, long hitPointsBonus, long damageBonus,params string[] items) : base(name, strengthBonus, agilityBonus, intelligenceBonus, hitPointsBonus, damageBonus)
    {
        this.RequiredItems = new List<string>();
        foreach (var item in items)
        {
            RequiredItems.Add(item);
        }
    }

    public IList<string> RequiredItems { get; }
}
   