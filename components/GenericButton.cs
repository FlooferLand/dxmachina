namespace Project.Components;
using Godot;

[Tool]
public partial class GenericButton : MarginContainer {
	public Button Button;
	public string InternalLabel = "Button";
	
	[Export]
	public string Label {
		get => InternalLabel;
		set {
			InternalLabel = value;
			if (Button != null) Button.Text = value;
		}
	}
	
	public override void _Ready() {
		Button = GetNode<Button>("Button");
	}
}
