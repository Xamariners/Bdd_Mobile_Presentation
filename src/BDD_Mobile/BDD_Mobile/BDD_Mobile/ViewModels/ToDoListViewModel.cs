using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BDDMobile.Annotations;
using BDDMobile.Controls;
using BDDMobile.Data.Fake;
using BDDMobile.Pages;
using BDDMobile.Services;
using BDDMobile.Shared.Models;
using Prism.Navigation;
using PropertyChanged;
using SpecFlow.XForms.IViewModel;
using Xamarin.Forms;

namespace BDDMobile.ViewModels
{
    [ImplementPropertyChanged]
    public class TodoListViewModel : ViewModelBase
    {
        public List<TodoItem> TodoItems { get; set; }

        private TodoItem _selectedTodoItem;

        private readonly IDataService _dataService;
        private readonly INavigationService _navigationService;

        public TodoListViewModel(INavigationService navigationService, IDataService dataService)
        {
            _dataService = dataService;
            _navigationService = navigationService;

            Initialize().Wait();
        }

        public override async Task SetViewModel()
        {
            TodoItems = await _dataService.GetTodoItems();
        }

        public TodoItem SelectedTodoItem
        {
            get { return _selectedTodoItem; }
            set
            {
                _selectedTodoItem = value;

                if (value != null)
                    TodoItemSelectedCommand.Execute(value);
            }
        }

        public Command<TodoItem> TodoItemSelectedCommand
        { 
            get
            {
                return new Command<TodoItem>(async (todoItem) =>
                {
                    var parameters = new NavigationParameters {{nameof(todoItem), todoItem}};
                    await _navigationService.NavigateAsync(nameof(TodoItemDetailPage), parameters);
                });
            }
        }

        public Command AddNewTodoItemCommand
        {
            get
            {
                return new Command(async () =>
                {
                    await _navigationService.NavigateAsync(nameof(AddTodoItemPage));
                });
            }
        }
    } 
}