using System;
using System.Windows;

namespace WpfTest
{
    class TestProgram
    {
        [STAThread]
        public static void Main(string[] args)
        {
            var application = new Application();
            var window = new ClickerWindow();
            application.Run(window);
        }
    }
}
