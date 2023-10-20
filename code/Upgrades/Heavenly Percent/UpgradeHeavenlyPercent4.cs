using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeHeavenlyPercent4 : Upgrade
{
	public override string Ident => "upgrade_heavenly_percent_4";
	public override string Name => "Heavenly pizzeria";
	public override string Description => "Unlocks 75% of the potential of your ascension level.";
	public override double Cost => 11_111_111;
	public override string Icon => "ui/icons/trophy.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.HasUpgrade( "upgrade_heavenly_percent_3" );
	}

	public override void OnPurchase( Player player )
	{
		if ( player.HeavenlyPercent < 0.75d )
		{
			player.HeavenlyPercent = 0.75d;
		}
	}
}
