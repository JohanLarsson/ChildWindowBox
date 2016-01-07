using System.Linq;
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

        private void OnAddItemClick(object sender, RoutedEventArgs e)
        {
            var viewModel = (ViewModel)DataContext;
            viewModel.Strings.Add(viewModel.Strings.Count.ToString());
        }

        private void OnRemoveItemClick(object sender, RoutedEventArgs e)
        {
            var viewModel = (ViewModel)DataContext;
            if (viewModel.Strings.Count > 0)
            {
                viewModel.Strings.RemoveAt(viewModel.Strings.Count - 1);

            }
        }
    }
}
