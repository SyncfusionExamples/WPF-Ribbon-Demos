using Syncfusion.Windows.Tools.Controls;
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

namespace Ribbon_TextBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Text2_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (Text2 != null && !string.IsNullOrEmpty(Text2.Text))
                Text2.SelectAll();
        }

        private void Text2_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (Text2 != null)
            {
                if (!Text2.IsKeyboardFocusWithin)
                {
                    e.Handled = true;
                    Text2.Focus();
                }
            }
        }
    }
}
