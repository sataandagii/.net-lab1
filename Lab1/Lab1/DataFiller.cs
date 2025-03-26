using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class DataFiller
    {
        public DataFiller(Data data) 
        {
            Data = data;
        }

        public Data Data { get; set; }
        public void FillData ()
        {
            Data.Organisations = new List<Organisation>()
            {
                new Organisation() 
                {
                    OrganisationId = 1,
                    OrganisationName = "Organisation 1"
                },

                new Organisation()
                {
                    OrganisationId = 2,
                    OrganisationName = "Organisation 2"
                },

                new Organisation()
                {
                    OrganisationId = 3,
                    OrganisationName = "Organisation 3"
                },

                new Organisation()
                {
                    OrganisationId = 4,
                    OrganisationName = "Organisation 4"
                },
                
                new Organisation()
                {
                    OrganisationId = 5,
                    OrganisationName = "Organisation 5"
                }
            };

            Data.Donors = new List<Donor>()
            {
                new Donor()
                {
                    DonorId = 1,
                    DonorName = "Ivan"
                },

                new Donor()
                {
                    DonorId = 2,
                    DonorName = "Andriy"
                },

                new Donor()
                {
                    DonorId = 3,
                    DonorName = "Viktoria"
                },

                new Donor()
                {
                    DonorId = 4,
                    DonorName = "Maksym"
                },

                new Donor()
                {
                    DonorId = 5,
                    DonorName = "Danylo"
                },

                new Donor()
                {
                    DonorId = 6,
                    DonorName = "Maria"
                },

                new Donor()
                {
                    DonorId = 7,
                    DonorName = "Anna"
                }
            };

            Data.Projects = new List<Project>()
            {
                new Project()
                {
                    ProjectName = "Project 1",
                    OrganisationId = 1
                },

                new Project()
                {
                    ProjectName = "Project 2",
                    OrganisationId = 1
                },

                new Project()
                {
                    ProjectName = "Project 3",
                    OrganisationId = 1
                },

                new Project()
                {
                    ProjectName = "Project 4",
                    OrganisationId = 1
                },

                new Project()
                {
                    ProjectName = "Project 5",
                    OrganisationId = 1
                },

                new Project()
                {
                    ProjectName = "Project 6",
                    OrganisationId = 2
                },

                new Project()
                {
                    ProjectName = "Project 7",
                    OrganisationId = 2
                },

                new Project()
                {
                    ProjectName = "Project 8",
                    OrganisationId = 3
                },

                new Project()
                {
                    ProjectName = "Project 9",
                    OrganisationId = 3
                },

                new Project()
                {
                    ProjectName = "Project 10",
                    OrganisationId = 3
                },

                new Project()
                {
                    ProjectName = "Project 11",
                    OrganisationId = 4
                },

                new Project()
                {
                    ProjectName = "Project 12",
                    OrganisationId = 4
                },

                new Project()
                {
                    ProjectName = "Project 13",
                    OrganisationId = 5
                },

                new Project()
                {
                    ProjectName = "Project 14",
                    OrganisationId = 5
                },

                new Project()
                {
                    ProjectName = "Project 15",
                    OrganisationId = 5
                },

                new Project()
                {
                    ProjectName = "Project 16",
                    OrganisationId = 5
                }
            };

            Data.Reports = new List<Report>()
            {
                new Report()
                {
                    OrganisationId = 1,
                    DonorId = 1, 
                    RecievedMoney = 500, 
                    SpentMoney = 380, 
                    DataWhenRecieved = new DateTime(2025, 3, 24)
                },

                new Report()
                {
                    OrganisationId = 2,
                    DonorId = 1,
                    RecievedMoney = 450,
                    SpentMoney = 300,
                    DataWhenRecieved = new DateTime(2025, 1, 14)
                },

                new Report()
                {
                    OrganisationId = 3,
                    DonorId = 1,
                    RecievedMoney = 900,
                    SpentMoney = 840,
                    DataWhenRecieved = new DateTime(2025, 2, 21)
                },

                new Report()
                {
                    OrganisationId = 4,
                    DonorId = 2,
                    RecievedMoney = 350,
                    SpentMoney = 225,
                    DataWhenRecieved = new DateTime(2025, 3, 4)
                },

                new Report()
                {
                    OrganisationId = 5,
                    DonorId = 2,
                    RecievedMoney = 600,
                    SpentMoney = 300,
                    DataWhenRecieved = new DateTime(2025, 2, 13)
                },

                new Report()
                {
                    OrganisationId = 1,
                    DonorId = 2,
                    RecievedMoney = 600,
                    SpentMoney = 300,
                    DataWhenRecieved = new DateTime(2025, 2, 13)
                },

                new Report()
                {
                    OrganisationId = 1,
                    DonorId = 3,
                    RecievedMoney = 600,
                    SpentMoney = 300,
                    DataWhenRecieved = new DateTime(2025, 2, 13)
                }

            };
        }
    }
}
