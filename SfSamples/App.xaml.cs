namespace SfSamples;

public partial class App : Application
{

	private string SFLicenseKey = "OTY0NTEwQDMyMzAyZTM0MmUzMERkd0xtSnl3OEpmbzYrdURtMlk2ODROWmlxRkZ3UnZ2RmZVdWZxbUNsaTg9";


	public App()
	{
		Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(SFLicenseKey);
		InitializeComponent();

		MainPage = new AppShell();
	}
}
