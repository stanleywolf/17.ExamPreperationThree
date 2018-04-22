using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IRecipe:IItem
{
    IList<string> RequiredItems { get; }
}