using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;


namespace shadowrun_char_gen
{
    public class PriorityItem : INotifyPropertyChanged
    {
        public char index;
        public string Text { get; private set; }
        public event PropertyChangedEventHandler PropertyChanged;

        public char Index
        {
            get { return index; }
            set
            {
                index = value;
                OnPropertyChanged("Index");
            }
        }

        public PriorityItem(char index, string text) {
            Index = index;
            Text = text;
        }

        private void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
