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

namespace shadowrun_char_gen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<CharacterBase> Characters { get; private set; } = new ObservableCollection<CharacterBase>();

        public MainWindow()
        {
            InitializeComponent();

            tabControl.ItemsSource = Characters;
            tabControl.SelectedIndex = 0;
            Characters.CollectionChanged += Characters_CollectionChanged;
        }

        private void Characters_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e) {
            tabControl.UpdateLayout();
        }

        private void MenuItem_New(object sender, RoutedEventArgs e)
        {
            NewCharPriorities prioritiyWindow = new NewCharPriorities();
            string[] tempPriorities = new string[5];

            prioritiyWindow.ShowInTaskbar = false;
            prioritiyWindow.Owner = this;
            

            if (prioritiyWindow.ShowDialog() == true) {
                for (int i = 0; i < 5; i++) {
                    tempPriorities[i] = prioritiyWindow.Priorities[i].Text;
                }

                Characters.Add(new CharacterBase((Race)prioritiyWindow.listBoxRace.SelectedItem, tempPriorities));
            }

            prioritiyWindow.Close();
        }
    }
}
