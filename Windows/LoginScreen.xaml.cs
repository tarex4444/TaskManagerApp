using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TaskManagerApp.ViewModels;

namespace TaskManagerApp.Windows
{
    /// <summary>
    /// Logika interakcji dla klasy loginscreen.xaml
    /// </summary>
    public partial class LoginScreen : Window
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void LoginButton(object sender, RoutedEventArgs e)
        {
            var MainWindow = new MainWindow()
            {
                DataContext = new TaskMainViewModel()
            };
            MainWindow.Show();
            this.Close();
        }
    }
}
