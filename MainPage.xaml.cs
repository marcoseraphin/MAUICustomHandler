using NextMAUIApp.ViewModels;

namespace NextMAUIApp;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage(MainPageModel viewModel)
    {
        InitializeComponent();
        this.BindingContext = viewModel;
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;
        CounterLabel.Text = $"Current count: {count}";

        SemanticScreenReader.Announce(CounterLabel.Text);
    }
}

