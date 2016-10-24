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
    public class AddTodoItemPageViewModel : ViewModelBase
    {
        public string TodoName { get; set; }

        public string TodoDescription { get; set; }

        public AddTodoItemPageViewModel()
        {
            Initialize();
        }

        public override void SetViewModel()
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
