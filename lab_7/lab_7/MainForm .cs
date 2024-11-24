using System;
using System.Drawing;
using System.Windows.Forms;

public partial class MainForm : Form
{
    private const int CellSize = 50;
    private const int GridSize = 10;
    private readonly BallFactory _ballFactory = new();
    private readonly GameField _gameField = new();
    private readonly Random _random = new();

    public MainForm()
    {
        InitializeComponent();
        GenerateGameField();
    }

    private void GenerateGameField()
    {
        var colors = new[] { "Red", "Blue", "Green", "Yellow", "Purple" };
        var textures = new[] { "Smooth", "Rough", "Glossy", "Matte", "Metallic" };

        for (int i = 0; i < GridSize; i++)
        {
            for (int j = 0; j < GridSize; j++)
            {
                string color = colors[_random.Next(colors.Length)];
                string texture = textures[_random.Next(textures.Length)];
                var ball = _ballFactory.GetBallType(color, texture);

                _gameField.AddBall(i, j, ball);
            }
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        DrawGameField(e.Graphics);
    }

    private void DrawGameField(Graphics g)
    {
        foreach (var (x, y, ball) in _gameField.GetBalls())
        {
            Brush brush = new SolidBrush(Color.FromName(ball.Color));
            g.FillEllipse(brush, x * CellSize, y * CellSize, CellSize, CellSize);
        }
    }
}

