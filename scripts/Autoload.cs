using MachinaLibrary;
using Project.Components;

namespace Project;
using Godot;

public partial class Autoload : Node {
	public static AuthPrompt Prompt;
	
	public override void _Ready() {
		Prompt = GD.Load<AuthPrompt>("uid://cwfwld75844tt");
		
		AuthManager.Init();
		if (AuthManager.ShowLoginPrompt(out string data)) {
			
		}
	}
}
