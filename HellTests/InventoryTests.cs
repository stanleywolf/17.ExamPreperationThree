using System;
using System.Collections.Generic;
using NUnit.Framework;

[TestFixture]
public class InventoryTests
{
    private IInventory test;

    [SetUp]
    public void TestInit()
    {
        this.test = new HeroInventory();
    }

    [Test]
    public void NewInventoryStartsAreZero()
    {
        this.test = new HeroInventory();
        long totalStatsBonus = this.test.TotalStrengthBonus + this.test.TotalAgilityBonus + this.test.TotalDamageBonus +         this.test.TotalHitPointsBonus + this.test.TotalHitPointsBonus;

        Assert.AreEqual(0,totalStatsBonus);
    }

    [Test]
    public void GetBonusFromCommonItem()
    {
        IItem item = new CommonItem("TestItem",1,1,1,1,1);
        this.test.AddCommonItem(item);

        Assert.AreEqual(1,this.test.TotalHitPointsBonus);
        Assert.AreEqual(1,this.test.TotalAgilityBonus);
        Assert.AreEqual(1,this.test.TotalDamageBonus);
        Assert.AreEqual(1,this.test.TotalStrengthBonus);
        Assert.AreEqual(1,this.test.TotalIntelligenceBonus);
    }
    [Test]
    public void CreatingNewHeroInventoryIsSuccessful()
    {
        this.test = new HeroInventory();

        Assert.Pass();
    }

    [Test]
    public void AddCommonItemSuccessful()
    {
        IItem item = new CommonItem("Hui",1,1,1,1,1);
        this.test.AddCommonItem(item);

        Assert.Pass();
    }

    [Test]
    public void AddRecipeItemSuccessful()
    {
        IRecipe item = new RecipeItem("Putka",1,1,1,1,1,"huiche");
        this.test.AddRecipeItem(item);

        Assert.Pass();
    }
    public void AddingNullItemThrowsException()
    {
        IItem item = null;

        Assert.Throws<NullReferenceException>(() => this.test.AddCommonItem(item));
    }

    [Test]
    public void AddingNullRecipeThrowsException()
    {
        IRecipe recipe = null;

        Assert.Throws<NullReferenceException>(() => this.test.AddRecipeItem(recipe));
    }
    [Test]
    public void CompleteRecipeForNewItem()
    {
        IItem relic = new CommonItem("SacredRelic", 0, 0, 0, 0, 60);
        string[] recipeComponents = new string[] { "SacredRelic", "RadianceRecipe" };
        IRecipe recipe = new RecipeItem("Radiance", 0, 0, 0, 0, 80, recipeComponents);
        IItem radianceRecipe = new CommonItem("RadianceRecipe", 0, 0, 0, 0, 0);

        this.test.AddCommonItem(relic);
        this.test.AddRecipeItem(recipe);
        this.test.AddCommonItem(radianceRecipe);

        Assert.AreEqual(80, this.test.TotalDamageBonus);
    }
    [Test]
    public void ChainingRecipes()
    {
        string[] recipeComponents1 = new string[] { "BootsOfSpeed" };
        IRecipe recipe1 = new RecipeItem("BootsOfTravell", 100, 100, 100, 100, 100, recipeComponents1);
        IItem boots = new CommonItem("BootsOfSpeed", 10, 10, 10, 10, 10);

        string[] recipeComponents2 = new string[] { "BootsOfTravell" };
        IRecipe recipe2 = new RecipeItem("BootsOfTravell2", 200, 200, 200, 200, 200, recipeComponents2);

        this.test.AddCommonItem(boots);
        this.test.AddRecipeItem(recipe1);
        this.test.AddRecipeItem(recipe2);
        long totalStatsBonus = this.test.TotalAgilityBonus
                     + this.test.TotalStrengthBonus
                     + this.test.TotalIntelligenceBonus
                     + this.test.TotalHitPointsBonus
                     + this.test.TotalDamageBonus;

        Assert.AreEqual(1000, totalStatsBonus);
    }

   
    [Test]
    public void AddItemChangesTotalStregth()
    {
        var item = new CommonItem("Knife", 50, 10, 0, 0, 30);
        var item1 = new CommonItem("Hammer", 5, 10, 0, 0, 30);

        this.test.AddCommonItem(item);
        this.test.AddCommonItem(item1);

        Assert.AreEqual(55, this.test.TotalStrengthBonus);
    }

    [Test]
    public void DuplicatingRecipeThrowsException()
    {
        string[] recipeComponents1 = new string[] { "BootsOfSpeed" };
        IRecipe recipe1 = new RecipeItem("BootsOfTravell", 100, 100, 100, 100, 100, recipeComponents1);

        this.test.AddRecipeItem(recipe1);

        Assert.Throws<ArgumentException>(() => this.test.AddRecipeItem(recipe1));
    }

    [Test]
    public void DuplicatingCommonItemThrowsException()
    {
        IItem item = new CommonItem("BootsOfTravell", 100, 100, 100, 100, 100);

        this.test.AddCommonItem(item);

        Assert.Throws<ArgumentException>(() => this.test.AddCommonItem(item));
    }
}