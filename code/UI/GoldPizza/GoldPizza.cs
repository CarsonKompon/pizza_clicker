using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace PizzaClicker;

[StyleSheet]
public class GoldPizza : Panel
{
    RealTimeSince Created = 0;
    float Duration = 8f;

    public GoldPizza(Vector2 pos, float duration = 8f)
    {
        Style.Top = Length.Percent(pos.y);
        Style.Left = Length.Percent(pos.x);
        Duration = duration;
    }

    public override void Tick()
    {

        if (Created > Duration)
        {
            Delete();
        }
    }

	protected override void OnMouseUp( MousePanelEvent e )
	{
		base.OnMouseUp( e );

        GameMenu.Instance.LocalPlayer?.GoldenClick(Mouse.Position * ScaleFromScreen);
        Delete(true);
	}

}
