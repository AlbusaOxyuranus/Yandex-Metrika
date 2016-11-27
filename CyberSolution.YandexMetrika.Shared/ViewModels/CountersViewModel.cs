

using CyberSolution.YandexMetrika.BAL;

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
        ObservableCollection<CounterViewModel> _items;
        public ObservableCollection<CounterViewModel> Items
        {
            get
            {
                return _items;
            }

            set
            {
                _items = value;
                NotifyPropertyChanged();
            }
        }
        public string Name
        {
            get;set;
        }

        

        public static async Task<ObservableCollection<CounterViewModel>> GetDataAsync(string token)
        {
            await Task.Delay(100);
            ObservableCollection<CounterViewModel> collection = new ObservableCollection<CounterViewModel>();
            //collection.Add(new CounterViewModel() { Name = "softisfuture-seo-monnaanna" });

            using (var bc = new BussinessContext())
            {
               var result = await bc.GetCountersAsync(token);
                foreach (var item in result)
                {
                    collection.Add(new CounterViewModel() {Id=item.Id,Name = item.OwnerLogin});
                }
            }
                return collection;
        }

        public decimal Id { get; set; }
    }
}
