using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementPizzaFederationCount3 : Achievement
{
    public override string Ident => "building_16_pizza_federation_count_03";
    public override string Name => "Intergalactic gourmet";
    public override string Description => "Purchase 100 Pizza Federations";
    public override string Icon => "/ui/buildings/pizza_federation.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingResearch("pizza_federation") >= 100;
	}

}

