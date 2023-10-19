using Sandbox;
using Sandbox.UI;

namespace PizzaClicker;

[StyleSheet]
public class GoldPizza : Panel
{
	private Player _player;
	private float _duration = 8f;
	private float _opacity = 0f;
	private bool _fadeOut = false;

	public GoldPizza( Player player, Vector2 pos, float duration = 8f )
	{
		_player = player;
		_duration = duration;

		Style.Top = Length.Percent( pos.y );
		Style.Left = Length.Percent( pos.x );
	}

	public override void Tick()
	{
		if ( !_fadeOut )
		{
			_opacity += Time.Delta / 2;

			if ( _opacity >= 1f )
			{
				_opacity = 1f;
				_fadeOut = true;
			}
		}
		else
		{
			if ( _duration > 0f )
			{
				_duration -= Time.Delta;
			}
			else
			{
				_opacity -= Time.Delta / 5;

				if ( _opacity <= 0f )
				{
					_opacity = 0f;

					Delete( true );
				}
			}
		}

		Style.Opacity = _opacity;
	}

	protected override void OnMouseUp( MousePanelEvent e )
	{
		base.OnMouseUp( e );

		_player.GoldenClick( Mouse.Position * ScaleFromScreen );

		Delete( true );
	}
}
