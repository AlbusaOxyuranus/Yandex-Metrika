using System;
using System.Collections.Generic;
using Windows.Foundation;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using CyberSolution.YandexMetrika.Shared;
using CyberSolution.YandexMetrika.Shared.ViewModels;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace CyberSolution.YandexMetrika.UWP.Views
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class WebLogonView : Page
    {
        public WebLogonView()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            LogonViewModel login =new LogonViewModel();
            webViewControl.Source = new Uri(string.Format("https://oauth.yandex.ru/authorize?response_type=token&client_id=" +
                                                          "c087f4071220480dabba7a35f6172681" +
                                                          "&login_hint={0}&force_confirm=yes", login.Email,login.Password));
        }

        private void WebViewControl_OnNavigationCompleted(WebView sender, WebViewNavigationCompletedEventArgs args)
        {
            if (args.IsSuccess)
            {
                var regex = new System.Text.RegularExpressions.Regex("[?&#]access_token(?:=(?<token>[^&]*))?");

                var match = regex.Match(args.Uri.ToString());

                if (match.Success)
                {
                    var token = match.Groups["token"];
                    
                    if (!string.IsNullOrEmpty(token.Value))
                    {
                        this.Frame.Navigate(typeof(MainView));
                    }

                }
                //WwwFormUrlDecoder decoder=new WwwFormUrlDecoder(args.Uri.ToString());
                //foreach (var word in decoder)
                //{
                //    if (word.Name == "access_token")
                //    {

                //    }
                //}
                //                var regex = new System.Text.RegularExpressions.Regex("[?&]access_token(?:=(?<token>[^&]*))?");

                //var match = regex.Match(args.Uri.ToString());
                //if (match.Success)
                //{
                //    var str = match.Groups["token"];
                //}
            }
        }
    }
}
