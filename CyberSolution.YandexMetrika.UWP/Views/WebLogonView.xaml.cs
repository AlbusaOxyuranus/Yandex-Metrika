using System;
using System.Collections.Generic;
using Windows.Foundation;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using CyberSolution.YandexMetrika.Shared;
using CyberSolution.YandexMetrika.Shared.ViewModels;
using BlackBee.Base;
using Windows.UI.Core;
using System.Threading.Tasks;

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
            DataContext = StoreStorage.CreateOrGet<LogonViewModel>();
            webViewControl.Source = new Uri(string.Format("https://oauth.yandex.ru/authorize?response_type=token&client_id=c087f4071220480dabba7a35f6172681&login_hint={0}&force_confirm=yes", StoreStorage.CreateOrGet<LogonViewModel>().Email, StoreStorage.CreateOrGet<LogonViewModel>().Password));
        }



        private  void WebViewControl_OnNavigationCompleted(WebView sender, WebViewNavigationCompletedEventArgs args)
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

                        var task = CounterViewModel.GetDataAsync();
                        task.ContinueWith((t) =>
                         {
                             StoreStorage.CreateOrGet<CounterViewModel>().Items = task.Result;
                             StoreStorage.CreateOrGet<SessionViewModel>().Token = token.Value;
                             this.Frame.Navigate(typeof(MainView));
                         }, TaskScheduler.FromCurrentSynchronizationContext());



                    };

                }
            }

        }

  
    }
}
