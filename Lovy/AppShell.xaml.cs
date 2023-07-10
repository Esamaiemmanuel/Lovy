using Lovy.Views;

namespace Lovy;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
		Routing.RegisterRoute(nameof(CodeVerification), typeof(CodeVerification));
		Routing.RegisterRoute(nameof(PhoneNumber), typeof(PhoneNumber));
	}
}
