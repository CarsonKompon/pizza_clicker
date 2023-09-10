using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementSodaFactoryCount11 : Achievement
{
    public override string Ident => "building_10_soda_factory_count_11";
    public override string Name => "Fizztopia";
    public override string Description => "Purchase 500 Soda Fountain Factories";
    public override string Icon => "/ui/buildings/soda_fountain_factory.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingResearch("soda_fountain_factory") >= 500;
	}

}

