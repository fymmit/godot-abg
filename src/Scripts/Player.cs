using Godot;
using System;

public partial class Player : CharacterBody2D
{
	private GameState _state;
	public const float Speed = 250.0f;

    public override void _Ready()
    {
		_state = GetNode<GameState>("/root/GameState"); 
    }
    public override void _PhysicsProcess(double delta)
	{
		if (_state.IsGameRunning)
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
}
