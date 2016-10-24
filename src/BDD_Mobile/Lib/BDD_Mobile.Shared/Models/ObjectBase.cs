using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BDDMobile.Shared.Models
{
    [DataContract]
    public class ObjectBase
    {
        /// <summary>
        ///     Gets or sets object id.
        /// </summary>
        /// <value>
        ///     From object  id.
        /// </value>
        [DataMember]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the created.
        /// </summary>
        [DataMember]
        public DateTime Created { get; set; }

        /// <summary>
        /// Gets or sets the updated.
        /// </summary>
        [DataMember]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MDAObject"/> class.
        /// </summary>
        public ObjectBase()
        {
            this.Id = Guid.NewGuid();
            this.Created = DateTime.UtcNow;
        }

    }
}
