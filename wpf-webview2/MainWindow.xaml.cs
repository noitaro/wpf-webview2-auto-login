using System.Windows;

namespace wpf_webview2
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // IDを自動入力する.
            webView.CoreWebView2.ExecuteScriptAsync($"document.querySelector('#LoginComponent > form > div.input-field-group > div:nth-child(1) > input[type=text]').value = '★★★ ID ★★★'");
            // パスワードを自動入力する.
            webView.CoreWebView2.ExecuteScriptAsync($"document.querySelector('#LoginComponent > form > div.input-field-group > div:nth-child(2) > input[type=password]').value = '★★★ パスワード ★★★'");
            // ログインをする.
            webView.CoreWebView2.ExecuteScriptAsync($"document.querySelector('#LoginComponent > form > button').click()");
        }
    }
}
