using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPCEditor
{

    /// <summary>
    /// Gibt ein Verhältnis zum Spieler an.
    /// </summary>
    public enum PlayerRelation
    {
        ENEMY, NEUTRAL, FRIEND
    }

    /// <summary>
    /// 
    /// </summary>
    public class NPC
    {

        /// <summary>
        /// Das Verhältnis des NPCs zum Spieler.
        /// </summary>
        public PlayerRelation RelationToPlayer { get; set; }

        /// <summary>
        /// Die Klasse des NPCs
        /// </summary>
        public NPCClass Class { get; set; }

        /// <summary>
        /// Der Name des NPCs
        /// </summary>
        public string Name { get; set; }

    }

}
