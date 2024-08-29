using System.Collections.ObjectModel;

namespace TaskManagerApp.ViewModels
{
    public class TasksListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<TaskViewModel> _tasks;
        public IEnumerable<TaskViewModel> TasksList => _tasks;

        public TasksListingViewModel()
        {
            _tasks = new ObservableCollection<TaskViewModel>();

            _tasks.Add(new TaskViewModel("Zrobic projekt"));
            _tasks.Add(new TaskViewModel("Wypic herbate"));
            _tasks.Add(new TaskViewModel("Zjesc obiad"));
        }
    }
}
