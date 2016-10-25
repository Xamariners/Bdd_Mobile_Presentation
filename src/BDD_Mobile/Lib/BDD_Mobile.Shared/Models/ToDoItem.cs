using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using BDDMobile.Shared.Enums;
using PropertyChanged;

namespace BDDMobile.Shared.Models
{
    [DataContract]
    [ImplementPropertyChanged]
    public class TodoItem : ObjectBase
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public TodoStatus TodoStatus { get; set; }

        [DataMember]
        public DateTime? CompletionDate { get; set; }
    }
}
