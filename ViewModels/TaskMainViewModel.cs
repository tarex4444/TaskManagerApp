using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TaskManagerApp.ViewModels
{
    public class TaskMainViewModel : ViewModelBase
    {
        public TaskDetailedDescriptionViewModel TaskDetailedDescriptionViewModel { get; }
        public TasksListingViewModel TasksListingViewModel { get; }
        public ICommand AddTask { get; }
        public ICommand Logout {get; }
        public TaskMainViewModel()
        {
            TaskDetailedDescriptionViewModel = new TaskDetailedDescriptionViewModel();
            TasksListingViewModel = new TasksListingViewModel();
        }
    }
}
