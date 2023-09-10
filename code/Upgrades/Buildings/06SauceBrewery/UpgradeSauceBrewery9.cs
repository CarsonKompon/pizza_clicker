using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeSauceBrewery9 : Upgrade
{
    public override string Ident => "upgrade_sauce_brewery_9";
    public override string Name => "Rainbow Taste Testing Factory";
    public override string Description => "Sauce Breweries are twice as effective";
    public override double Cost => double.Parse("700,000,000,000,000,000,000,000");
    public override string Icon => "ui/upgrades/taste_factory_rainbow.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingCount("sauce_brewery") >= 300;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("sauce_brewery", 2);
    }

}

