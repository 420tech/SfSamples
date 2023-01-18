namespace SfSamples.Views;

public partial class MainPage : ContentPage
{
    private readonly MainViewModel viewModel;

    public MainPage(MainViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = this.viewModel = viewModel;

    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        var temp = viewModel.Orders;
        foreach (var item in temp)
        {
            Debug.WriteLine(item.Customer);
        }
    }
}
