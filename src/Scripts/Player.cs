using Godot;
using System;

public partial class Player : CharacterBody2D
{
	public const float Speed = 250.0f;

	public override void _PhysicsProcess(double delta)
	{
		Vector2 velocity = Vector2.Zero;

		Vector2 direction = Input.GetVector("ui_left", "ui_right", "ui_up", "ui_down");
		if (direction != Vector2.Zero)
		{
			velocity = direction * Speed;
		}

		Velocity = velocity;
		MoveAndSlide();
	}
}
