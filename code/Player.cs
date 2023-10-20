using System;
using System.Collections.Generic;
using Sandbox;
using PizzaClicker.Achievements;
using PizzaClicker.Blessings;
using PizzaClicker.Buildings;
using PizzaClicker.Upgrades;
using System.Linq;

namespace PizzaClicker;

public class Player
{
	public Friend Member;

	public double Pizzas { get; set; } = 0;
	public double PizzasPerSecond { get; set; } = 0;
	public double PizzasPerClick { get; set; } = 1;
	public double TotalPizzasBaked { get; set; } = 0;
	public double HandMadePizzas { get; set; } = 0;
	public double TotalClicks { get; set; } = 0;
	public double TotalGoldClicks { get; set; } = 0;
	public double LegacyDough { get; set; } = 0;
	public double LastLevel { get; set; } = 0;
	public double TotalLegacyBaked { get; set; } = 0;
	public double TotalPizzasBakedAllTime { get; set; } = 0;
	public double HeavenlyCrust { get; set; } = 0;
	public double AscensionCount { get; set; } = 0;

	public Dictionary<string, ulong> Buildings { get; set; } = new();
	public Dictionary<string, bool> Achievements { get; set; } = new();
	public Dictionary<string, bool> Upgrades { get; set; } = new();
	public Dictionary<string, bool> Blessings { get; set; } = new();

	private readonly Dictionary<string, double> _buildingTimers = new();
	private readonly Dictionary<string, double> _multipliers = new();
	private readonly Dictionary<string, double> _temporaryMultipliers = new();
	private readonly Dictionary<string, double> _temporaryTimers = new();

	public double MittenMultiplier = 1;
	public double TotalMultiplier = 1;
	public double AchievementMultiplier = 0;
	public double ResearchSpeed = 1;
	public double PpSPercent = 0;
	public float GoldMinTime = 300;
	public float GoldMaxTime = 900;
	public float GoldDuration = 8f;
	public double GoldMultiplier = 1d;
	public double HeavenlyPercent = 0d;

	private double _particleTimer = 0f;

	public RealTimeUntil GoldTimer;
	public RealTimeUntil FrenzyTime;
	public RealTimeUntil ClickFrenzy;

	public Player()
	{
		GoldTimer = new Random().Float( GoldMinTime, GoldMaxTime );
	}

	public Player( Friend member ) : this()
	{
		Member = member;
	}

	public Player( long steamid ) : this()
	{
		Member = new Friend( steamid );
	}

	public double Click()
	{
		var value = PizzasPerClick;

		if ( HasUpgrade( "upgrade_pizza_clicker_6" ) )
		{
			var ovenMittsValue = TotalBuildingCount * MittenMultiplier;
			value += ovenMittsValue;
		}

		if ( PpSPercent > 0 )
		{
			value += Math.Floor( PizzasPerSecond * (PpSPercent / 100.0) );
		}

		if ( HasBlessing( "starting_gloves_1" ) )
		{
			value *= 1.1d;

			if ( HasBlessing( "starting_gloves_2" ) )
			{
				var max = HasBlessing( "starting_gloves_3" ) ? 2d : 1.5d;
				var percent = Math.Min( 1d + (GetBuildingCount( "oven" ) / 200d), max );

				value *= percent;
			}
		}

		if ( ClickFrenzy > 0 )
		{
			value *= 777d;
		}

		Sound.FromScreen( "mouse.click" );

		HandMadePizzas += value;

		GivePizzas( value );

		++TotalClicks;

		return value;
	}

