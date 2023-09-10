using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeSauceBrewery5 : Upgrade
{
    public override string Ident => "upgrade_sauce_brewery_5";
    public override string Name => "Taste Testing Factory";
    public override string Description => "Sauce Breweries are twice as effective";
    public override double Cost => 7_000_000_000_000;
    public override string Icon => "ui/upgrades/taste_factory.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingResearch("sauce_brewery") >= 100;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("sauce_brewery", 2);
    }

}

