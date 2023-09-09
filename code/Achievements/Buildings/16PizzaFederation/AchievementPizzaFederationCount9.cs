using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementPizzaFederationCount9 : Achievement
{
    public override string Ident => "building_16_pizza_federation_count_09";
    public override string Name => "Universal unity";
    public override string Description => "Purchase 400 Pizza Federations";
    public override string Icon => "/ui/buildings/pizza_federation.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("pizza_federation") >= 400;
	}

}