	public void GoldenClick( Vector2 pos )
	{
		Random rand = new();
		var particleText = "Golden Pizza!";
		float chance = rand.Float();

		// Lucky Pizza
		switch ( chance )
		{
			case < 0.07f:
				ClickFrenzy = 13 * (float)GoldMultiplier;

				particleText = $"Click Frenzy!\nx7 pizzas/click for {ClickFrenzy}s";
				Notifications.Popup( "Click Frenzy!", $"x777 pizzas/click for {ClickFrenzy}s", "gold click", "/ui/pizzas/gold_pizza.png", ClickFrenzy );

				break;
			case < 0.35f:
				var bankedPercent = Math.Floor( Pizzas * 0.15 ) + 13;
				var ppsPercent = Math.Floor( PizzasPerSecond * 900 ) + 13;
				var realVal = Math.Min( bankedPercent, ppsPercent );

				Pizzas += realVal;

				particleText = $"Lucky Pizza!\n+{NumberHelper.ToStringAbbreviated( realVal )} Pizzas";

				break;
			case < 0.65f:
				var value = Math.Round( 77 * GoldMultiplier );
				FrenzyTime = (float)value;

				particleText = $"Pizza Frenzy!\nx7 PpS for {value}s";
				Notifications.Popup( "Pizza Frenzy!", $"x7 pizzas/sec for {value}s", "gold frenzy", "/ui/pizzas/gold_pizza.png", FrenzyTime );

				break;
			default:
				var buildings = OwnedBuildings;
				var building = buildings.ElementAt(rand.Next( buildings.Count() ));
				var multiplier = (10 * GetBuildingCount( building.Ident ) + 100d) / 100d;

				_temporaryMultipliers[building.Ident] = multiplier;
				_temporaryTimers[building.Ident] = 30 * GoldMultiplier;

				particleText = $"Building Bonus!\n{NumberHelper.ToStringAbbreviated( multiplier )}x {building.Name} PpS for {_temporaryTimers[building.Ident]}s";
				Notifications.Popup( "Building Bonus!", $"{NumberHelper.ToStringAbbreviated( multiplier )}x {building.Name} pizzas/sec for {_temporaryTimers[building.Ident]}s", "gold building", "/ui/buildings/" + building.Ident + ".png", (float)_temporaryTimers[building.Ident] );

				break;
		}

		++TotalGoldClicks;

		TextParticle particle = new( pos, particleText, "gold", true, 2 );
		GameMenu.Instance.AddChild( particle );
	}

	public void StartAscension()
	{
		Save();

		HeavenlyCrust += LegacyDough;

		GameMenu.Instance.Ascending = true;
	}

	public void Ascend()
	{
		Pizzas = 0;
		PizzasPerClick = 1;
		PizzasPerSecond = 0;
		TotalPizzasBakedAllTime += TotalPizzasBaked;
		TotalPizzasBaked = 0;
		HandMadePizzas = 0;
		TotalClicks = 0;
		TotalGoldClicks = 0;
		LegacyDough += HeavenlyCrust;
		TotalLegacyBaked += HeavenlyCrust;
		LastLevel = LegacyDough;
		HeavenlyCrust = 0;
		Buildings.Clear();
		Upgrades.Clear();
		_multipliers.Clear();
		_temporaryMultipliers.Clear();
		_temporaryTimers.Clear();
		MittenMultiplier = 1;
		TotalMultiplier = 1;
		AchievementMultiplier = 0;
		ResearchSpeed = 1;
		PpSPercent = 0;
		GoldMinTime = 300;
		GoldMaxTime = 900;
		GoldDuration = 8f;
		GoldMultiplier = 1d;
		GoldTimer = new Random().Float( GoldMinTime, GoldMaxTime );
		FrenzyTime = 0;
		ClickFrenzy = 0;
		AscensionCount++;

		var blessings = GameMenu.AllBlessings
			.Where( b => HasBlessing( b.Ident ) );

		foreach ( var blessing in blessings )
		{
			blessing.OnAfterAscension( this );
		}

		Save();

		GameMenu.Instance.Ascending = false;
	}

	public void Save()
	{
		if ( Member.Id != Game.SteamId )
		{
			return;
		}

		var achievements = GameMenu.AllAchievements
			.Where( a => !Achievements.ContainsKey( a.Ident ) && a.CheckUnlockCondition( this ) );

		foreach ( var achievement in achievements )
		{
			Achievement.Unlock( this, achievement.Ident );
		}

		FileSystem.Data.WriteJson( Game.SteamId.ToString(), this );
	}

	public ulong GetBuildingCount( string ident )
	{
		if ( !Buildings.ContainsKey( ident ) )
		{
			return 0;
		}

		return Buildings[ident];
	}

	public double TotalBuildingCount
	{
		get
		{
			double count = 0;
			foreach ( var building in Buildings )
			{
				count += building.Value;
			}
			return count;
		}
	}

