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

            Console.WriteLine("1. Знайти донорів, які пожертвували в 3 і більше різні фонди, причому загальна сума перевищує 10000 грн.");
            foreach (var name in query1)
                Console.WriteLine($"\t{name}");
        }

        public void Last3Months()
        {
            var query2 = from organisation in Data.Organisations
                         join report in Data.Reports on organisation.OrganisationId equals report.OrganisationId
                         where report.DateWhenRecieved >= DateTime.Now.AddMonths(-3)
                         group report by organisation.OrganisationName into groupedReports
                         where groupedReports.Sum(rep => rep.SpentMoney) <= groupedReports.Sum(rep => rep.RecievedMoney) / 2
                         select groupedReports.Key;


            //var query2 = Data.Organisations.Join(Data.Reports,
            //                                organisation => organisation.OrganisationId,
            //                                report => report.OrganisationId,
            //                                (organisation, report) => new { organisation, report })
            //                                .Where(joined => joined.report.DateWhenRecieved >= DateTime.Now.AddMonths(-3))
            //                                .GroupBy(joined => joined.organisation.OrganisationName)
            //                                .Where(grouped => grouped.Sum(joined => joined.report.SpentMoney) <=
            //                                grouped.Sum(joined => joined.report.RecievedMoney) / 2)
            //                                .Select(g => g.Key);

            Console.WriteLine("2. Визначити фонди, які отримали найбільше коштів за останній\r\nквартал, але витратили менше 50%.");
            foreach (var name in query2)
                Console.WriteLine($"\t{name}");
        }

        public void Find6OrMoreUniqueDonations()
        {
            var query3 = from donor in Data.Donors
                         join report in Data.Reports on donor.DonorId equals report.DonorId
                         group report by donor.DonorName into groupedReports
                         where groupedReports.Select(grouped => grouped.OrganisationId).Distinct().Count() > 5
                         &&
                         groupedReports.Count() == groupedReports.Select(grouped => grouped.OrganisationId).Distinct().Count()
                         select groupedReports.Key;

            //var query3 = Data.Donors.Join(Data.Reports,
            //                        donor => donor.DonorId,
            //                        report => report.DonorId,
            //                        (donor, report) => new { donor, report })
            //                        .GroupBy(joined => joined.donor.DonorName)
            //                        .Where(grouped => grouped.Select(joined => joined.report.OrganisationId).Distinct().Count() > 5
            //                        &&
            //                        grouped.Select(joined => joined.report.OrganisationId).Distinct().Count() == grouped.Count())
            //                        .Select(g => g.Key);

            Console.WriteLine("3. Визначити донорів, які зробили внески у більше ніж 5 фондів, але не більше одного разу в кожен фонд.");

            foreach (var name in query3)
                Console.WriteLine($"\t{name}");
        }

        public void DonorsWith3OrganisationsWith2Projects()
        {
            var organisationsWith2Projects = from project in Data.Projects
                                             group project by project.OrganisationId into groupedProjects
                                             where groupedProjects.Count() >= 2
                                             select groupedProjects.Key;

            var validReports = from report in Data.Reports
                               where organisationsWith2Projects.Contains(report.OrganisationId)
                               select new { report.DonorId, report.OrganisationId, report.SpentMoney, report.RecievedMoney };

            var donorsWith3Organisations = from report in validReports
                                           group report by report.DonorId into groupedReports
                                           where groupedReports.Select(r => r.OrganisationId).Distinct().Count() >= 3
                                           select groupedReports.Key;

            var query4 = from report in validReports
                         where donorsWith3Organisations.Contains(report.DonorId)
                         group report by report.DonorId into groupedReports
                         select new
                         {
                             DonorName = Data.Donors.First(d => d.DonorId == groupedReports.Key).DonorName,
                             Average = groupedReports.Average(rep => (rep.SpentMoney / rep.RecievedMoney) * 200)
                         };

            Console.WriteLine("4. Знайти донорів, які фінансували принаймні три різні організації, де кожна організація реалізувала хоча б два проєкти, і визначити\r\nсередній відсоток витрат на адміністративні потреби у цих проєктах");

            foreach (var name in query4)
                Console.WriteLine($"\tДонор: {name.DonorName}, Відсоток витрат: {name.Average}%");

        }

    }
}
