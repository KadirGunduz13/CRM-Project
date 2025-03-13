using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_Odev
{
    internal class Campaign
    {
        public string Name { get; set; }
        public int Cost { get; set; }  // Kampanya maliyeti
        public int ROI { get; set; }   // Beklenen yatırım getirisi

        public Campaign(string name, int cost, int roi)
        {
            Name = name;
            Cost = cost;
            ROI = roi;
        }
    }
}
