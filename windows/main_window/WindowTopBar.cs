namespace Project;
using Godot;

public partial class WindowTopBar : Control {
	[ExportGroup("Buttons")]
	[Export] public Button CloseButton;
	[Export] public Button MaxButton;
	[Export] public Button MinButton;
	
	private bool following = false;
	private Vector2I? dragStartPos = null;

	public override void _Ready() {
		MinButton.Pressed += () => {
			GetWindow().Mode = Window.ModeEnum.Minimized;
		};
		MaxButton.Pressed += () => {
			GetWindow().Mode = GetWindow().Mode == Window.ModeEnum.Windowed
				? Window.ModeEnum.Maximized
				: Window.ModeEnum.Windowed;
		};
		CloseButton.Pressed += () => {
			GetTree().Quit();
		};
	}

	public override void _GuiInput(InputEvent @event) {
		if (@event is InputEventMouseButton { ButtonIndex: MouseButton.Left }) {
			following = !following;
			dragStartPos = (Vector2I) GetLocalMousePosition();
		}
	}

	public override void _Process(double delta) {
		if (following && dragStartPos is { } dragStart) {
			GetWindow().Position += ((Vector2I) GetGlobalMousePosition()) - dragStart;
		}
	}
}
