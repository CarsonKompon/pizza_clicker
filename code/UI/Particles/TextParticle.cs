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
    float Len = 0.5f;
    RealTimeSince Created = 0;

    public static int ParticleCount = 0;

    public TextParticle(Vector2 pos, string text, string styles = "", bool manual = false, float length = 0.5f)
    {
        if(!manual)
        {
            if(ParticleCount > 50)
            {
                Delete();
                return;
            }
            else ParticleCount++;
        }

        Manual = manual;
        Position = pos;
        Style.Top = Length.Pixels(pos.y);
        Style.Left = Length.Pixels(pos.x);
        Len = length;

        var rand = new Random();
        Speed = new Vector2(rand.Float(-1f, 1f), -rand.Float(100f, 150f));

        if(!string.IsNullOrEmpty(styles)) AddClass(styles);
        Add.Label(text, "text");
    }

    public override void Tick()
    {
        Position += Speed * Time.Delta;
        Style.Top = Length.Pixels(Position.y);
        Style.Left = Length.Pixels(Position.x);

        if (Created > Len)
        {
            Delete();
            if(!Manual) ParticleCount--;
        }
    }

}
