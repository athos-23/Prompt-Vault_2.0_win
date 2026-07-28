using System.Collections.ObjectModel;
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
