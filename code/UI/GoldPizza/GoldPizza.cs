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

    public GoldPizza(Vector2 pos)
    {
        Style.Top = Length.Percent(pos.y);
        Style.Left = Length.Percent(pos.x);
    }

    public override void Tick()
    {

        if (Created > 8f)
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
