using Microsoft.UI.Xaml;
using System;

namespace ex
{
    public partial class App : Application
    {
        private Window m_window;

        public App()
        {
            // 删除 InitializeComponent 调用，因为它可能没有被定义
        }

        protected override void OnLaunched(LaunchActivatedEventArgs args)
        {
            m_window = new MainWindow();
            m_window.Activate();
        }
    }
}
