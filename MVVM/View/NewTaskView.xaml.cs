namespace ListaTareas_AvilaCristina_DID.MVVM.View;
using ListaTareas_AvilaCristina_DID.MVVM.ModelView;
public partial class NewTaskView : ContentView
{
	public NewTaskView()
	{
		InitializeComponent();
		BindingContext = new NewTaskViewModel();
	}
}