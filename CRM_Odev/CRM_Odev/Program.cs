using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_Odev
{
    class Customer
    {
        public string Name { get; set; }
        public string City { get; set; }
        public int Priority { get; set; } // Müşteri talep önceliği (1-10)

        public Customer(string name, string city, int priority)
        {
            Name = name;
            City = city;
            Priority = priority;
        }
    }

    class Agent
    {
        public string Name { get; set; }
        public string City { get; set; }
        public int Capacity { get; set; } // Günlük bakabileceği müşteri sayısı

        public Agent(string name, string city, int capacity)
        {
            Name = name;
            City = city;
            Capacity = capacity;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Örnek müşteri listesi oluşturuyoruz
            List<Customer> customers = new List<Customer>
        {
            new Customer("Ahmet", "İstanbul", 7),
            new Customer("Zeynep", "Ankara", 5),
            new Customer("Mehmet", "İstanbul", 9),
            new Customer("Ayşe", "İzmir", 4)
        };

            // Örnek temsilci listesi oluşturuyoruz
            List<Agent> agents = new List<Agent>
        {
            new Agent("Ali", "İstanbul", 2),
            new Agent("Burcu", "Ankara", 1),
            new Agent("Cem", "İzmir", 1)
        };

            // Örnek kampanya listesi oluşturuyoruz
            List<Campaign> campaigns = new List<Campaign>
        {
            new Campaign("Google Ads", 50, 200),
            new Campaign("Instagram Reklamı", 30, 150),
            new Campaign("Facebook Reklamı", 20, 100),
            new Campaign("YouTube Sponsorluğu", 40, 180),
            new Campaign("LinkedIn Reklamı", 25, 120)
        };

            int budget = 70; // Şirketin maksimum harcayabileceği bütçe

            CRMSystem.SelectBestCampaigns(campaigns, budget);

            Console.WriteLine("Veri yapıları oluşturuldu!");
            Console.WriteLine();
            CRMSystem.AssignCustomersToAgents(customers, agents);
        }
    }
}
