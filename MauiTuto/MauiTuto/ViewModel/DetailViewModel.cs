using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiTuto.ViewModel;

[QueryProperty("Text","Text")] //queryId est le nom qu'il y a dans l'url
public partial class DetailViewModel : ObservableObject
{
    [ObservableProperty]
    private string text;

    [RelayCommand]
    async Task GoBack()
    {
        await Shell.Current.GoToAsync("..");
    }
}