using Lovy.Views.Auth;
using Lovy.Views.Profile;

namespace Lovy;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
		Routing.RegisterRoute(nameof(CodeVerification), typeof(CodeVerification));
		Routing.RegisterRoute(nameof(PhoneNumber), typeof(PhoneNumber));
		Routing.RegisterRoute(nameof(AddEmailPage), typeof(AddEmailPage));
        Routing.RegisterRoute(nameof(DateOfBirthPage), typeof(DateOfBirthPage));
        Routing.RegisterRoute(nameof(GenderPage), typeof(GenderPage));
        Routing.RegisterRoute(nameof(NamePage), typeof(NamePage));
        Routing.RegisterRoute(nameof(QualitiesPage), typeof(QualitiesPage));
        Routing.RegisterRoute(nameof(RulePage), typeof(RulePage));
		Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
		Routing.RegisterRoute(nameof(AboutMePage), typeof(AboutMePage));
		Routing.RegisterRoute(nameof(EditProfilePage), typeof(EditProfilePage));
		Routing.RegisterRoute(nameof(ProfileDashboard), typeof(ProfileDashboard));
    }
}
