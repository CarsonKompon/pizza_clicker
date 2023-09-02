using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;
using System;
using System.Collections.Generic;

namespace PizzaClicker;

[StyleSheet]
public class TextParticle : Panel
{
    Vector2 Position;
    Vector2 Speed;
    RealTimeSince Created = 0;

    public TextParticle(Vector2 pos, string text, string styles = "")
    {
        Position = pos;
        Style.Top = Length.Pixels(pos.y);
        Style.Left = Length.Pixels(pos.x);

        var rand = new Random();
        Speed = new Vector2(rand.Float(-0.1f, 0.1f), -rand.Float(1f, 1.5f));

        if(!string.IsNullOrEmpty(styles)) AddClass(styles);
        Add.Label(text, "text");
    }

    public override void Tick()
    {
        Position += Speed;
        Style.Top = Length.Pixels(Position.y);
        Style.Left = Length.Pixels(Position.x);

        if (Created > 0.5f) Delete();
    }

}
