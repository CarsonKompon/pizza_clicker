using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeSauceBrewery1 : Upgrade
{
    public override string Ident => "upgrade_sauce_brewery_1";
    public override string Name => "Bronze Sauce Brewery";
    public override string Description => "Sauce Breweries are twice as effective";
    public override double Cost => 14_000_000;
    public override string Icon => "ui/upgrades/sauce_brewery_bronze.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingCount("sauce_brewery") >= 1;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("sauce_brewery", 2);
    }

}

