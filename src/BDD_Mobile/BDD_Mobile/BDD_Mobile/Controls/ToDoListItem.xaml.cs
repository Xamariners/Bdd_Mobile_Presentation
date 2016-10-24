using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace BDDMobile.Controls
{
    public partial class TodoListItem : Grid
    {
        public TodoListItem()
        {
            try
            {
                InitializeComponent();
            }
            catch (InvalidOperationException soe)
            {
                if (!soe.Message.Contains("MUST"))
                    throw;
            }
        }
    }
}
