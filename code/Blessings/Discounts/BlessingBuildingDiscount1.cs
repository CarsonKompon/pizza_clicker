using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class BlessingBuildingDiscount1 : Blessing
{

    public override string Ident => "building_discount_01";
    public override string Name => "Divine discount";
    public override string Description => "Buildings are 1% cheaper";
    public override double Cost => 99_999;
    public override string[] Requires => new string[] { "ascension" };
    public override string Icon => "ui/icons/house.png";

}

// 