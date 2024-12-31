

using Task = ListaTareas_AvilaCristina_DID.MVVM.Models.Task;
using System.Windows.Input;

namespace ListaTareas_AvilaCristina_DID.MVVM.ModelView
{
    public class NewTaskViewModel
    {
        
        public ICommand GoBackCommand => new Command(async() =>
        {
            await Shell.Current.GoToAsync("///taskView");
        });
    }
}
