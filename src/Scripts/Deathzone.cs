using Godot;

public partial class Deathzone : Area2D
{
	private void _on_body_entered(Node2D node)
	{
		var metaList = node.GetMetaList();
		if (metaList.Contains("player"))
		{
			GD.Print("Player collision");
		}
	}
}
