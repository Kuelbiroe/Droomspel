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
    /// Math games
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class Math
    {
        /// <summary>
        /// id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// game points Math
        /// </summary>
        public int GamePointsMath { get; set; }

        /// <summary>
        /// game type Math
        /// </summary>
        public MathLevelType GameTypeMath { get; set; }

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
