using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_Odev
{
    class CRMSystem
    {
        public static void AssignCustomersToAgents(List<Customer> customers, List<Agent> agents)
        {
            // Müşterileri önceliklerine göre büyükten küçüğe sıralıyoruz
            customers = customers.OrderByDescending(c => c.Priority).ToList();

            // Her temsilcinin şu anki müşteri sayısını takip eden sözlük
            Dictionary<string, int> agentCapacity = agents.ToDictionary(a => a.Name, a => a.Capacity);

            // Müşteri - Temsilci eşleşmelerini tutacak liste
            List<(string Customer, string Agent)> assignments = new List<(string, string)>();

            foreach (var customer in customers)
            {
                // Aynı şehirde uygun bir temsilci bul
                var availableAgent = agents
                    .Where(a => a.City == customer.City && agentCapacity[a.Name] > 0)
                    .FirstOrDefault();

                if (availableAgent != null)
                {
                    // Atamayı yap ve temsilcinin kapasitesini azalt
                    assignments.Add((customer.Name, availableAgent.Name));
                    agentCapacity[availableAgent.Name]--;
                }
            }

            // Sonuçları ekrana yazdır
            Console.WriteLine("Müşteri - Temsilci Atamaları:");
            foreach (var assignment in assignments)
            {
                Console.WriteLine($"{assignment.Customer} --> {assignment.Agent}");
            }
        }

        public static void SelectBestCampaigns(List<Campaign> campaigns, int budget)
        {
            int n = campaigns.Count;
            int[,] dp = new int[n + 1, budget + 1];

            // Dinamik Programlama tablosu oluşturuluyor
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j <= budget; j++)
                {
                    if (campaigns[i - 1].Cost > j)
                    {
                        // Eğer kampanya bütçeyi aşıyorsa, önceki değeri al
                        dp[i, j] = dp[i - 1, j];
                    }
                    else
                    {
                        // Kampanya seçilirse ve seçilmezse toplam getiriler karşılaştırılıyor
                        dp[i, j] = Math.Max(dp[i - 1, j], campaigns[i - 1].ROI + dp[i - 1, j - campaigns[i - 1].Cost]);
                    }
                }
            }

            // Maksimum yatırım getirisini ekrana yazdır
            Console.WriteLine($"En yüksek ROI: {dp[n, budget]}");

            // Seçilen kampanyaları geri takip ederek belirleme
            int remainingBudget = budget;
            List<string> selectedCampaigns = new List<string>();

            for (int i = n; i > 0 && remainingBudget > 0; i--)
            {
                if (dp[i, remainingBudget] != dp[i - 1, remainingBudget])
                {
                    selectedCampaigns.Add(campaigns[i - 1].Name);
                    remainingBudget -= campaigns[i - 1].Cost;
                }
            }

            Console.WriteLine("Seçilen Kampanyalar:");
            selectedCampaigns.Reverse();
            foreach (var campaign in selectedCampaigns)
            {
                Console.WriteLine($"- {campaign}");
            }
        }
    }
}
