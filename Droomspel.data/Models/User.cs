using Droomspel.data.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droomspel.data.Models
{
    /// <summary>
    /// User information
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class User
    {
        public User()
        {
            Abc = new HashSet<Abc>();
            Games = new HashSet<Games>();
            Math = new HashSet<Math>();
            Message = new HashSet<Message>();
            Music = new HashSet<Music>();
        }
        
        /// <summary>
        /// id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// first name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// avatar type
        /// </summary>
        public AvatarType Avatar { get; set; }

        /// <summary>
        /// avatar level unlocked
        /// </summary>
        public int AvatarLevelUnlocked { get; set; }

        /// <summary>
        /// theme type
        /// </summary>
        public ThemeType Theme { get; set; }

        /// <summary>
        /// theme level unlocked
        /// </summary>
        public int ThemeLevelUnlocked { get; set; }

        /// <summary>
        /// total game points
        /// </summary>
        public int TotalGamePoints { get; set; }

        /// <summary>
        /// collection of Abc records
        /// </summary>
        public ICollection<Abc> Abc { get; set; }

        /// <summary>
        /// collection of Games records
        /// </summary>
        public ICollection<Games> Games { get; set; }

        /// <summary>
        /// collection of Math records
        /// </summary>
        public ICollection<Math> Math { get; set; }

        /// <summary>
        /// collection of Message records
        /// </summary>
        public ICollection<Message> Message { get; set; }

        /// <summary>
        /// collection of Music records
        /// </summary>
        public ICollection<Music> Music { get; set; }
    }
}
