using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class BlessingPizzasPerFriend1 : Blessing
{
    public override string Ident => "pizzas_per_friend_01";
    public override string Name => "BFFs";
    public override string Description => "Pizza production multiplier +5% for every person playing in your lobby (including yourself).";
    public override double Cost => 99;
    public override string[] Requires => new string[] { "ascension" };
    public override string Icon => "ui/upgrades/friends.png";
}

