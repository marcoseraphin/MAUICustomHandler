using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace NextMAUIApp.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        string pageTitle;
    }
}