	public double GetBuildingMultiplier( string ident )
	{
		if ( !_multipliers.ContainsKey( ident ) )
		{
			return 1;
		}

		return _multipliers[ident];
	}

	public double GetTemporaryMultiplier( string ident )
	{
		if ( !_temporaryMultipliers.ContainsKey( ident ) )
		{
			return 1;
		}

		return _temporaryMultipliers[ident];
	}

	public bool BuyBuilding( Building building )
	{
		var cost = building.GetCost( this, GetBuildingCount( building.Ident ) );
		if ( Pizzas < cost )
		{
			return false;
		}

		Pizzas -= cost;

		GiveBuilding( building.Ident );

		return true;
	}

	public bool GiveBuilding( string ident, ulong amount = 1 )
	{
		if ( !Buildings.ContainsKey( ident ) )
		{
			Buildings.Add( ident, 0 );
		}

		Buildings[ident] += amount;

		Save();

		return true;
	}

	public bool HasAchievement( string ident )
	{
		if ( !Achievements.ContainsKey( ident ) )
		{
			return false;
		}

		return Achievements[ident];
	}

	public bool GiveAchievement( string ident )
	{
		if ( Achievements.ContainsKey( ident ) && Achievements[ident] )
		{
			return false;
		}

		Achievements[ident] = true;

		Save();

		return true;
	}

	public int AchievementCount => Achievements.Count;

	public double AchievementResearch => Achievements.Count * ResearchSpeed;

	public double GetBuildingResearch( string ident )
	{
		return GetBuildingCount( ident ) * ResearchSpeed;
	}

	public double TotalBuildingResearch => TotalBuildingCount * ResearchSpeed;

	public bool HasBlessing( string ident )
	{
		if ( !Blessings.ContainsKey( ident ) )
		{
			return false;
		}

		return Blessings[ident];
	}

	public bool GiveBlessing( string ident )
	{
		if ( Blessings.ContainsKey( ident ) && Blessings[ident] )
		{
			return false;
		}

		Blessings[ident] = true;

		Save();

		return true;
	}

	public bool BuyBlessing( Blessing blessing )
	{
		if ( blessing.Requires.Any( r => !HasBlessing( r ) ) )
		{
			return false;
		}

		if ( HeavenlyCrust < blessing.Cost )
		{
			return false;
		}

		HeavenlyCrust -= blessing.Cost;

		GiveBlessing( blessing.Ident );

		blessing.OnActivate( this );

		Save();

		return true;
	}

	public bool HasUpgrade( string ident )
	{
		if ( !Upgrades.ContainsKey( ident ) )
		{
			return false;
		}

		return Upgrades[ident];
	}

	public bool GiveUpgrade( string ident )
	{
		if ( Upgrades.ContainsKey( ident ) && Upgrades[ident] )
		{
			return false;
		}

		foreach ( var upgrade in GameMenu.AllUpgrades )
		{
			var cost = upgrade.GetCost( this );

			if ( upgrade.Ident == ident && Pizzas >= cost )
			{
				Pizzas -= cost;

				Upgrades[ident] = true;

				upgrade.OnPurchase( this );

				Save();

				return true;
			}
		}

		return false;
	}

	public IEnumerable<Upgrade> AvailableUpgrades =>
		GameMenu.AllUpgrades
			.Where( u => !HasUpgrade( u.Ident ) )
			.Where( u => u.CheckUnlockCondition( this ) );

	public IEnumerable<Upgrade> PurchasedUpgrades =>
		GameMenu.AllUpgrades
			.Where( u => HasUpgrade( u.Ident ) );

	public double TotalUpgradeCount => Upgrades.Where( u => u.Value ).Select( _ => 1 ).Sum();

	public void GivePizzas( double pizzas )
	{
		Pizzas += pizzas;
		TotalPizzasBaked += pizzas;
	}

	public void AddMultiplier( string ident, double multiplier )
	{
		if ( !_multipliers.ContainsKey( ident ) )
		{
			_multipliers.Add( ident, 1 );
		}

		_multipliers[ident] *= multiplier;
	}

