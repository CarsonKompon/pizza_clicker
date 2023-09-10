using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeSauceBrewery8 : Upgrade
{
    public override string Ident => "upgrade_sauce_brewery_8";
    public override string Name => "Gold Taste Testing Factory";
    public override string Description => "Sauce Breweries are twice as effective";
    public override double Cost => double.Parse("700,000,000,000,000,000,000");
    public override string Icon => "ui/upgrades/taste_factory_gold.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingResearch("sauce_brewery") >= 250;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("sauce_brewery", 2);
    }

}

