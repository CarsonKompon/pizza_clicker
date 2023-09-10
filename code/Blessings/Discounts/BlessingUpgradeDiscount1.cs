using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class BlessingUpgradeDiscount1 : Blessing
{

    public override string Ident => "upgrade_discount_01";
    public override string Name => "Divine sales";
    public override string Description => "Upgrades are 1% cheaper";
    public override double Cost => 99_999;
    public override string[] Requires => new string[] { "building_discount_01" };

}

// 