using Foundation;

namespace App1.Client;

using SQLitePCL;

[Register(nameof(AppDelegate))]
public class AppDelegate : MauiUIApplicationDelegate
{
	protected override MauiApp CreateMauiApp()
	{
		raw.SetProvider(new SQLite3Provider_sqlite3());
		return MauiProgram.CreateMauiApp();
	}
}