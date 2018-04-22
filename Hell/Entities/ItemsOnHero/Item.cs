using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Item:IItem
{
    public string Name { get; }
    public long StrengthBonus { get; }
    public long AgilityBonus { get; }
    public long IntelligenceBonus { get; }
    public long HitPointsBonus { get; }
    public long DamageBonus { get; }

    protected Item(string name, long strengthBonus, long agilityBonus, long intelligenceBonus, long hitPointsBonus, long damageBonus)
    {
        this.Name = name;
        this.StrengthBonus = strengthBonus;
        this.AgilityBonus = agilityBonus;
        this.IntelligenceBonus = intelligenceBonus;
        this.HitPointsBonus = hitPointsBonus;
        this.DamageBonus = damageBonus;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"###Item: {this.Name}");
        sb.AppendLine($"###+{this.StrengthBonus} Strength");
        sb.AppendLine($"###+{this.AgilityBonus} Agility");
        sb.AppendLine($"###+{this.IntelligenceBonus} Intelligence");
        sb.AppendLine($"###+{this.HitPointsBonus} HitPoints");
        sb.AppendLine($"###+{this.DamageBonus} Damage");

        return sb.ToString().Trim();
    }
}