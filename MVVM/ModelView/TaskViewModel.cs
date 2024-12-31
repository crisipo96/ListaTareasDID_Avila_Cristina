
using ListaTareas_AvilaCristina_DID.MVVM.View;

using PropertyChanged;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Task = ListaTareas_AvilaCristina_DID.MVVM.Models.Task;

namespace ListaTareas_AvilaCristina_DID.MVVM.ModelView
{
    //Se implementa esta interface para poder cambiar valores en el código(añadiendo el paquete de FodyPropertyChanged)
    [AddINotifyPropertyChangedInterface]
    public class TaskViewModel
    {

        public TaskViewModel()
        {
        }

        //lista de tareas
        public ObservableCollection<Task> Tasks { get; set; } = new ObservableCollection<Task>
        {
            new Task
            {
                Name = "Limpiar habitación",
                Status = true,
                Priority = "media"
            },
              new Task
            {
                Name = "Médico 12h",
                Status = true,
                Priority = "alta"
            },
                new Task
            {
                Name = "Recoger compra",
                Status = true,
                Priority = "media"
            },
            new Task
            {
                Name = "llamar Laura",
                Status = false,
                Priority = "baja"
            },
             new Task
            {
                Name = "Pagar cena empresa",
                Status = false,
                Priority = "alta"
            },
             new Task
            {
                Name = "Examen DID",
                Status = false,
                Priority = "media"
            },
             new Task
            {
                Name = "acabar de ver clase AD",
                Status = false,
                Priority = "baja"
            },
             new Task
            {
                Name = "llamar instituto",
                Status = false,
                Priority = "alta"
            },
             new Task
            {
                Name = "recoger Hugo colegio",
                Status = true,
                Priority = "alta"
            },
             new Task
            {
                Name = "buscar llaves cochera",
                Status = true,
                Priority = "media"
            },
             new Task
            {
                Name = "Examen SGE",
                Status = true,
                Priority = "media"
            },

             new Task
            {
                Name = "comprar regalo Rubén",
                Status = true,
                Priority = "baja"
            }
        };


        //Metodo para borrar una tarea cuando hacemos click en el boton del icono de la papelera
        public ICommand DeletedCommand => new Command((t) =>
        {
            Task? task = t as Task;
            Tasks.Remove(task!);
        });

        //Metodo para navegar a la segunda pantalla (en el AppShell se ha añadido la ruta de navegacion)
        /*  public ICommand ShowDetailsCommand => new Command(async () =>
           {
               if (Shell.Current != null)
               {
                   await Shell.Current.GoToAsync("///detailTask");
               }
               else
               {
                   Console.WriteLine("Shell.Current nulo");
               }


           });*/

        //Metodo para navegar a la pantalla detalle
        public ICommand ShowDetailsCommand => new Command(async (t) =>
         {
            await Application.Current!.MainPage!.Navigation.PushAsync(new DetailTaskView(SelectedTask!));

         });

       
        public Task? SelectedTask
        {
            get => SelectedTask;

            set
            {
                SelectedTask = value;
            }
        }

        public ICommand SelectionChangedCommand => new Command(() =>
        {
            var product = SelectedTask;
        });






    }
}
