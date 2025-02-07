using Sandbox;
using System.Linq;

namespace PizzaClicker.Achievements;

[Library]
public class Achievement
{
	public virtual string Ident => "none";
	public virtual string Name => "None";
	public virtual string Description => "";
	public virtual string Icon => "ui/icons/trophy.png";

	public virtual bool CheckUnlockCondition( Player player )
	{
		return false;
	}

	public virtual void OnAchievementUnlock( Player player )
	{
		Sandbox.Services.Achievements.Unlock( Ident );
	}

	public double GetProgression( Player player )
	{
		return CheckUnlockCondition( player ) ? 1 : GetAchievementProgression( player );
	}

	protected virtual double GetAchievementProgression( Player player )
	{
		return CheckUnlockCondition( player ) ? 1 : 0;
	}

	public static void Unlock( Player player, string ident )
	{
		if ( !player.GiveAchievement( ident ) )
		{
			return;
		}

		var achievement = GameMenu.AllAchievements.FirstOrDefault( a => a.Ident == ident, null );
		if ( achievement == null )
		{
			return;
		}

		Notifications.Popup( "Achievement Unlocked!", achievement.Name, "achievement", achievement.Icon );
		GameMenu.Instance?.NetworkAchievementUnlock( ident );
		achievement.OnAchievementUnlock( player );
	}
}
