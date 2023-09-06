using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeSauceBrewery2 : Upgrade
{
    public override string Ident => "upgrade_sauce_brewery_2";
    public override string Name => "Silver Sauce Brewery";
    public override string Description => "Sauce Breweries are twice as effective";
    public override double Cost => 70_000_000;
    public override string Icon => "ui/upgrades/sauce_brewery_silver.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingCount("sauce_brewery") >= 5;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("sauce_brewery", 2);
    }

}

