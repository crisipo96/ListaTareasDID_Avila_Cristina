

using PropertyChanged;
using System.Windows.Input;

namespace ListaTareas_AvilaCristina_DID.MVVM.ModelView
{
    [AddINotifyPropertyChangedInterface]
    public class DetailTaskViewModel
    {
        
        public DetailTaskViewModel()
        {
        }

        public ICommand GoBackCommand => new Command(async () =>
        {
            await Shell.Current.GoToAsync("///taskView");
        });
    }

}
