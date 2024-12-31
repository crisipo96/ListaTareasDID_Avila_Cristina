
namespace ListaTareas_AvilaCristina_DID.Selectors;
using ListaTareas_AvilaCristina_DID.MVVM.Models;
using Microsoft.Maui.Controls;

    class TaskDataTemplateSelector : DataTemplateSelector
    {
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            Task? task = item as Task;

            if(task != null)
            {
            //Se comprueba la prioridad de cada tarea y una vez comprobada se mira si está o no completada. 
            //Dependiendo de cada prioridad y de cada status se aplica un stilo diferente
            if (task.Priority.Equals("alta"))
                {
                    if (task.Status)
                    {
                        Application.Current!.Resources.TryGetValue("CompletedHighPriorityTask", out object CompletedHighdataTemplate);
                        return CompletedHighdataTemplate as DataTemplate ?? new DataTemplate();
                    }
                    Application.Current!.Resources.TryGetValue("HighPriorityTask", out object HighdataTemplate);
                    return HighdataTemplate as DataTemplate ?? new DataTemplate();

                }
            
                else if (task.Priority.Equals("media"))
                {
                    if (task.Status)
                    {
                        Application.Current!.Resources.TryGetValue("CompletedMediumPriorityTask", out object CompletedMediumdataTemplate);
                        return CompletedMediumdataTemplate as DataTemplate ?? new DataTemplate();
                    }
                    
                    Application.Current!.Resources.TryGetValue("MediumPriorityTask", out object MediumdataTemplate);
                    return MediumdataTemplate as DataTemplate ?? new DataTemplate();
                }
                else
                {
                    if (task.Status)
                    {
                        Application.Current!.Resources.TryGetValue("CompletedLowPriorityTask", out object CompletedLowdataTemplate);
                        return CompletedLowdataTemplate as DataTemplate ?? new DataTemplate();
                    }
                    Application.Current!.Resources.TryGetValue("LowPriorityTask", out object LowdataTemplate);
                    return LowdataTemplate as DataTemplate ?? new DataTemplate();
                }

            }

            return new DataTemplate();
        }
    }

