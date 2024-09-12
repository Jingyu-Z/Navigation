using BookingApp.ViewModels;

namespace BookingApp.Views;

public partial class ManageBookingsPage : ContentPage
{
    private readonly ManageBookingsPageViewModel _viewModel;

    public ManageBookingsPage(ManageBookingsPageViewModel viewModel)
	{
        InitializeComponent();

        BindingContext = viewModel;
        _viewModel = viewModel;
    }
}