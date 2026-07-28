using System.Collections.ObjectModel;
using PromptVault.App.Models;

namespace PromptVault.App.ViewModels;

public class MainViewModel
{
    public ObservableCollection<Prompt> Prompts { get; set; }

    public Prompt? SelectedPrompt { get; set; }

    public MainViewModel()
    {
        Prompts = new ObservableCollection<Prompt>();

        Prompts.Add(new Prompt
        {
            Id = 1,
            Title = "Prompt di esempio",
            Project = "Test",
            Tags = "AI, esempio",
            Content = "Questo è il primo prompt del tuo Prompt Vault.",
            Color = "blue",
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        });
    }
}using System.Collections.ObjectModel;
using PromptVault.App.Models;

namespace PromptVault.App.ViewModels;

public class MainViewModel
{
    public ObservableCollection<Prompt> Prompts { get; set; }

    public MainViewModel()
    {
        Prompts = new ObservableCollection<Prompt>();
    }
}
