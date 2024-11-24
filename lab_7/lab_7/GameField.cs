using lab_7;
using System;
using System.Collections.Generic;

public class GameField
{
    private readonly List<(int x, int y, IBall ball)> _balls = new();

    public void AddBall(int x, int y, IBall ball)
    {
        _balls.Add((x, y, ball));
    }

    public void Draw()
    {
        foreach (var (x, y, ball) in _balls)
        {
            ball.Draw(x, y);
        }
    }
}

