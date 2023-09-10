using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class BlessingUpgradeDiscount2 : Blessing
{

    public override string Ident => "upgrade_discount_02";
    public override string Name => "Pins and needles";
    public override string Description => "Upgrades are 1% cheaper for every 100 rolling pins.";
    public override double Cost => 555_555;
    public override string[] Requires => new string[] { "upgrade_discount_01" };
    public override string Icon => "ui/icons/tag.png";

}

// 