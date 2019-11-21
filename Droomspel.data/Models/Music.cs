using Droomspel.data.Models.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droomspel.data.Models
{
    /// <summary>
    /// Music games
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class Music
    {
        /// <summary>
        /// id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// game points music
        /// </summary>
        public int GamePointsMusic { get; set; }

        /// <summary>
        /// game type music
        /// </summary>
        public MusicLevelType GameTypeMusic { get; set; }

        /// <summary>
        /// game difficulty unlocked
        /// </summary>
        public DifficultyType DifficultyUnlocked { get; set; }

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
