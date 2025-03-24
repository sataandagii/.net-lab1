using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Report
    {
        public int OrganisationId { get; set; }
        public int DonorId { get; set; }
        public int RecievedMoney { get; set; }
        public int SpentMoney { get; set; }
        public DateTime DataWhenRecieved { get; set; }

    }
}
