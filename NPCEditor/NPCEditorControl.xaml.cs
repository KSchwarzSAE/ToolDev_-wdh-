using System;
using System.Collections.Generic;
using System.Linq;
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
    public partial class NPCEditorControl : UserControl
    {

        /// <summary>
        /// Der zu bearbeitende NPC
        /// </summary>
        public NPC NPC { get; set; }

        public NPCEditorControl()
        {
            InitializeComponent();
        }

    }
}
