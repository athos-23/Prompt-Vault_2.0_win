using System.Collections.ObjectModel;
using System.Windows.Input;
using PromptVault.App.Data;
using PromptVault.App.Models;

namespace PromptVault.App.ViewModels;

public class MainViewModel
{
    private readonly VaultDatabase database;

    public ObservableCollection<Prompt> Prompts { get; }

    private Prompt? selectedPrompt;
    public Prompt? SelectedPrompt
    {
        get => selectedPrompt;
        set => selectedPrompt = value;
    }

    public ICommand NewPromptCommand { get; }

    public MainViewModel()
    {
        database = new VaultDatabase();

        Prompts = new ObservableCollection<Prompt>();

        NewPromptCommand = new RelayCommand(CreateNewPrompt);

        LoadPrompts();

        if (Prompts.Count == 0)
        {
            var firstPrompt = new Prompt
            {
                Title = "Benvenuto in Prompt Vault",
                Project = "Generale",
                Tags = "inizio, esempio",
                Content = "Questo è il tuo primo prompt salvato.",
                Color = "blue",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };

            database.AddPrompt(firstPrompt);

            Prompts.Add(firstPrompt);

            SelectedPrompt = firstPrompt;
        }
    }

    private void LoadPrompts()
    {
        Prompts.Clear();

        foreach (var prompt in database.GetPrompts())
        {
            Prompts.Add(prompt);
        }

        if (Prompts.Count > 0)
            SelectedPrompt = Prompts[0];
    }

    private void CreateNewPrompt(object? parameter)
    {
        var prompt = new Prompt
        {
            Title = "Nuovo Prompt",
            Project = "",
            Tags = "",
            Content = "",
            Color = "default",
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        };

        database.AddPrompt(prompt);

        LoadPrompts();

        SelectedPrompt = Prompts.LastOrDefault();
    }
}using System.Collections.ObjectModel;
using System.Windows.Input;
using PromptVault.App.Data;
using PromptVault.App.Models;

namespace PromptVault.App.ViewModels;

public class MainViewModel
{
    private readonly VaultDatabase database;

    public ObservableCollection<Prompt> Prompts { get; set; }

    public Prompt? SelectedPrompt { get; set; }

    public ICommand NewPromptCommand { get; }


    public MainViewModel()
    {
        database = new VaultDatabase();

        Prompts = new ObservableCollection<Prompt>();

        NewPromptCommand = new RelayCommand(CreateNewPrompt);

        LoadPrompts();


        if (Prompts.Count == 0)
        {
            var firstPrompt = new Prompt
            {
                Title = "Benvenuto in Prompt Vault",
                Project = "Generale",
                Tags = "inizio, esempio",
                Content = "Questo è il tuo primo prompt salvato.",
                Color = "blue",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };


            database.AddPrompt(firstPrompt);

            Prompts.Add(firstPrompt);
        }
    }


    private void LoadPrompts()
    {
        var items = database.GetPrompts();

        foreach (var item in items)
        {
            Prompts.Add(item);
        }
    }


    private void CreateNewPrompt(object? parameter)
    {
        var prompt = new Prompt
        {
            Title = "Nuovo Prompt",
            Project = "",
            Tags = "",
            Content = "",
            Color = "default",
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        };


        database.AddPrompt(prompt);

        Prompts.Add(prompt);

        SelectedPrompt = prompt;
    }
}using System.Collections.ObjectModel;
using PromptVault.App.Data;
using PromptVault.App.Models;

namespace PromptVault.App.ViewModels;

public class MainViewModel
{
    private readonly VaultDatabase database;

    public ObservableCollection<Prompt> Prompts { get; set; }

    public Prompt? SelectedPrompt { get; set; }

    public MainViewModel()
    {
        database = new VaultDatabase();

        Prompts = new ObservableCollection<Prompt>();

        LoadPrompts();

        if (Prompts.Count == 0)
        {
            var firstPrompt = new Prompt
            {
                Title = "Benvenuto in Prompt Vault",
                Project = "Generale",
                Tags = "inizio, esempio",
                Content = "Questo è il tuo primo prompt salvato.",
                Color = "blue",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };

            database.AddPrompt(firstPrompt);
            Prompts.Add(firstPrompt);
        }
    }


    private void LoadPrompts()
    {
        var items = database.GetPrompts();

        foreach (var item in items)
        {
            Prompts.Add(item);
        }
    }
}using System.Collections.ObjectModel;
using PromptVault.App.Data;
using PromptVault.App.Models;

namespace PromptVault.App.ViewModels;

public class MainViewModel
{
    private readonly VaultDatabase database;


    public ObservableCollection<Prompt> Prompts { get; set; }


    public Prompt? SelectedPrompt { get; set; }


    public MainViewModel()
    {
        database = new VaultDatabase();

        Prompts = new ObservableCollection<Prompt>();

        LoadPrompts();
    }


    private void LoadPrompts()
    {
        var items = database.GetPrompts();

        foreach (var item in items)
        {
            Prompts.Add(item);
        }
    }
}using System.Collections.ObjectModel;
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
