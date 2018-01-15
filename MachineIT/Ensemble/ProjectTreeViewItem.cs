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
    class ProjectTreeViewItem : TreeViewItem
    {
    
        Image _image = null;
        TextBlock _textBlock = null;

        public ProjectTreeViewItem(string _text, Uri _Image)
        {
            StackPanel stack = new StackPanel();
            stack.Orientation = Orientation.Horizontal;
            

            _image = new Image();
            _image.Source = new BitmapImage( _Image);
            _image.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            _image.VerticalAlignment = System.Windows.VerticalAlignment.Center;
            _image.Width = 16;
            _image.Height = 16;
            _image.Margin = new Thickness(2);

            stack.Children.Add(_image);

            _textBlock = new TextBlock();
            _textBlock.Margin = new Thickness(2);
            _textBlock.VerticalAlignment = System.Windows.VerticalAlignment.Center;
            _textBlock.Text = _text;

            stack.Children.Add(_textBlock);

            Header = stack;

        }

    }
}
