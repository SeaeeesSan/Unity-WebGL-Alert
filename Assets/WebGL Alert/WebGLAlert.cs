using System.Runtime.InteropServices;

public static class WebGLAlert
{
    [DllImport("__Internal")]
    private static extern void Alert(string message);
    
    [DllImport("__Internal")]
    private static extern string Prompt(string message);
    
    [DllImport("__Internal")]
    private static extern bool Confirm(string message);

    /// <summary>
    /// ShowAlert
    /// </summary>
    /// <param name="message"></param>
    public static void ShowAlert(string message)
    { 
        Alert(message);
    }
    
    /// <summary>
    /// ShowConfirm
    /// </summary>
    /// <param name="message"></param>
    /// <returns></returns>
    public static bool ShowConfirm(string message)
    { 
        return Confirm(message);
    }
    
    /// <summary>
    /// ShowPrompt
    /// </summary>
    /// <param name="message"></param>
    /// <returns></returns>
    public static string ShowPrompt(string message)
    { 
        return Prompt(message);
    }
}
