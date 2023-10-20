using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeHeavenlyPercent1 : Upgrade
{
	public override string Ident => "upgrade_heavenly_percent_1";
	public override string Name => "Heavenly crust secret";
	public override string Description => "Unlock the potential of your ascension(s).\n\nUnlocks 5% of the potential of your ascension level.";
	public override double Cost => 11;
	public override string Icon => "ui/icons/trophy.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.AscensionCount > 0;
	}

	public override void OnPurchase( Player player )
	{
		if ( player.HeavenlyPercent < 0.05d )
		{
			player.HeavenlyPercent = 0.05d;
		}
	}
}
