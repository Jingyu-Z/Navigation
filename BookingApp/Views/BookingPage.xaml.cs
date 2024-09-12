using BookingApp.ViewModels;

namespace BookingApp.Views;

public partial class BookingPage : ContentPage
{
    private readonly BookingPageViewModel _viewModel;

    public BookingPage(BookingPageViewModel viewModel)
	{
        InitializeComponent();

        BindingContext = viewModel;
        _viewModel = viewModel;
    }
}