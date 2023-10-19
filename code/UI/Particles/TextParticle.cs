using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;
using System;

namespace PizzaClicker;

[StyleSheet]
public class TextParticle : Panel
{
	private readonly bool Manual;
	private readonly float Len;

	private Vector2 Position;
	private Vector2 Speed;
	RealTimeSince Created = 0;

	private static int ParticleCount = 0;

	public TextParticle( Vector2 pos, string text, string styles = "", bool manual = false, float length = 0.5f )
	{
		if ( !manual )
		{
			if ( ParticleCount > 50 )
			{
				Delete();

				return;
			}

			++ParticleCount;
		}

		Manual = manual;
		Position = pos;
		Style.Top = Length.Pixels( pos.y );
		Style.Left = Length.Pixels( pos.x );
		Len = length;

		Random rand = new();

		Speed = new( rand.Float( -1f, 1f ), -rand.Float( 100f, 150f ) );

		if ( !string.IsNullOrEmpty( styles ) )
		{
			AddClass( styles );
		}

		Add.Label( text, "text" );
	}

	public override void Tick()
	{
		Position += Speed * Time.Delta;

		Style.Top = Length.Pixels( Position.y );
		Style.Left = Length.Pixels( Position.x );

		if ( Created > Len )
		{
			Delete();

			if ( !Manual )
			{
				--ParticleCount;
			}
		}
	}
}
