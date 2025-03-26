using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class DataQueries
    {
        public DataQueries(Data data) 
        {
            Data = data;
        }

        public Data Data { get; set; }

        public void DonatedTo3Organisations()
        {
            var query1 = from donor in Data.Donors
                         join report in Data.Reports on donor.DonorId equals report.DonorId
                         group report by donor.DonorName into groupedReports
                         where groupedReports.Select(r => r.OrganisationId).Distinct().Count() >= 3
                         &&
                         groupedReports.Select(r => r.RecievedMoney).Sum() > 1000
                         select groupedReports.Key;

            //var query1 = Data.Donors.Join(Data.Reports,
            //                        donor => donor.DonorId,
            //                        report => report.DonorId,
            //                        (donor, report) => new { donor, report })
            //                        .GroupBy(joined => joined.donor.DonorName)
            //                        .Where(grouped => grouped.Select(joined => joined.report.OrganisationId).Distinct().Count() >= 3
            //                        &&
            //                        grouped.Sum(joined => joined.report.RecievedMoney) > 1000)
            //                        .Select(g => g.Key);

            foreach (var name in query1)
                Console.WriteLine($"{name}");
        }

    }
}
