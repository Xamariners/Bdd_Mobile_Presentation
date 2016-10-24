using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDDMobile.Shared.Enums;
using BDDMobile.Controls;
using BDDMobile.Services;
using BDDMobile.Shared.Helpers;
using BDDMobile.Shared.Models;
using Prism.Navigation;
using PropertyChanged;
using Xamarin.Forms;

namespace BDDMobile.ViewModels
{
    [ImplementPropertyChanged]
    public class TodoItemDetailViewModel : ViewModelBase
    {
        public TodoItem TodoItem { get; set; }


        public TodoItemDetailViewModel()
        {
            Initialize().Wait();
        }

        public override async Task SetViewModel()
        {
          
        }

        public override void OnNavigatedTo(NavigationParameters parameters)
        {
            TodoItem = (TodoItem) parameters[nameof(TodoItem).FirstLetterToLower()];
            base.OnNavigatedTo(parameters);
        }

        public Command TodoStatusUpdateCommand
        {
            get
            {
                return new Command((statupsUpdateValue) =>
                {
                    TodoItem.TodoStatus = (TodoStatus)Enum.Parse(typeof(TodoStatus), (string)statupsUpdateValue);
                });
            }
        }
    }
}