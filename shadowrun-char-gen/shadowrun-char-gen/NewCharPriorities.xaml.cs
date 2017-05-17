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
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace shadowrun_char_gen
{
    /// <summary>
    /// Interaction logic for NewCharPriorities.xaml
    /// </summary>
    public partial class NewCharPriorities : Window
    {

        public ObservableCollection<PriorityItem> Priorities { get; private set; } = new ObservableCollection<PriorityItem>();
        public List<Race> RaceList = new List<Race>();
        
        public NewCharPriorities()
        {
            InitializeComponent();       

            Priorities.Add(new PriorityItem('A', "Metatype"));
            Priorities.Add(new PriorityItem('B', "Attribute"));
            Priorities.Add(new PriorityItem('C', "Magic"));
            Priorities.Add(new PriorityItem('D', "Skills"));
            Priorities.Add(new PriorityItem('E', "Resources"));

            ItemsPriority.ItemsSource = Priorities;
            Priorities.CollectionChanged += PrioritiesCollectionChanged;

            RaceList.Add(new Race("Dwarf", 8, 6, 5, 8, 7, 6, 6, 6, 7, 6, 6));
            RaceList.Add(new Race("Elf", 6, 7, 6, 6, 6, 6, 6, 8, 6, 6, 6));
            RaceList.Add(new Race("Human", 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6));
            RaceList.Add(new Race("Ork", 9, 6, 6, 8, 6, 5, 6, 5, 6, 6, 6));
            RaceList.Add(new Race("Troll", 10, 5, 6, 10, 6, 5, 5, 4, 6, 6, 6));

            listBoxRace.ItemsSource = RaceList;
            listBoxRace.SelectedIndex = 0;
        }

        private void PrioritiesCollectionChanged(object sender, NotifyCollectionChangedEventArgs e) {
            int i = 'A';
            
                foreach (PriorityItem p in Priorities) { 
                    p.Index = (char)i;
                    i++;
                }
        }
        private void Button_Click_OK(object sender, RoutedEventArgs e) {
            DialogResult = true;
        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e) {
            DialogResult = false;
        }

        private void upButtonPriority_Click(object sender, RoutedEventArgs e) {;
            PriorityItem p = (PriorityItem)((Button)sender).DataContext;
            int listIndex;

            if(p == null) {
                return;
            }

            listIndex = Priorities.IndexOf(p);
            if(listIndex > 0) {
                Priorities.Move(listIndex, listIndex - 1);
            }
        }

        private void downButtonPriority_Click(object sender, RoutedEventArgs e) {
            PriorityItem p = (PriorityItem)((Button)sender).DataContext;
            int listIndex;

            if (p == null) {
                return;
            }

            listIndex = Priorities.IndexOf(p);
            if (listIndex < Priorities.Count-1) {
                Priorities.Move(listIndex, listIndex + 1);
            }
        }

        private void listBoxRace_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            Race r = (Race)((ListBox)sender).SelectedItem;

            if(r == null) {
                return;
            }

            textBody.Text = r.Body.getMinMaxString();
            textAgility.Text = r.Agility.getMinMaxString();
            textReaction.Text = r.Reaction.getMinMaxString();
            textStrength.Text = r.Strength.getMinMaxString();

            textWillpower.Text = r.Willpower.getMinMaxString();
            textLogic.Text = r.Logic.getMinMaxString();
            textIntuision.Text = r.Intuision.getMinMaxString();
            textCharisma.Text = r.Charisma.getMinMaxString();

        }
    }
}
