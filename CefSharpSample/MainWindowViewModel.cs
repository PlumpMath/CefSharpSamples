using System.Windows.Input;

namespace CefSharpSample
{
    public class MainWindowViewModel :ViewModelBase
    {
        private readonly string _defaultUrl;

        private string _browserTitle;

        public string BrowserTitle
        {
            get { return _browserTitle; }
            set { SetStringProperty("BrowserTitle", ref _browserTitle, value); }
        }

        private string _browserAddress;

        public string BrowserAddress
        {
            get { return _browserAddress; }
            set { SetStringProperty("BrowserAddress", ref _browserAddress, value); }
        }

        public MainWindowViewModel(string defaultUrl)
        {
            BrowserTitle = "Testbrowser";
            BrowserAddress = _defaultUrl = defaultUrl;
        }

        private ICommand _defaultCommand;
        public ICommand DefaultCommand => _defaultCommand ?? (_defaultCommand = new CommandHandler(() => BrowserAddress = _defaultUrl, true));

        private ICommand _openLocalFileCommand;

        public ICommand OpenLocalFileCommand => _openLocalFileCommand ?? (_openLocalFileCommand = new CommandHandler(OpenLocalFile, true));


        private ICommand _openEmbeddedFileCommand;
        public ICommand OpenEmbeddedFileCommand => _openEmbeddedFileCommand ?? (_openEmbeddedFileCommand = new CommandHandler(OpenEmbeddedFile, true));

        public void OpenLocalFile()
        {
            BrowserAddress = "local://dummypath/LocalSample.html";
        }


        public void OpenEmbeddedFile()
        {
            BrowserAddress = "embedded://dummypath/EmbeddedSample.html";
        }
    }
}
