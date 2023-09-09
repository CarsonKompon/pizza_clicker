using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementPizzaFederationCount4 : Achievement
{
    public override string Ident => "building_16_pizza_federation_count_04";
    public override string Name => "E-Pluribus pizza";
    public override string Description => "Purchase 150 Pizza Federations";
    public override string Icon => "/ui/buildings/pizza_federation.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("pizza_federation") >= 150;
	}

}

