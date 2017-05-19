using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
    public class NPC : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

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
        public string Name
        {
            get
            {
                return m_name;
            }
            set
            {
                m_name = value;
                RaisePropertyChangedEvent();
            }
        }

        private string m_name;
        
        private void RaisePropertyChangedEvent([CallerMemberName] string _propName = "")
        {
            if(PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(_propName));
        }

    }

}
