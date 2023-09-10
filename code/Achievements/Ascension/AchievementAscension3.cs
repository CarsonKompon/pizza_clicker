using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementAscension3 : Achievement
{
    public override string Ident => "ascension_03";
    public override string Name => "Reincarnation";
    public override string Description => "Ascend 10 times.";
    public override string Icon => "ui/icons/trophy.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.AscensionCount >= 10;
	}

}

