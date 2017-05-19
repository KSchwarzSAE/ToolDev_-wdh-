using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private ObservableCollection<NPC> m_npcList;

        private NPC Test(string _name)
        {
            NPC npc = new NPC();
            npc.Name = _name;
            return npc;
        }

        public MainWindow()
        {
            m_npcList = new ObservableCollection<NPC>();
            m_npcList.Add(Test("1"));
            m_npcList.Add(Test("2"));
            m_npcList.Add(Test("3"));

            InitializeComponent();

            npcListBox.ItemsSource = m_npcList;
        }

        private void npcListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            npcEditor.NPC = npcListBox.SelectedItem as NPC;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            m_npcList.Clear();
        }
    }
}
