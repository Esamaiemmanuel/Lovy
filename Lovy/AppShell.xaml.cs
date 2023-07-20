using Lovy.Views.Auth;
using Lovy.Views.Profile;

namespace Lovy;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
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
        Routing.RegisterRoute(nameof(StudyPage), typeof(StudyPage));
        Routing.RegisterRoute(nameof(IntoPage), typeof(IntoPage));
        Routing.RegisterRoute(nameof(RecentPicPage), typeof(RecentPicPage));
        Routing.RegisterRoute(nameof(LocationPage), typeof(LocationPage));
        Routing.RegisterRoute(nameof(AvoidPage), typeof(AvoidPage));
        Routing.RegisterRoute(nameof(ContactPage), typeof(ContactPage));
        Routing.RegisterRoute(nameof(PhoneCodePage), typeof(PhoneCodePage));
        Routing.RegisterRoute(nameof(EmailPage), typeof(EmailPage));
    }
}
