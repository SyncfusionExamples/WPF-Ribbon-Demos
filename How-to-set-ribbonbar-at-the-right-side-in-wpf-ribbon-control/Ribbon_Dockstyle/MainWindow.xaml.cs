using Syncfusion.Windows.Shared;
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

namespace Ribbon_Dockstyle
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

        private void ribbon_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            RibbonTabItemsControl ribbontabitem = VisualUtils.FindDescendant(this, typeof(RibbonTabItemsControl)) as RibbonTabItemsControl;
            double width = 0;
            foreach (Button item in VisualUtils.EnumChildrenOfType(ribbontabitem, typeof(Button)))
            {
                width = item.ActualWidth;
            }
            try
            {
                collapseRibbonBar.Width = ribbontabitem.ActualWidth - ((ribbonBar1.Width + ribbonBar2.Width)) - width + 7;
            }
            catch (Exception)
            {
            }
        }
    }
}
