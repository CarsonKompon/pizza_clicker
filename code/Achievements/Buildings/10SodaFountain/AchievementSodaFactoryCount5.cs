using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementSodaFactoryCount5 : Achievement
{
    public override string Ident => "building_10_soda_factory_count_05";
    public override string Name => "Pop star";
    public override string Description => "Purchase 200 Soda Fountain Factories";
    public override string Icon => "/ui/buildings/soda_fountain_factory.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("soda_fountain_factory") >= 200;
	}

}

