using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDDMobile.Data.Fake;
using BDDMobile.Shared.Enums;
using BDDMobile.Shared.Models;
using PropertyChanged;
using Xamarin.Forms;

namespace BDDMobile.ViewModels
{
    [ImplementPropertyChanged]
    public class AddTodoItemViewModel : ViewModelBase
    {
        public string TodoName { get; set; }

        public string TodoDescription { get; set; }

        public AddTodoItemViewModel()
        {
            Initialize().Wait();
        }

        public override async Task SetViewModel()
        {
        }

        /// <summary>
        /// Add new item command
        /// </summary>
        public Command SaveNewTodoItemCommand
        {
            get
            {
                return new Command(() =>
                {
                    FakeTodoData.FakeData.Add(new TodoItem()
                    {
                        Name = TodoName,
                        Details = TodoDescription,
                        Created = DateTime.Now,
                        TodoStatus = TodoStatus.Open,
                        Id = Guid.NewGuid(),
                    });
                });
            }
        }

    }
}
