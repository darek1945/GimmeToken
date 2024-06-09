using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GiveMeToken.Models;

namespace GiveMeToken.ViewModels;

public partial class AccountsViewModel : ObservableObject
{
    public ObservableCollection<Account> Accounts { get; set; } = [];

    [ObservableProperty]
    private Account? _selectedAccount;


    [RelayCommand]
    private void LoadAccounts()
    {
        
    }

    [RelayCommand]
    private void CopyToken()
    {
        if (SelectedAccount != null)
        {
            
        }
    }

    private void ShowToken()
    {
        if (SelectedAccount != null)
        {
            
        }
    }
}