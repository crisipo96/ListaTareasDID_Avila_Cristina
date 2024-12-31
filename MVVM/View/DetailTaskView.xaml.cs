
namespace ListaTareas_AvilaCristina_DID.MVVM.View;
using ListaTareas_AvilaCristina_DID.MVVM.Models;


public partial class DetailTaskView : ContentPage
{
  public Task  Task { get; set; }
    
    public DetailTaskView(Task task)
    {
        Task = task;
    }
}