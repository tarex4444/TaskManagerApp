using System.Configuration;
using System.Data;
using System.Windows;
using TaskManagerApp.Windows;

namespace TaskManagerApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var LoginScreen = new LoginScreen();
            LoginScreen.Show();
            base.OnStartup(e);
        }
    }
    

}
