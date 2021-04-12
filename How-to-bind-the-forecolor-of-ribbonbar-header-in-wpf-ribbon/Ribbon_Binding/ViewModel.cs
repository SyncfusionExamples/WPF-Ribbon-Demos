using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Ribbon_Binding
{
    public class ViewModel
    {
        private SolidColorBrush ribbonbarBrush = new SolidColorBrush(Colors.Green);
        public SolidColorBrush RibbonBarBrush
        {
            get { return ribbonbarBrush; }
            set
            {
                ribbonbarBrush = value;
                OnPropertyChanged("RibbonBarBrush");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
