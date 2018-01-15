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
    class EnsembleTreeViewItem:TreeViewItem
    {
        Image _image = null;
        TextBlock _textBlock = null;

        public string Text
        {
            get { return _textBlock.Text; }
            set { _textBlock.Text = value; }
        }

        public EnsembleTreeViewItem()
        {
            StackPanel stack = new StackPanel();
            stack.Orientation = Orientation.Horizontal;
            

            _image = new Image();
            _image.Source = new BitmapImage( new Uri("images/RoueVisSansFin.png", UriKind.Relative));
            _image.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            _image.VerticalAlignment = System.Windows.VerticalAlignment.Center;
            _image.Width = 16;
            _image.Height = 16;
            _image.Margin = new Thickness(2);

            stack.Children.Add(_image);

            _textBlock = new TextBlock();
            _textBlock.Margin = new Thickness(2);
            _textBlock.VerticalAlignment = System.Windows.VerticalAlignment.Center;

            stack.Children.Add(_textBlock);

            Header = stack;

        }

    }
}
