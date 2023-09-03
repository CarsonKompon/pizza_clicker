using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace PizzaClicker;

[StyleSheet]
public class TextParticle : Panel
{
    bool Manual;
    Vector2 Position;
    Vector2 Speed;
    RealTimeSince Created = 0;

    public static int ParticleCount = 0;

    public TextParticle(Vector2 pos, string text, string styles = "", bool manual = false)
    {
        Manual = manual;
        Position = pos;
        Style.Top = Length.Pixels(pos.y);
        Style.Left = Length.Pixels(pos.x);

        var rand = new Random();
        Speed = new Vector2(rand.Float(-1f, 1f), -rand.Float(100f, 150f));

        if(!string.IsNullOrEmpty(styles)) AddClass(styles);
        Add.Label(text, "text");

        if(!manual)
        {
            if(ParticleCount > 100) Delete();
            else ParticleCount++;
        }
    }

    public override void Tick()
    {
        Position += Speed * Time.Delta;
        Style.Top = Length.Pixels(Position.y);
        Style.Left = Length.Pixels(Position.x);

        if (Created > 0.5f)
        {
            Delete();
            if(!Manual) ParticleCount--;
        }
    }

}
