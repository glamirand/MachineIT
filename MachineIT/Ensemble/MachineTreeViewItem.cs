using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace MachineIT
{
    class MachineTreeViewItem: ProjectTreeViewItem
    {
        public MachineTreeViewItem(string _text): base(_text, new Uri("Images/DossierJaune.png", UriKind.Relative))
        {
            IsExpanded = true;
       
        }
           


    }
}
