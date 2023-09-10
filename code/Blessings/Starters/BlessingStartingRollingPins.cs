using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class BlessingStartingRollingPins : Blessing
{
    public override string Ident => "starting_rolling_pins";
    public override string Name => "Starter Kitchen";
    public override string Description => "You start with 10 Rolling Pins";
    public override double Cost => 50;
    public override string[] Requires => new string[] { "ascension" };
    public override string Icon => "ui/buildings/rolling_pin.png";

    public override void OnAfterAscension(Player player)
    {
        player.GiveBuilding("rolling_pin", 10);
    }

}

