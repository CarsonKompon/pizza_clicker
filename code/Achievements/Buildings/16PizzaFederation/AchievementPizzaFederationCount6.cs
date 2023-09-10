using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementPizzaFederationCount6 : Achievement
{
    public override string Ident => "building_16_pizza_federation_count_06";
    public override string Name => "Galactic governance";
    public override string Description => "Purchase 250 Pizza Federations";
    public override string Icon => "/ui/buildings/pizza_federation.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingResearch("pizza_federation") >= 250;
	}

}

