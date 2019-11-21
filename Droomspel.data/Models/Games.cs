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
    /// Extra games
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class Games
    {
        /// <summary>
        /// id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// game points extra games
        /// </summary>
        public int GamePointsGames { get; set; }

        /// <summary>
        /// game type extra games
        /// </summary>
        public ExtraGamesLevelType GameTypeGames { get; set; }

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
