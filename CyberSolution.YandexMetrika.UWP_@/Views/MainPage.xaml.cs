using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using CyberSolution.YandexMetrika.Shared.ViewModels;
using CyberSolution.YandexMetrika.UWP.Views;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace CyberSolution.YandexMetrika.UWP
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            DataContext=new LogonViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(WebLogonView));
        }
    }
}
