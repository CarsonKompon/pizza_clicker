using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class Achievement
{
    public virtual string Ident => "none";
    public virtual string Name => "None";
    public virtual string Description => "";
    public virtual string Icon => "ui/icons/trophy.png";

    public virtual bool CheckUnlockCondition(Player player)
    {
        return false;
    }

    public virtual void OnAchievementUnlock(Player player)
    {

    }

    public static void Unlock(Player player, string ident)
    {
        if(player.GiveAchievement(ident))
        {
            foreach(var achievement in GameMenu.AllAchievements)
            {
                if(achievement.Ident == ident)
                {
                    Notifications.Popup("Achievement Unlocked!", achievement.Name, "achievement", achievement.Icon);

                    achievement.OnAchievementUnlock(player);

                    break;
                }
            }
        }
    }
}

