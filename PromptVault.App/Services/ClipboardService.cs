namespace PromptVault.App.Services;

public class ClipboardService
{
    public void Copy(string text)
    {
        Clipboard.SetText(text);
    }
}
