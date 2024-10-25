using Godot;

namespace MachinaLibrary;

public static class AuthManager {
    public static void Init() {}

    public static bool IsLoggedIn() {
        return false;
    }
    
    public static bool ShowLoginPrompt(out string data) {
        
        
        // Placeholder
        data = string.Empty;
        return true;
    }
}