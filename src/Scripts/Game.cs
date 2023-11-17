using Godot;
using System;

public partial class Game : Node
{
	private GameState _state;
	private Label _timerLabel;
	private Label _gameOverLabel;
	private decimal _timer = 0;
	
	public override void _Ready()
	{
		_state = GetNode<GameState>("/root/GameState");
		_timerLabel = GetNode<Label>("TimerLabel");
		_gameOverLabel = GetNode<Label>("GameOverLabel");
	}

	public override void _Process(double delta)
	{
		if (Input.IsKeyPressed(Key.R))
		{
			Reset();	
		}
		if (_state.IsGameRunning)
		{
			_timer += (decimal)delta;
			_timerLabel.Text = $"Timer: {decimal.Round(_timer, 2)}";
		}
		else
		{
			_gameOverLabel.Visible = true;
		}
	}

	private void Reset()
	{
		_state.IsGameRunning = true;
		GetTree().ReloadCurrentScene();
		// _gameOverLabel.Visible = false;
		// _timer = 0;
	}
}
