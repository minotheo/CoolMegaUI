using System.Windows;
using System.Windows.Input;

namespace CoolMegaUI
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }

        private void Close_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void Minimize_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Maximize_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;

            AppLayout.CornerRadius = WindowState == WindowState.Maximized ? new CornerRadius(0) : new CornerRadius(30);
            SideBarLayout.CornerRadius = WindowState == WindowState.Maximized ? new CornerRadius(0) : new CornerRadius(25, 0, 0, 25);
        }
    }
}
