/* [grial-metadata] id: Grial#App.xaml version: 1.1.3 */
using UXDivers.Grial;
namespace Park3IL_Mobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
