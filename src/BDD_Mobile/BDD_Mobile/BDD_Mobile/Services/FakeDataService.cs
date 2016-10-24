using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDDMobile.Data.Fake;
using BDDMobile.Shared.Models;

namespace BDDMobile.Services
{
    public class FakeDataService : IDataService
    {
        public async Task<List<TodoItem>> GetTodoItems()
        {
            await Task.Delay(TimeSpan.FromSeconds(3));
            return FakeTodoData.FakeData;
        }
    }
}
