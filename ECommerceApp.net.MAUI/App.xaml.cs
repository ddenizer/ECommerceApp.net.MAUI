using ECommerceApp.net.MAUI.Pages;

namespace ECommerceApp.net.MAUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new SignupPage();
        }
    }
}
