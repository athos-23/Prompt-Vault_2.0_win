using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PromptVault.App.Models;

public class Prompt : INotifyPropertyChanged
{
    public int Id { get; set; }

    private string title = "";
    public string Title
    {
        get => title;
        set { title = value; OnPropertyChanged(); }
    }


    private string project = "";
    public string Project
    {
        get => project;
        set { project = value; OnPropertyChanged(); }
    }


    private string tags = "";
    public string Tags
    {
        get => tags;
        set { tags = value; OnPropertyChanged(); }
    }


    private string content = "";
    public string Content
    {
        get => content;
        set { content = value; OnPropertyChanged(); }
    }


    public string Color { get; set; } = "default";

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }


    public event PropertyChangedEventHandler? PropertyChanged;


    private void OnPropertyChanged(
        [CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(
            this,
            new PropertyChangedEventArgs(propertyName));
    }
}
