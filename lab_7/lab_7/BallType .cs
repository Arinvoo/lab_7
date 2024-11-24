using lab_7;
using System;

public class BallType : IBall
{
    public string Color { get; }
    public string Texture { get; }

    public BallType(string color, string texture)
    {
        Color = color;
        Texture = texture;
    }

    public void Draw(int x, int y)
    {
        Console.WriteLine($"Drawing ball of color {Color} with texture {Texture} at ({x}, {y})");
    }
}

