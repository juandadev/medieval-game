using Godot;
using System;

public partial class Sprite2d : Sprite2D
{
	public override void _Process(double delta)
	{
		float amount = 1;
		
		if (Input.IsKeyPressed(Key.W))
		{
			Position += new Vector2(0, -amount);
		}
		if (Input.IsKeyPressed(Key.S))
		{
			Position += new Vector2(0, amount);
		}
		if (Input.IsKeyPressed(Key.A))
		{
			Position += new Vector2(-amount, 0);
		}
		if (Input.IsKeyPressed(Key.D))
		{
			Position += new Vector2(amount, 0);
		}
	}
}
