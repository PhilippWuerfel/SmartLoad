using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebService.Modelle
{
    public class LineData
    {
        public string DocType { get; set; }
        public string DocNo { get; set; }
        public string LineNo { get; set; }
        public string ItemNo { get; set; }
        public string Quantity { get; set; }
        public string UnitOfMeasure { get; set; }
    }
}
