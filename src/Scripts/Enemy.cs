using Godot;
using System;

public partial class Enemy : CharacterBody2D
{
	[Export]
	public Vector2 InitialDirection = Vector2.Zero;
	public const float Speed = 300.0f;
	private Vector2 _velocity;

    public override void _Ready()
    {
        _velocity = InitialDirection * Speed;
    }

    public override void _PhysicsProcess(double delta)
	{
		var collision = MoveAndCollide(_velocity * (float)delta);
		if (collision != null)
		{
			_velocity = collision.GetNormal() * Speed;
		}
	}
}
