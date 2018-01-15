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
    class PieceTreeViewItem: ProjectTreeViewItem
    {
        public PieceTreeViewItem(string _text): base(_text, new Uri("images/Pignon.png", UriKind.Relative))
        {

       
        }
           


    }
}
