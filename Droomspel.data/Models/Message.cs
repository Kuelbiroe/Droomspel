using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droomspel.data.Models
{
    /// <summary>
    /// Messages
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class Message
    {
        /// <summary>
        /// id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// userId
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// user
        /// </summary>
        public virtual User User { get; set; }
    }
}
