using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NPCEditor
{
    /// <summary>
    /// Interaction logic for NPCEditorControl.xaml
    /// </summary>
    public partial class NPCEditorControl : UserControl, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public bool EditingEnabled
        {
            get
            {
                return m_npc != null;
            }
        }

        /// <summary>
        /// Der zu bearbeitende NPC
        /// </summary>
        public NPC NPC
        {
            get
            {
                return m_npc;
            }
            set
            {
                m_npc = value;
                
                RaisePropertyChangedEvent();
                RaisePropertyChangedEvent("EditingEnabled");
            }
        }

        private NPC m_npc;

        public NPCEditorControl()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NPC.Name = "Test";
        }

        private void RaisePropertyChangedEvent([CallerMemberName] string _propName = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(_propName));
        }

    }
}
