using System.Configuration;
using System.Windows;

namespace CefSharpSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var defaultUrl = ConfigurationManager.AppSettings["defaultUrl"] ?? "http://thinktecture.com";

            DataContext = new MainWindowViewModel(defaultUrl);
        }
    }
}
