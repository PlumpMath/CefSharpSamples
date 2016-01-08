using System;
using System.Configuration;
using System.Windows;
using CefSharp;

namespace CefSharpSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeCef();

            InitializeComponent();

            var defaultUrl = ConfigurationManager.AppSettings["defaultUrl"] ?? "http://thinktecture.com";

            DataContext = new MainWindowViewModel(defaultUrl);
        }

        private static void InitializeCef()
        {
            var cefSettings = new CefSettings();

            cefSettings.RegisterScheme(new CefCustomScheme()
            {
                SchemeName = "local",
                SchemeHandlerFactory = new CustomSchemeHandlerfactory(),
            });

            if (!Cef.Initialize(cefSettings))
            {
                throw new Exception("Unable to Initialize Cef");
            }
        }
    }
}
