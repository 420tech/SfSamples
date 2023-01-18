namespace SfSamples;

public partial class App : Application
{

	private string SFLicenseKey = "insert license key here";


	public App()
	{
		Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(SFLicenseKey);
		InitializeComponent();

		MainPage = new AppShell();
	}
}
