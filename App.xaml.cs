using ListaTareas_AvilaCristina_DID.MVVM.View;

namespace ListaTareas_AvilaCristina_DID
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();
            MainPage = new NavigationPage(new TaskView());
        }
    }
}
