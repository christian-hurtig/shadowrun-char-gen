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

namespace shadowrun_char_gen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            NewCharPriorities prioritiyWindow = new NewCharPriorities();
            prioritiyWindow.ShowInTaskbar = false;
            prioritiyWindow.Owner = this;

            if (prioritiyWindow.ShowDialog() == true) {
                textBlockReturnValue.Text = prioritiyWindow.Priorities[0].Text;
            }

            prioritiyWindow.Close();
        }
    }
}
