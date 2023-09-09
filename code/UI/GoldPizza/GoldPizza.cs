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
    float Duration = 8f;
    float Opacity = 0f;
    bool fadeOut = false;

    public GoldPizza(Vector2 pos, float duration = 8f)
    {
        Style.Top = Length.Percent(pos.y);
        Style.Left = Length.Percent(pos.x);
        Duration = duration;
    }

    public override void Tick()
    {
        if(!fadeOut)
        {
            Opacity += Time.Delta / 2;
            if (Opacity >= 1f)
            {
                Opacity = 1f;
                fadeOut = true;
            }
        }
        else
        {
            if(Duration > 0f)
            {
                Duration -= Time.Delta;
            }
            else
            {
                Opacity -= Time.Delta / 5;
                if (Opacity <= 0f)
                {
                    Opacity = 0f;
                    Delete(true);
                }
            }
        }

        Style.Opacity = Opacity;
    }

	protected override void OnMouseUp( MousePanelEvent e )
	{
		base.OnMouseUp( e );

        GameMenu.Instance.LocalPlayer?.GoldenClick(Mouse.Position * ScaleFromScreen);
        Delete(true);
	}

}
