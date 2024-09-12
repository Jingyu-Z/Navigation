using BookingApp.ViewModels;

namespace BookingApp.Views;

public partial class OpeningPage : ContentPage
{
    private readonly OpeningPageViewModel _viewModel;

    public OpeningPage(OpeningPageViewModel viewModel)
	{
        InitializeComponent();

        BindingContext = viewModel;
        _viewModel = viewModel;
    }
}