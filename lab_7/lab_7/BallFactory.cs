using System.Collections.Generic;

public class BallFactory
{
    private readonly Dictionary<string, BallType> _ballTypes = new();

    public BallType GetBallType(string color, string texture)
    {
        string key = $"{color}-{texture}";
        if (!_ballTypes.ContainsKey(key))
        {
            _ballTypes[key] = new BallType(color, texture);
        }
        return _ballTypes[key];
    }
}
