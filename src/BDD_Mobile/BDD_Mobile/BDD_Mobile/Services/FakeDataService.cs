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
        public List<TodoItem> GetTodoItems()
        {
            return FakeTodoData.FakeData;
        }
    }
}
