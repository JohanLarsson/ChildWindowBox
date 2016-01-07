using System.Windows;

namespace ChildWindowBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var window = new Window { Content = new ContentView(), DataContext = this.DataContext };
            window.ShowDialog();
        }
    }
}
