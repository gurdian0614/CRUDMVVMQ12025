using CRUDMVVMQ12025.Views;

namespace CRUDMVVMQ12025
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainView());
        }
    }
}
