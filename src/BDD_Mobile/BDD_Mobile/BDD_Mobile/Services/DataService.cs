using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDDMobile.Shared.Models;

namespace BDDMobile.Services
{
    public class DataService : IDataService
    {
        public Task<List<TodoItem>> GetTodoItems()
        {
            throw new NotImplementedException();
        }
    }
}
