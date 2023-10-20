using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeHeavenlyPercent5 : Upgrade
{
	public override string Ident => "upgrade_heavenly_percent_5";
	public override string Name => "Heavenly conglomerate";
	public override string Description => "Unlocks 100% of the potential of your ascension level.";
	public override double Cost => 1_111_111_111;
	public override string Icon => "ui/icons/trophy.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.HasUpgrade( "upgrade_heavenly_percent_3" );
	}

	public override void OnPurchase( Player player )
	{
		if ( player.HeavenlyPercent < 1d )
		{
			player.HeavenlyPercent = 1d;
		}
	}
}
