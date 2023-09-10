using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementPizzaFederationCount1 : Achievement
{
    public override string Ident => "building_16_pizza_federation_count_01";
    public override string Name => "Small council, big decisions";
    public override string Description => "Purchase 1 Pizza Federation";
    public override string Icon => "/ui/buildings/pizza_federation.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingResearch("pizza_federation") >= 1;
	}

}

