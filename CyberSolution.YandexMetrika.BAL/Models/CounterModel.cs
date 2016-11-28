namespace CyberSolution.YandexMetrika.BAL.Models
{
    public class CounterModel
    {
        public decimal Id { get; set; }
        public string Name { get; internal set; }
        public string OwnerLogin { get; set; }
        public object Site { get; internal set; }
        public Status Status { get; internal set; }
    }
}