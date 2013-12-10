using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arisoph.DAL.Common
{
    public class ResultItem
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public string ID { get; set; }

        public string URL { get; set; }

        public string Source { get; set; }

        public string FormattedPrice { get; set; }

        public string CurrencyCode { get; set; }
    }
}