	public void Update()
	{
		// Spawn the gold pizza
		if ( GoldTimer && !GoldenSwitch.Enabled )
		{
			Log.Info( "GOLD TIME" );

			GameMenu.Instance.SpawnGoldPizza();

			GoldTimer = new Random().Float( GoldMinTime, GoldMaxTime );
		}

		// Calculate PpS
		PizzasPerSecond = 0;
		var totalDeltaPizzas = 0.0;  // Total pizzas to be given during this frame

		foreach ( var building in GameMenu.AllBuildings )
		{
			var buildingCount = GetBuildingCount( building.Ident );
			if ( buildingCount == 0 )
			{
				continue;
			}

			var buildingPps = building.GetPizzasPerSecond( this, GetBuildingCount( building.Ident ) );
			PizzasPerSecond += buildingPps;

			if ( !_buildingTimers.ContainsKey( building.Ident ) )
			{
				_buildingTimers[building.Ident] = 0;
			}

			// Use delta time to update the timers
			_buildingTimers[building.Ident] += Time.Delta;

			// Calculate how many pizzas this building should produce during this frame
			double deltaPizzas = buildingPps * Time.Delta;

			// Add to total
			totalDeltaPizzas += deltaPizzas;

			// Optional: You can handle fractional pizzas by accumulating the remainder for the next frame
			// double fractionalPizzas = deltaPizzas % 1;
			// buildingTimers[building.Ident] = fractionalPizzas;
		}

		// Accumulate fractional pizzas from the previous frame
		if ( !_buildingTimers.ContainsKey( "total" ) )
		{
			_buildingTimers["total"] = 0;
		}
		_buildingTimers["total"] += totalDeltaPizzas;

		// Give whole pizzas, keep fractional part
		var wholePizzas = Math.Floor( _buildingTimers["total"] );
		if ( wholePizzas >= 1 )
		{
			GivePizzas( wholePizzas );

			_buildingTimers["total"] -= wholePizzas;  // keep the fractional part
		}

		// Advance temporary timers
		foreach ( var timer in _temporaryTimers )
		{
			_temporaryTimers[timer.Key] -= Time.Delta;

			if ( _temporaryTimers[timer.Key] <= 0 )
			{
				_temporaryTimers.Remove( timer.Key );
				_temporaryMultipliers.Remove( timer.Key );
			}
		}

		// Spawn particles
		_particleTimer += Time.Delta;
		if ( _particleTimer > 0.1f )
		{
			var val = Math.Floor( PizzasPerSecond / 10d );

			if ( val > 0 )
			{
				var particleText = "+" + NumberHelper.ToStringAbbreviated( val );
				Random rand = new();
				TextParticle particle = new( Screen.Size * new Vector2( rand.Float(), rand.Float( 0.5f, 1f ) ) * GameMenu.Instance.ScaleFromScreen, particleText );

				particle.AddClass( "gained" );

				GameMenu.Instance.AddChild( particle );

				_particleTimer = 0f;
			}
		}
	}

	public IEnumerable<Building> OwnedBuildings =>
		GameMenu.AllBuildings
			.Where( b => GetBuildingCount( b.Ident ) > 0 );

	public static Player LoadPlayer()
	{
		var data = FileSystem.Data.ReadJson<Player>( Game.SteamId.ToString() );
		if ( data == null )
		{
			return new( Game.SteamId );
		}

		data.Member = new( Game.SteamId );

		data.PizzasPerClick = 1;
		data.MittenMultiplier = 1;
		data.TotalMultiplier = 1;
		data.PpSPercent = 0;
		data.GoldDuration = 8;
		data.GoldMultiplier = 1d;
		data.ResearchSpeed = 1;

		foreach ( var upgrade in GameMenu.AllUpgrades.Where( u => data.HasUpgrade( u.Ident ) ) )
		{
			upgrade.OnPurchase( data );
		}

		foreach ( var blessing in GameMenu.AllBlessings.Where( b => data.HasBlessing( b.Ident ) ) )
		{
			blessing.OnActivate( data );
		}

		return data;
	}

	public ByteStream GetDataStream()
	{
		var data = ByteStream.Create( 17 );
		data.Write( NETWORK_MESSAGE.PLAYER_UPDATE );
		data.Write( Pizzas );
		data.Write( PizzasPerSecond );

		return data;
	}

	public void ReadDataStream( ByteStream data )
	{
		Pizzas = data.Read<double>();
		PizzasPerSecond = data.Read<double>();
	}
}
