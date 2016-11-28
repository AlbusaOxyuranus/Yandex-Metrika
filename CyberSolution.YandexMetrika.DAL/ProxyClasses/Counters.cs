

namespace CyberSolution.YandexMetrika.DAL.ProxyClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;
    using System.Threading.Tasks;

    [DataContract]
    [KnownType(typeof(Counter))]
    public class Counters
    {
        [DataMember(Name = "rows")]
        public int Rows { get; private set; }

        [DataMember(Name = "counters")]
        public List<Counter> list { get; set; }

        public Counters()
        {
            this.list = new List<Counter>();
        }

    }
}
