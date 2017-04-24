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

namespace shadowrun_char_gen
{
    /// <summary>
    /// Interaction logic for NewCharPriorities.xaml
    /// </summary>
    public partial class NewCharPriorities : Window
    {

        public List<PriorityItem> Priorities { get; private set; } = new List<PriorityItem>();
        
        public NewCharPriorities()
        {
            InitializeComponent();
            Priorities.Add(new PriorityItem('A', "Metatype"));
            Priorities.Add(new PriorityItem('B', "Attribute"));
            Priorities.Add(new PriorityItem('C', "Magic"));
            Priorities.Add(new PriorityItem('D', "Skills"));
            Priorities.Add(new PriorityItem('E', "Resources"));

            listViewSelectPriorities.ItemsSource = Priorities;
        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_OK(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
