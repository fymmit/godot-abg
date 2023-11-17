using Godot;

public partial class Deathzone : Area2D
{
	private GameState _state;

	public override void _Ready()
	{
		_state = GetNode<GameState>("/root/GameState");	
	}

	private void _on_body_entered(Node2D node)
	{
		var metaList = node.GetMetaList();
		if (metaList.Contains("player"))
		{
			_state.IsGameRunning = false;
			// GD.Print("Player collision");
		}
	}
}
