using System.Net;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace SP_08._async_Love
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string url = @"https://www.google.com/search?sca_esv=029398843723f323&sca_upv=1&sxsrf=ADLYWIIBaFLruLbyihRkD5VlNapSovAdGA:1727678663822&q=frontend+vs+backend+meme&udm=2&fbs=AEQNm0B4j3QKI-NeS3I9QI4lfRITA3BMgTEoh7pxQl7OKOagFhQ5f-GTPpZVEZdeBF_-JXL4PW9TA5psBqLHDJ5Ovug5882aVWx6Twh3mEBB-KwduwSPO7MQQMu4UHtlqay6IHw2MgG6PgeZ4u_oKsGApgxraN2OsEe-24evB9GKIduYYoCmX9sFf6BiuTHA46Jg4uR64xpgkBYhUBUBW6-S0HQbJj4bxagAJgxDgeLB3C7LTsosONk&sa=X&ved=2ahUKEwi186vIiOqIAxVCcvEDHaR1DqAQtKgLegQIDhAB&biw=1310&bih=958&dpr=1";
        WebClient client = new();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void simpleDownloadButton_Click(object sender, RoutedEventArgs e)
        {
            var text = client.DownloadString(url);
            downloadTextBox.Text = text;
        }
        private void dontClickButton_Click(object sender, RoutedEventArgs e)
        {
            var tsk = client.DownloadStringTaskAsync(url);
            downloadTextBox.Text = tsk.Result;
        }
        private void taskDownloadButton_Click(object sender, RoutedEventArgs e)
        {

            var task = client.DownloadStringTaskAsync(url)
                .ContinueWith(t =>
                {

                    downloadTextBox.Text = t.Result;
                }, TaskScheduler.FromCurrentSynchronizationContext());

        }
        private void contextTaskDownloadButton_Click(object sender, RoutedEventArgs e)
        {
            var context = SynchronizationContext.Current;
            var task = client.DownloadStringTaskAsync(url)
                .ContinueWith(t =>
                {
                    context!.Send(_ =>
                    {
                        downloadTextBox.Text = t.Result;
                    }, null);
                });
        }
        private async void asyncAwaitButtonClickAsync(object sender, RoutedEventArgs e)
        {
            var text = await client.DownloadStringTaskAsync(url);
            downloadTextBox.Text = text;
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            downloadTextBox.Clear();
        }

    }
}