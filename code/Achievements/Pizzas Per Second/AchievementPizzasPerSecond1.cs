using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementPizzasPerSecond1 : Achievement
{
    public override string Ident => "pizzas_per_second_01";
    public override string Name => "Slo-mo dough";
    public override string Description => "Bake 1 pizza/sec";
    public override string Icon => "ui/pizzas/pepperoni_pizza.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.PizzasPerSecond >= 1;
	}
}
