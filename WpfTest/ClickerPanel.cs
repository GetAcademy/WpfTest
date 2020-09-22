using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace WpfTest
{
    class ClickerPanel : Canvas
    {
        private Label _label;
        private Button _button;
        int _count = 0;

        public ClickerPanel()
        {
            _button = new Button();
            _button.Content = "Trykk her!";
            Children.Add(_button);
            _button.Click += Button_Click;

            _label = new Label();
            _label.Content = "Du har klikket 0 ganger.";
            Children.Add(_label);
            SetTop(_label, 20);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _count++;
            _label.Content = $"Du har klikket {_count} ganger.";

            var button = (Button)sender;
            //button.Content = $"Du har klikket {_count} ganger.";

            if (_count == 10)
            {
                button.Click -= Button_Click;
            }
        }

        public void Reset()
        {
            _count = 0;
            _label.Content = $"Du har klikket {_count} ganger.";
        }
    }
}
