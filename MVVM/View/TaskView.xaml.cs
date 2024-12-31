using ListaTareas_AvilaCristina_DID.MVVM.ModelView;

namespace ListaTareas_AvilaCristina_DID.MVVM.View;

public partial class TaskView : ContentPage
{
	public TaskView()
	{
		InitializeComponent();
        BindingContext = new TaskViewModel();
	}


}