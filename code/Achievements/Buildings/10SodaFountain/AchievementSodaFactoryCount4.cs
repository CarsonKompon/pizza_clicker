using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementSodaFactoryCount4 : Achievement
{
    public override string Ident => "building_10_soda_factory_count_04";
    public override string Name => "Liquid assets";
    public override string Description => "Purchase 150 Soda Fountain Factories";
    public override string Icon => "/ui/buildings/soda_fountain_factory.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("soda_fountain_factory") >= 150;
	}

}

