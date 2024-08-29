using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TaskManagerApp.ViewModels
{
    public class TaskViewModel
    {
        public string Title { get; }

        public ICommand SeeMore { get; }

        public TaskViewModel(string taskTitle)
        {
            Title = taskTitle;
        }
    }
}
