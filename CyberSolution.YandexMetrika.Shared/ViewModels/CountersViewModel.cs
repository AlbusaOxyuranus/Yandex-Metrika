

namespace CyberSolution.YandexMetrika.Shared.ViewModels
{
    using BlackBee.Base;
    using System.Collections.ObjectModel;
    using System.Threading.Tasks;
    using System;

    public class CounterViewModel:ObservableObject
        ,ICounter
    {
        public CounterViewModel()
        {
            Items = new ObservableCollection<CounterViewModel>();

        }
        ObservableCollection<CounterViewModel> items;
        public ObservableCollection<CounterViewModel> Items
        {
            get
            {
                return items;
            }

            set
            {
                items = value;
                NotifyPropertyChanged();
            }
        }
        public string Name
        {
            get;set;
        }

        

        public static async Task<ObservableCollection<CounterViewModel>> GetDataAsync()
        {
            await Task.Delay(100);
            ObservableCollection<CounterViewModel> collection = new ObservableCollection<CounterViewModel>();
            collection.Add(new CounterViewModel() { Name = "softisfuture-seo-monnaanna" });
            return collection;
        }
    }
}
