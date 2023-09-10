using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementPizzaFederationCount2 : Achievement
{
    public override string Ident => "building_16_pizza_federation_count_02";
    public override string Name => "Federal cheese-erve";
    public override string Description => "Purchase 50 Pizza Federations";
    public override string Icon => "/ui/buildings/pizza_federation.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingResearch("pizza_federation") >= 50;
	}

}

