using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace WpfTest
{
    class ClickerWindow : Window
    {
        private ClickerPanel[] _clickerPanels;

        public ClickerWindow()
        {
            Title = "Min WPF-test";
            _clickerPanels = new ClickerPanel[10];
            var canvas = new Canvas();
            Content = canvas;

            var button = new Button();
            button.Content = "Reset";
            canvas.Children.Add(button);
            button.Click += Button_Click;

            for (var i = 0; i < 10; i++)
            {
                var clickerPanel = new ClickerPanel();
                _clickerPanels[i] = clickerPanel;
                canvas.Children.Add(clickerPanel);
                Canvas.SetTop(clickerPanel, (i+1)*50);
            }


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (var clickerPanel in _clickerPanels)
            {
                clickerPanel.Reset();
            }
        }
    }
}
