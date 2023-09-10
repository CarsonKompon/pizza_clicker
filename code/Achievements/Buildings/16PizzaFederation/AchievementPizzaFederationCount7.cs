using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementPizzaFederationCount7 : Achievement
{
    public override string Ident => "building_16_pizza_federation_count_07";
    public override string Name => "The federation's finest";
    public override string Description => "Purchase 300 Pizza Federations";
    public override string Icon => "/ui/buildings/pizza_federation.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("pizza_federation") >= 300;
	}

}

