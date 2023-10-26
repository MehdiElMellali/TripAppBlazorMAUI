namespace TripApp;

public partial class App : Application
{
    public readonly SeedDataService _seedDataServic;

    public App(SeedDataService seedDataService)
	{
		InitializeComponent();

		MainPage = new MainPage();
        _seedDataServic = seedDataService;
    }

    protected override async void OnStart()
    {
        base.OnStart();
        await  _seedDataServic.SeedDataAsync();
    }
}
